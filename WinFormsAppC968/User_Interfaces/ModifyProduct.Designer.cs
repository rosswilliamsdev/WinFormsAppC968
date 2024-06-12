using WinFormsAppC968.InventoryPartProduct;

namespace WinFormsAppC968
{
    partial class ModifyProduct
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
            components = new System.ComponentModel.Container();
            addButton = new Button();
            label8 = new Label();
            dataGridViewAssociatedParts = new DataGridView();
            partIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            inventoryDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            associatedPartsBindingSource = new BindingSource(components);
            productBindingSource = new BindingSource(components);
            button8 = new Button();
            textBox6 = new TextBox();
            partsLabel = new Label();
            dataGridViewParts = new DataGridView();
            partIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inventoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            allPartsBindingSource = new BindingSource(components);
            inventoryBindingSource = new BindingSource(components);
            deleteButton = new Button();
            cancelButton = new Button();
            saveButton = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            minTextbox = new TextBox();
            maxTextbox = new TextBox();
            priceCostTextbox = new TextBox();
            inventoryTextbox = new TextBox();
            nameTextbox = new TextBox();
            idTextbox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssociatedParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.Location = new Point(921, 284);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 44);
            addButton.TabIndex = 84;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(459, 318);
            label8.Name = "label8";
            label8.Size = new Size(228, 20);
            label8.TabIndex = 83;
            label8.Text = "Parts Associated with the Product";
            // 
            // dataGridViewAssociatedParts
            // 
            dataGridViewAssociatedParts.AutoGenerateColumns = false;
            dataGridViewAssociatedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAssociatedParts.Columns.AddRange(new DataGridViewColumn[] { partIDDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, inventoryDataGridViewTextBoxColumn1, minDataGridViewTextBoxColumn1, maxDataGridViewTextBoxColumn1 });
            dataGridViewAssociatedParts.DataSource = associatedPartsBindingSource;
            dataGridViewAssociatedParts.Location = new Point(459, 350);
            dataGridViewAssociatedParts.Name = "dataGridViewAssociatedParts";
            dataGridViewAssociatedParts.RowHeadersWidth = 51;
            dataGridViewAssociatedParts.RowTemplate.Height = 29;
            dataGridViewAssociatedParts.Size = new Size(537, 188);
            dataGridViewAssociatedParts.TabIndex = 82;
            // 
            // partIDDataGridViewTextBoxColumn1
            // 
            partIDDataGridViewTextBoxColumn1.DataPropertyName = "PartID";
            partIDDataGridViewTextBoxColumn1.HeaderText = "PartID";
            partIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            partIDDataGridViewTextBoxColumn1.Name = "partIDDataGridViewTextBoxColumn1";
            partIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // inventoryDataGridViewTextBoxColumn1
            // 
            inventoryDataGridViewTextBoxColumn1.DataPropertyName = "Inventory";
            inventoryDataGridViewTextBoxColumn1.HeaderText = "Inventory";
            inventoryDataGridViewTextBoxColumn1.MinimumWidth = 6;
            inventoryDataGridViewTextBoxColumn1.Name = "inventoryDataGridViewTextBoxColumn1";
            inventoryDataGridViewTextBoxColumn1.Width = 125;
            // 
            // minDataGridViewTextBoxColumn1
            // 
            minDataGridViewTextBoxColumn1.DataPropertyName = "Min";
            minDataGridViewTextBoxColumn1.HeaderText = "Min";
            minDataGridViewTextBoxColumn1.MinimumWidth = 6;
            minDataGridViewTextBoxColumn1.Name = "minDataGridViewTextBoxColumn1";
            minDataGridViewTextBoxColumn1.Width = 125;
            // 
            // maxDataGridViewTextBoxColumn1
            // 
            maxDataGridViewTextBoxColumn1.DataPropertyName = "Max";
            maxDataGridViewTextBoxColumn1.HeaderText = "Max";
            maxDataGridViewTextBoxColumn1.MinimumWidth = 6;
            maxDataGridViewTextBoxColumn1.Name = "maxDataGridViewTextBoxColumn1";
            maxDataGridViewTextBoxColumn1.Width = 125;
            // 
            // associatedPartsBindingSource
            // 
            associatedPartsBindingSource.DataMember = "AssociatedParts";
            associatedPartsBindingSource.DataSource = productBindingSource;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // button8
            // 
            button8.BackColor = SystemColors.Control;
            button8.Location = new Point(661, 15);
            button8.Name = "button8";
            button8.Size = new Size(64, 29);
            button8.TabIndex = 81;
            button8.Text = "Search";
            button8.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(751, 15);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(245, 27);
            textBox6.TabIndex = 80;
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Location = new Point(459, 50);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(134, 20);
            partsLabel.TabIndex = 79;
            partsLabel.Text = "All Candidate Parts";
            // 
            // dataGridViewParts
            // 
            dataGridViewParts.AutoGenerateColumns = false;
            dataGridViewParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParts.Columns.AddRange(new DataGridViewColumn[] { partIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, inventoryDataGridViewTextBoxColumn, minDataGridViewTextBoxColumn, maxDataGridViewTextBoxColumn });
            dataGridViewParts.DataSource = allPartsBindingSource;
            dataGridViewParts.Location = new Point(459, 82);
            dataGridViewParts.Name = "dataGridViewParts";
            dataGridViewParts.RowHeadersWidth = 51;
            dataGridViewParts.RowTemplate.Height = 29;
            dataGridViewParts.Size = new Size(537, 188);
            dataGridViewParts.TabIndex = 78;
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            partIDDataGridViewTextBoxColumn.HeaderText = "PartID";
            partIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            partIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // inventoryDataGridViewTextBoxColumn
            // 
            inventoryDataGridViewTextBoxColumn.DataPropertyName = "Inventory";
            inventoryDataGridViewTextBoxColumn.HeaderText = "Inventory";
            inventoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            inventoryDataGridViewTextBoxColumn.Name = "inventoryDataGridViewTextBoxColumn";
            inventoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // minDataGridViewTextBoxColumn
            // 
            minDataGridViewTextBoxColumn.DataPropertyName = "Min";
            minDataGridViewTextBoxColumn.HeaderText = "Min";
            minDataGridViewTextBoxColumn.MinimumWidth = 6;
            minDataGridViewTextBoxColumn.Name = "minDataGridViewTextBoxColumn";
            minDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            maxDataGridViewTextBoxColumn.HeaderText = "Max";
            maxDataGridViewTextBoxColumn.MinimumWidth = 6;
            maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            maxDataGridViewTextBoxColumn.Width = 125;
            // 
            // allPartsBindingSource
            // 
            allPartsBindingSource.DataMember = "AllParts";
            allPartsBindingSource.DataSource = inventoryBindingSource;
            // 
            // inventoryBindingSource
            // 
            inventoryBindingSource.DataSource = typeof(Inventory);
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(921, 587);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 44);
            deleteButton.TabIndex = 77;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(921, 649);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 44);
            cancelButton.TabIndex = 76;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += button2_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(817, 649);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 44);
            saveButton.TabIndex = 75;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(222, 373);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 74;
            label7.Text = "Min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 373);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 73;
            label6.Text = "Max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 323);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 72;
            label5.Text = "Price/Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 273);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 71;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 219);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 70;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 159);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 69;
            label2.Text = "ID";
            // 
            // minTextbox
            // 
            minTextbox.Location = new Point(286, 366);
            minTextbox.Name = "minTextbox";
            minTextbox.Size = new Size(90, 27);
            minTextbox.TabIndex = 68;
            // 
            // maxTextbox
            // 
            maxTextbox.Location = new Point(111, 366);
            maxTextbox.Name = "maxTextbox";
            maxTextbox.Size = new Size(90, 27);
            maxTextbox.TabIndex = 67;
            // 
            // priceCostTextbox
            // 
            priceCostTextbox.Location = new Point(111, 316);
            priceCostTextbox.Name = "priceCostTextbox";
            priceCostTextbox.Size = new Size(176, 27);
            priceCostTextbox.TabIndex = 66;
            // 
            // inventoryTextbox
            // 
            inventoryTextbox.Location = new Point(111, 266);
            inventoryTextbox.Name = "inventoryTextbox";
            inventoryTextbox.Size = new Size(176, 27);
            inventoryTextbox.TabIndex = 65;
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(111, 212);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(176, 27);
            nameTextbox.TabIndex = 64;
            // 
            // idTextbox
            // 
            idTextbox.Location = new Point(111, 159);
            idTextbox.Name = "idTextbox";
            idTextbox.ReadOnly = true;
            idTextbox.Size = new Size(176, 27);
            idTextbox.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 62;
            label1.Text = "Modify Product";
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 711);
            Controls.Add(addButton);
            Controls.Add(label8);
            Controls.Add(dataGridViewAssociatedParts);
            Controls.Add(button8);
            Controls.Add(textBox6);
            Controls.Add(partsLabel);
            Controls.Add(dataGridViewParts);
            Controls.Add(deleteButton);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(minTextbox);
            Controls.Add(maxTextbox);
            Controls.Add(priceCostTextbox);
            Controls.Add(inventoryTextbox);
            Controls.Add(nameTextbox);
            Controls.Add(idTextbox);
            Controls.Add(label1);
            Name = "ModifyProduct";
            Text = "ModifyProduct";
            Load += ModifyProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssociatedParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Label label8;
        private DataGridView dataGridViewAssociatedParts;
        private Button button8;
        private TextBox textBox6;
        private Label partsLabel;
        private DataGridView dataGridViewParts;
        private Button deleteButton;
        private Button cancelButton;
        private Button saveButton;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox minTextbox;
        private TextBox maxTextbox;
        private TextBox priceCostTextbox;
        private TextBox inventoryTextbox;
        private TextBox nameTextbox;
        private TextBox idTextbox;
        private Label label1;
        private DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
        private BindingSource associatedPartsBindingSource;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private BindingSource allPartsBindingSource;
        private BindingSource inventoryBindingSource;
    }
}