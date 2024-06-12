using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppC968.InventoryPartProduct;

namespace WinFormsAppC968
{
    public partial class AddProduct : Form
    {

        private Inventory inventory;
        private Product product;
        private Random random = new Random();
        public AddProduct(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
            product = new Product();

            dataGridViewParts.DataSource = inventory.AllParts;
            dataGridViewParts.ReadOnly = true;
            dataGridViewParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewParts.MultiSelect = true;

            dataGridViewAssociatedParts.DataSource = product.AssociatedParts;
            dataGridViewAssociatedParts.ReadOnly = true;
            dataGridViewAssociatedParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAssociatedParts.MultiSelect = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addProductAddButton_Click(object sender, EventArgs e)
        {
            List<Part> selectedParts = new List<Part>();

            // Iterate through selected rows in the DataGridView and add the corresponding parts to the list
            foreach (DataGridViewRow row in dataGridViewParts.SelectedRows)
            {
                if (row.DataBoundItem is Part part)
                {
                    selectedParts.Add(part);
                }
            }


            foreach (Part part in selectedParts)
            {
                product.addAssociatedPart(part);
            }


            // Refresh the DataGridView for associated parts
            dataGridViewAssociatedParts.DataSource = null;
            dataGridViewAssociatedParts.DataSource = product.AssociatedParts;

            /* MessageBox.Show("Parts added to the product successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);*/

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Data from the form's text boxes
            string nameText = nameTextbox.Text;
            string inventoryText = inventoryTextbox.Text;
            string priceCostText = priceCostTextbox.Text;
            string maxText = maxTextbox.Text;
            string minText = minTextbox.Text;

            // Validate form inputs
            if (string.IsNullOrEmpty(nameText) ||
                string.IsNullOrWhiteSpace(inventoryText) ||
                string.IsNullOrWhiteSpace(priceCostText) ||
                string.IsNullOrWhiteSpace(maxText) ||
                string.IsNullOrWhiteSpace(minText))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Inputs for Inventory, Price, Max, and Min must be numbers
            if (!int.TryParse(inventoryText, out int inventoryCount))
            {
                MessageBox.Show("Inventory must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(priceCostText, out decimal priceCost))
            {
                MessageBox.Show("Price/Cost must be a decimal number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(maxText, out int max))
            {
                MessageBox.Show("Max must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(minText, out int min))
            {
                MessageBox.Show("Min must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Min should never be greater than max
            if (min > max)
            {
                MessageBox.Show("Min cannot be greater than Max.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ensure the associated parts list is not empty
            if (product.AssociatedParts.Count == 0)
            {
                MessageBox.Show("The product must have at least one associated part.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create and populate the new product
            Product newProduct = new Product
            {
                ProductID = inventory.GenerateRandomID(),
                Name = nameText,
                InStock = inventoryCount,
                Max = max,
                Min = min,
                Price = priceCost,
                AssociatedParts = new BindingList<Part>(product.AssociatedParts.ToList()) // Copy the associated parts list
            };

            // Add the new product to the inventory
            inventory.addProduct(newProduct);

            MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
