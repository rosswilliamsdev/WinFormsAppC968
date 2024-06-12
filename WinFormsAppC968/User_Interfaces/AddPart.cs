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
    public partial class AddPart : Form
    {

        private Inventory inventory;

        public AddPart(Inventory inventory)
        {
            InitializeComponent();
            this.inventory = inventory;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                machineOrCompanyLabel.Text = "Machine ID";
            }
            else
            {
                machineOrCompanyLabel.Text = "Company Name";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            //Data from the form's text boxes
            string idText = IDTextbox.Text;
            string nameText = nameTextbox.Text;
            string inventoryText = inventoryTextbox.Text;
            string priceCostText = priceCostTextbox.Text;
            string maxText = maxTextbox.Text;
            string minText = minTextbox.Text;
            string machineIDCompanyNameText = machineIDCompanyNameTextbox.Text;

            //Validate form inputs
            if (string.IsNullOrWhiteSpace(idText) ||
                string.IsNullOrEmpty(nameText) ||
                string.IsNullOrWhiteSpace(inventoryText) ||
                string.IsNullOrWhiteSpace(priceCostText) ||
                string.IsNullOrWhiteSpace(maxText) ||
                string.IsNullOrWhiteSpace(minText) ||
                string.IsNullOrEmpty(machineIDCompanyNameText))
            {
                isValid = false;
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Inputs for ID, Inventory, Price, Max, and Min must be numbers
            if (!int.TryParse(IDTextbox.Text, out int id))
            {
                isValid = false;
                MessageBox.Show("ID must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
            if (!int.TryParse(maxTextbox.Text, out int max))
            {
                isValid = false;
                MessageBox.Show("Max must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(minTextbox.Text, out int min))
            {
                isValid = false;
                MessageBox.Show("Min must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //min should never be greater than max
            if (min > max)
            {
                isValid = false;
                MessageBox.Show("Min cannot be greater than Max.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isValid)
            {
                Part newPart = null;

                if (inHouseRadioButton.Checked)
                {
                    // if it's an in house part, machine ID must be a number
                    if (!int.TryParse(machineIDCompanyNameText, out int machineID))
                    {
                        isValid = false;
                        MessageBox.Show("Machine ID must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    newPart = new InHousePart()
                    {
                        PartID = id,
                        Name = nameText,
                        Inventory = inventoryCount,
                        PriceCost = priceCost,
                        Max = max,
                        Min = min,
                        MachineID = machineID
                    };
                }
                else if (outsourcedRadioButton.Checked)
                {
                    newPart = new OutsourcedPart()
                    {
                        PartID = id,
                        Name = nameText,
                        Inventory = inventoryCount,
                        PriceCost = priceCost,
                        Max = max,
                        Min = min,
                        CompanyName = machineIDCompanyNameText
                    };
                }
                if (newPart != null)
                {
                    inventory.AllParts.Add(newPart);
                    MessageBox.Show("Part added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }

        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }
    }
}
