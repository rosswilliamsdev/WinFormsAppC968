

using System.Linq;
using System.Windows.Forms;
using WinFormsAppC968.InventoryPartProduct;

namespace WinFormsAppC968
{
    public partial class MainScreen : Form
    {

        private Inventory inventory;

        public MainScreen()
        {
            InitializeComponent();
            inventory = new Inventory();

            dataGridViewParts.DataSource = inventory.AllParts;
            dataGridViewParts.ReadOnly = true;
            dataGridViewParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewParts.MultiSelect = true;

            dataGridViewProducts.DataSource = inventory.Products;
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.MultiSelect = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void partsDeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewParts.SelectedRows.Count > 0)
            {
                List<Part> partsToDelete = new List<Part>();
                bool canDelete = true;

                foreach (DataGridViewRow row in dataGridViewParts.SelectedRows)
                {
                    int index = row.Index;
                    if (index >= 0 && index < inventory.AllParts.Count)
                    {
                        Part partToDelete = inventory.AllParts[index];

                        // Check if the part is associated with any product
                        foreach (var product in inventory.Products)
                        {
                            if (product.AssociatedParts.Contains(partToDelete))
                            {
                                MessageBox.Show($"{product.Name} requires the associated part {partToDelete.Name}, therefore the part cannot be deleted.", "Product Requirement", MessageBoxButtons.OK);
                                canDelete = false;
                                break;
                            }
                        }

                        if (!canDelete)
                        {
                            break;
                        }

                        partsToDelete.Add(partToDelete);
                    }
                }

                if (canDelete)
                {
                    // Confirm delete
                    var confirmResult = MessageBox.Show("Are you sure you want to delete the selected part(s)?",
                                                        "Confirm Delete",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        foreach (Part partToDelete in partsToDelete)
                        {
                            inventory.deletePart(partToDelete);
                        }

                        MessageBox.Show("Parts deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView
                        dataGridViewParts.DataSource = null;
                        dataGridViewParts.DataSource = inventory.AllParts;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void partsAddButton_Click(object sender, EventArgs e)
        {
            AddPart addPartForm = new AddPart(inventory);
            addPartForm.ShowDialog();

            // After the form is closed, reset the data source of dataGridViewParts
            dataGridViewParts.DataSource = null;
            dataGridViewParts.DataSource = inventory.AllParts;
        }

        private void partsModifyButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewParts.SelectedRows.Count == 1)
            {
                int selectedIndex = dataGridViewParts.SelectedRows[0].Index;
                if (selectedIndex >= 0 && selectedIndex < inventory.AllParts.Count)
                {
                    Part selectedPart = inventory.AllParts[selectedIndex];
                    ModifyPart modifyPartForm = new ModifyPart(selectedPart, inventory);
                    modifyPartForm.ShowDialog();

                    // Refresh the DataGridView after modification
                    dataGridViewParts.Refresh();
                }
                else
                {
                    MessageBox.Show("Please select a valid part to modify.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dataGridViewParts.SelectedRows.Count > 1)
            {
                MessageBox.Show("Parts can only be modified one at a time.", "Multiple Parts Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Please select a part to modify.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void productsAddButton_Click(object sender, EventArgs e)
        {
            AddProduct addProductForm = new AddProduct(inventory);
            addProductForm.Show();
        }

        private void productsModifyButton_Click(object sender, EventArgs e)
        {

            if (dataGridViewProducts.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dataGridViewProducts.SelectedRows[0];
                if (selectedRow.DataBoundItem is Product product)
                {
                    ModifyProduct modifyProductForm = new ModifyProduct(product, inventory);
                    if (modifyProductForm.ShowDialog() == DialogResult.OK)
                    {
                        modifyProductForm.Show();
                    }
                }
            }
            else if (dataGridViewProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to modify.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Cannot modify multiple products simultaneously.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            /*ModifyProduct modifyProductForm = new ModifyProduct();*/
            /*modifyProductForm.Show();*/
        }

        private void productsDeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                List<Product> productsToDelete = new List<Product>();

                foreach (DataGridViewRow row in dataGridViewProducts.SelectedRows)
                {
                    int index = row.Index;
                    if (index >= 0 && index < inventory.Products.Count)
                    {
                        Product productToDelete = inventory.Products[index];
                        productsToDelete.Add(productToDelete);
                    }
                }

                    // Confirm delete
                    var confirmResult = MessageBox.Show("Are you sure you want to delete the selected product(s)?",
                                                        "Confirm Delete",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

                    if (confirmResult == DialogResult.Yes)
                    {
                        foreach (Product productToDelete in productsToDelete)
                        {
                        inventory.removeProduct(productToDelete.ProductID);
                        }

                        MessageBox.Show("Parts deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh the DataGridView
                        dataGridViewProducts.DataSource = null;
                        dataGridViewProducts.DataSource = inventory.Products;
                    }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
