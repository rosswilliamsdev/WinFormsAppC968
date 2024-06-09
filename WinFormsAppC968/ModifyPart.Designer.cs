namespace WinFormsAppC968
{
    partial class ModifyPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                machineOrCompanyLabel.Text = "Machine ID";
                isChangingPartType = true;
            }
            else
            {
                isChangingPartType = false;
            }
        }
        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                machineOrCompanyLabel.Text = "Company Name";
                isChangingPartType = true;
            }
            else
            {
                isChangingPartType = false;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            saveButtonModifyPart = new Button();
            machineOrCompanyLabel = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            modifyPartMinTextbox = new TextBox();
            modifyPartMachineIDOrCompanyNameTextbox = new TextBox();
            modifyPartMaxTextbox = new TextBox();
            modifyPartPriceCostTextbox = new TextBox();
            modifyPartInventoryTextbox = new TextBox();
            modifyPartNameTexbox = new TextBox();
            modifyPartIDTextbox = new TextBox();
            outsourcedRadioButton = new RadioButton();
            inHouseRadioButton = new RadioButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(449, 382);
            button2.Name = "button2";
            button2.Size = new Size(75, 44);
            button2.TabIndex = 37;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // saveButtonModifyPart
            // 
            saveButtonModifyPart.Location = new Point(345, 382);
            saveButtonModifyPart.Name = "saveButtonModifyPart";
            saveButtonModifyPart.Size = new Size(75, 44);
            saveButtonModifyPart.TabIndex = 36;
            saveButtonModifyPart.Text = "Save";
            saveButtonModifyPart.UseVisualStyleBackColor = true;
            saveButtonModifyPart.Click += saveButtonModifyPart_Click;
            // 
            // machineOrCompanyLabel
            // 
            machineOrCompanyLabel.AutoSize = true;
            machineOrCompanyLabel.Location = new Point(57, 340);
            machineOrCompanyLabel.Name = "machineOrCompanyLabel";
            machineOrCompanyLabel.Size = new Size(84, 20);
            machineOrCompanyLabel.TabIndex = 35;
            machineOrCompanyLabel.Text = "Machine ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(299, 293);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 34;
            label7.Text = "Min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(125, 293);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 33;
            label6.Text = "Max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 243);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 32;
            label5.Text = "Price/Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 193);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 31;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 139);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 30;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 79);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 29;
            label2.Text = "ID";
            // 
            // modifyPartMinTextbox
            // 
            modifyPartMinTextbox.Location = new Point(363, 286);
            modifyPartMinTextbox.Name = "modifyPartMinTextbox";
            modifyPartMinTextbox.Size = new Size(90, 27);
            modifyPartMinTextbox.TabIndex = 28;
            // 
            // modifyPartMachineIDOrCompanyNameTextbox
            // 
            modifyPartMachineIDOrCompanyNameTextbox.Location = new Point(188, 337);
            modifyPartMachineIDOrCompanyNameTextbox.Name = "modifyPartMachineIDOrCompanyNameTextbox";
            modifyPartMachineIDOrCompanyNameTextbox.Size = new Size(176, 27);
            modifyPartMachineIDOrCompanyNameTextbox.TabIndex = 27;
            // 
            // modifyPartMaxTextbox
            // 
            modifyPartMaxTextbox.Location = new Point(188, 286);
            modifyPartMaxTextbox.Name = "modifyPartMaxTextbox";
            modifyPartMaxTextbox.Size = new Size(90, 27);
            modifyPartMaxTextbox.TabIndex = 26;
            // 
            // modifyPartPriceCostTextbox
            // 
            modifyPartPriceCostTextbox.Location = new Point(188, 236);
            modifyPartPriceCostTextbox.Name = "modifyPartPriceCostTextbox";
            modifyPartPriceCostTextbox.Size = new Size(176, 27);
            modifyPartPriceCostTextbox.TabIndex = 25;
            // 
            // modifyPartInventoryTextbox
            // 
            modifyPartInventoryTextbox.Location = new Point(188, 186);
            modifyPartInventoryTextbox.Name = "modifyPartInventoryTextbox";
            modifyPartInventoryTextbox.Size = new Size(176, 27);
            modifyPartInventoryTextbox.TabIndex = 24;
            
            // 
            // modifyPartNameTexbox
            // 
            modifyPartNameTexbox.Location = new Point(188, 132);
            modifyPartNameTexbox.Name = "modifyPartNameTexbox";
            modifyPartNameTexbox.Size = new Size(176, 27);
            modifyPartNameTexbox.TabIndex = 23;
            modifyPartNameTexbox.TextChanged += textBox2_TextChanged;
            // 
            // modifyPartIDTextbox
            // 
            modifyPartIDTextbox.Location = new Point(188, 79);
            modifyPartIDTextbox.Name = "modifyPartIDTextbox";
            modifyPartIDTextbox.ReadOnly = true;
            modifyPartIDTextbox.Size = new Size(176, 27);
            modifyPartIDTextbox.TabIndex = 22;
            // 
            // outsourcedRadioButton
            // 
            outsourcedRadioButton.AutoSize = true;
            outsourcedRadioButton.Location = new Point(314, 15);
            outsourcedRadioButton.Name = "outsourcedRadioButton";
            outsourcedRadioButton.Size = new Size(106, 24);
            outsourcedRadioButton.TabIndex = 21;
            outsourcedRadioButton.TabStop = true;
            outsourcedRadioButton.Text = "Outsourced";
            outsourcedRadioButton.UseVisualStyleBackColor = true;
            outsourcedRadioButton.CheckedChanged += outsourcedRadioButton_CheckedChanged;

            // 
            // inHouseRadioButton
            // 
            inHouseRadioButton.AutoSize = true;
            inHouseRadioButton.Location = new Point(188, 16);
            inHouseRadioButton.Name = "inHouseRadioButton";
            inHouseRadioButton.Size = new Size(90, 24);
            inHouseRadioButton.TabIndex = 20;
            inHouseRadioButton.TabStop = true;
            inHouseRadioButton.Text = "In-House";
            inHouseRadioButton.UseVisualStyleBackColor = true;
            inHouseRadioButton.CheckedChanged += inHouseRadioButton_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 19);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 19;
            label1.Text = "Modify Part";
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 462);
            Controls.Add(button2);
            Controls.Add(saveButtonModifyPart);
            Controls.Add(machineOrCompanyLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(modifyPartMinTextbox);
            Controls.Add(modifyPartMachineIDOrCompanyNameTextbox);
            Controls.Add(modifyPartMaxTextbox);
            Controls.Add(modifyPartPriceCostTextbox);
            Controls.Add(modifyPartInventoryTextbox);
            Controls.Add(modifyPartNameTexbox);
            Controls.Add(modifyPartIDTextbox);
            Controls.Add(outsourcedRadioButton);
            Controls.Add(inHouseRadioButton);
            Controls.Add(label1);
            Name = "ModifyPart";
            Text = "Part";
            Load += ModifyPart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button saveButtonModifyPart;
        private Label machineOrCompanyLabel;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox modifyPartMinTextbox;
        private TextBox modifyPartMachineIDOrCompanyNameTextbox;
        private TextBox modifyPartMaxTextbox;
        private TextBox modifyPartPriceCostTextbox;
        private TextBox modifyPartInventoryTextbox;
        private TextBox modifyPartNameTexbox;
        private TextBox modifyPartIDTextbox;
        private RadioButton outsourcedRadioButton;
        private RadioButton inHouseRadioButton;
        private Label label1;
    }
}