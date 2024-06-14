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
    public partial class ModifyProduct : Form
    {

        private Inventory inventory;
        private Product product;
        public ModifyProduct(Product product, Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
            this.product = product;

            // Load part details into text boxes
            idTextbox.Text = product.ProductID.ToString();
            nameTextbox.Text = product.Name;
            inventoryTextbox.Text = product.InStock.ToString();
            priceCostTextbox.Text = product.Price.ToString();
            maxTextbox.Text = product.Max.ToString();
            minTextbox.Text = product.Min.ToString();


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

        private void ModifyProduct_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            // Data from the form's text boxes
            string nameText = nameTextbox.Text.Trim();
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
                isValid = false;
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Inputs for ID, Inventory, Price, Max, and Min must be numbers
            if (!int.TryParse(inventoryText, out int inventoryCount))
            {
                isValid = false;
                MessageBox.Show("Inventory must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(priceCostText, out decimal priceCost))
            {
                isValid = false;
                MessageBox.Show("Price/Cost must be a decimal number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(maxText, out int max))
            {
                isValid = false;
                MessageBox.Show("Max must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(minText, out int min))
            {
                isValid = false;
                MessageBox.Show("Min must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Min should never be greater than max
            if (min > max)
            {
                isValid = false;
                MessageBox.Show("Min cannot be greater than Max.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (product.AssociatedParts.Count == 0)
            {
                isValid = false;
                MessageBox.Show("Product must have associated parts.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (isValid)
            {
                // Update the part details
                product.Name = nameText;
                product.InStock = inventoryCount;
                product.Price = priceCost;
                product.Max = max;
                product.Min = min;

                MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            List<Part> selectedParts = new List<Part>();

            // Iterate through selected rows in the DataGridView and add the corresponding parts to the list
            foreach (DataGridViewRow row in dataGridViewParts.SelectedRows)
            {
                if (row.DataBoundItem is Part part)
                {   //Check if part is already in associated parts
                    if (product.AssociatedParts.Contains(part))
                    {
                        continue;
                    }

                    selectedParts.Add(part);
                }
            }

            // Add the parts that pass validation
            foreach (Part part in selectedParts)
            {
                product.addAssociatedPart(part);
            }


            // Refresh the DataGridView for associated parts
            dataGridViewAssociatedParts.DataSource = null;
            dataGridViewAssociatedParts.DataSource = product.AssociatedParts;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssociatedParts.SelectedRows.Count > 0)
            {
                List<Part> associatedPartsToDelete = new List<Part>();

                foreach (DataGridViewRow row in dataGridViewAssociatedParts.SelectedRows)
                {
                    int index = row.Index;
                    if (index >= 0 && index < product.AssociatedParts.Count)
                    {
                        Part partToDelete = product.AssociatedParts[index];

                        associatedPartsToDelete.Add(partToDelete);
                    }
                }

                // Confirm delete
                var confirmResult = MessageBox.Show("Are you sure you want to delete the selected part(s)?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    foreach (Part partToDelete in associatedPartsToDelete)
                    {
                        product.removeAssociatedPart(partToDelete.PartID);
                    }

                    MessageBox.Show("Parts deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView
                    dataGridViewAssociatedParts.DataSource = null;
                    dataGridViewAssociatedParts.DataSource = product.AssociatedParts;
                }

            }
            else
            {
                MessageBox.Show("Please select a part to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextbox.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter text to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var searchResults = inventory.AllParts
            .Where(part =>
                part.Name.ToLower().Contains(searchText) ||
                part.PartID.ToString().Contains(searchText))
            .ToList();

            if (searchResults.Any())
            {
                dataGridViewParts.DataSource = null;
                dataGridViewParts.DataSource = searchResults;
            }
            else
            {
                MessageBox.Show("No matching parts found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewParts.DataSource = null;
                dataGridViewParts.DataSource = inventory.AllParts;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            //refresh the datagridview
            dataGridViewParts.DataSource = null;
            dataGridViewParts.DataSource = inventory.AllParts;
            searchTextbox.Text = string.Empty;
        }
    }
}



