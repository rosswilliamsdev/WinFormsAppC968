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

            MessageBox.Show("Parts added to the product successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
