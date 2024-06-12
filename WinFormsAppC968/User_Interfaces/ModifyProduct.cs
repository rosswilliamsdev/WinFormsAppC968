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

            // Update the part details
            product.Name = nameText;
            product.InStock = inventoryCount;
            product.Price = priceCost;
            product.Max = max;
            product.Min = min;


            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

