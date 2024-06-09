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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppC968
{
    public partial class ModifyPart : Form
    {
        private Part part;
        private bool isChangingPartType = false;
        private Inventory inventory;
        public ModifyPart(Part part, Inventory inventory)
        {
            InitializeComponent();
            this.part = part;
            this.inventory = inventory;

            // Load part details into text boxes
            modifyPartIDTextbox.Text = part.PartID.ToString();
            modifyPartNameTexbox.Text = part.Name;
            modifyPartInventoryTextbox.Text = part.Inventory.ToString();
            modifyPartPriceCostTextbox.Text = part.PriceCost.ToString();
            modifyPartMaxTextbox.Text = part.Max.ToString();
            modifyPartMinTextbox.Text = part.Min.ToString();

            // Check if the part is an InHousePart or OutsourcedPart and set the corresponding radio button and text box
            if (part is InHousePart inHousePart)
            {
                inHouseRadioButton.Checked = true;
                modifyPartMachineIDOrCompanyNameTextbox.Text = inHousePart.MachineID.ToString();
            }
            else if (part is OutsourcedPart outsourcedPart)
            {
                outsourcedRadioButton.Checked = true;
                modifyPartMachineIDOrCompanyNameTextbox.Text = outsourcedPart.CompanyName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {

        }

        private void saveButtonModifyPart_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            // Data from the form's text boxes
            string nameText = modifyPartNameTexbox.Text;
            string inventoryText = modifyPartInventoryTextbox.Text;
            string priceCostText = modifyPartPriceCostTextbox.Text;
            string maxText = modifyPartMaxTextbox.Text;
            string minText = modifyPartMinTextbox.Text;
            string machineIDCompanyNameText = modifyPartMachineIDOrCompanyNameTextbox.Text;

            // Validate form inputs
            if (string.IsNullOrEmpty(nameText) ||
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
            part.Name = nameText;
            part.Inventory = inventoryCount;
            part.PriceCost = priceCost;
            part.Max = max;
            part.Min = min;

            if (part is InHousePart inHousePart)
            {
                // Parse machine ID from string to int
                if (int.TryParse(machineIDCompanyNameText, out int machineID))
                {
                    inHousePart.MachineID = machineID;
                }
                else
                {
                    // If machine ID is not a valid integer
                    isValid = false;
                    MessageBox.Show("Machine ID must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (part is OutsourcedPart outsourcedPart)
            {
                // Company name must be a string
                if (!int.TryParse(machineIDCompanyNameText, out _))
                {
                    outsourcedPart.CompanyName = machineIDCompanyNameText;
                }
                else
                {
                    isValid = false;
                    MessageBox.Show("Company Name cannot be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (isValid)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
