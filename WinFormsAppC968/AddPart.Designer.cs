namespace WinFormsAppC968
{
    partial class AddPart
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            inHouseRadioButton = new RadioButton();
            outsourcedRadioButton = new RadioButton();
            IDTextbox = new TextBox();
            nameTextbox = new TextBox();
            inventoryTextbox = new TextBox();
            priceCostTextbox = new TextBox();
            maxTextbox = new TextBox();
            machineIDCompanyNameTextbox = new TextBox();
            minTextbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            machineOrCompanyLabel = new Label();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 20);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Add Part";
            // 
            // inHouseRadioButton
            // 
            inHouseRadioButton.AutoSize = true;
            inHouseRadioButton.Location = new Point(193, 17);
            inHouseRadioButton.Name = "inHouseRadioButton";
            inHouseRadioButton.Size = new Size(90, 24);
            inHouseRadioButton.TabIndex = 1;
            inHouseRadioButton.TabStop = true;
            inHouseRadioButton.Text = "In-House";
            inHouseRadioButton.UseVisualStyleBackColor = true;
            inHouseRadioButton.CheckedChanged += inHouseRadioButton_CheckedChanged;
            // 
            // outsourcedRadioButton
            // 
            outsourcedRadioButton.AutoSize = true;
            outsourcedRadioButton.Location = new Point(319, 16);
            outsourcedRadioButton.Name = "outsourcedRadioButton";
            outsourcedRadioButton.Size = new Size(106, 24);
            outsourcedRadioButton.TabIndex = 2;
            outsourcedRadioButton.TabStop = true;
            outsourcedRadioButton.Text = "Outsourced";
            outsourcedRadioButton.UseVisualStyleBackColor = true;
            // 
            // IDTextbox
            // 
            IDTextbox.Location = new Point(193, 80);
            IDTextbox.Name = "IDTextbox";
            IDTextbox.Size = new Size(176, 27);
            IDTextbox.TabIndex = 3;
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(193, 133);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(176, 27);
            nameTextbox.TabIndex = 4;
            // 
            // inventoryTextbox
            // 
            inventoryTextbox.Location = new Point(193, 187);
            inventoryTextbox.Name = "inventoryTextbox";
            inventoryTextbox.Size = new Size(176, 27);
            inventoryTextbox.TabIndex = 5;
            // 
            // priceCostTextbox
            // 
            priceCostTextbox.Location = new Point(193, 237);
            priceCostTextbox.Name = "priceCostTextbox";
            priceCostTextbox.Size = new Size(176, 27);
            priceCostTextbox.TabIndex = 6;
            // 
            // maxTextbox
            // 
            maxTextbox.Location = new Point(193, 287);
            maxTextbox.Name = "maxTextbox";
            maxTextbox.Size = new Size(90, 27);
            maxTextbox.TabIndex = 7;
            // 
            // machineIDCompanyNameTextbox
            // 
            machineIDCompanyNameTextbox.Location = new Point(193, 338);
            machineIDCompanyNameTextbox.Name = "machineIDCompanyNameTextbox";
            machineIDCompanyNameTextbox.Size = new Size(176, 27);
            machineIDCompanyNameTextbox.TabIndex = 8;
            // 
            // minTextbox
            // 
            minTextbox.Location = new Point(368, 291);
            minTextbox.Name = "minTextbox";
            minTextbox.Size = new Size(90, 27);
            minTextbox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 80);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 10;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 140);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 11;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 194);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 12;
            label4.Text = "Inventory";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 244);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 13;
            label5.Text = "Price/Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(130, 294);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 14;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(304, 294);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 15;
            label7.Text = "Min";
            // 
            // machineOrCompanyLabel
            // 
            machineOrCompanyLabel.AutoSize = true;
            machineOrCompanyLabel.Location = new Point(72, 341);
            machineOrCompanyLabel.Name = "machineOrCompanyLabel";
            machineOrCompanyLabel.Size = new Size(84, 20);
            machineOrCompanyLabel.TabIndex = 16;
            machineOrCompanyLabel.Text = "Machine ID";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(350, 383);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 44);
            saveButton.TabIndex = 17;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(454, 383);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 44);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += button2_Click;
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 454);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(machineOrCompanyLabel);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(minTextbox);
            Controls.Add(machineIDCompanyNameTextbox);
            Controls.Add(maxTextbox);
            Controls.Add(priceCostTextbox);
            Controls.Add(inventoryTextbox);
            Controls.Add(nameTextbox);
            Controls.Add(IDTextbox);
            Controls.Add(outsourcedRadioButton);
            Controls.Add(inHouseRadioButton);
            Controls.Add(label1);
            Name = "AddPart";
            Text = "Part";
            Load += AddPart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton inHouseRadioButton;
        private RadioButton outsourcedRadioButton;
        private TextBox IDTextbox;
        private TextBox nameTextbox;
        private TextBox inventoryTextbox;
        private TextBox priceCostTextbox;
        private TextBox maxTextbox;
        private TextBox machineIDCompanyNameTextbox;
        private TextBox minTextbox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label machineOrCompanyLabel;
        private Button saveButton;
        private Button cancelButton;
    }
}