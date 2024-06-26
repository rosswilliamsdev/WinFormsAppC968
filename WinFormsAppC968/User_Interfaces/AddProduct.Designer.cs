﻿using WinFormsAppC968.InventoryPartProduct;

namespace WinFormsAppC968
{
    partial class AddProduct
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
            label1 = new Label();
            button2 = new Button();
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
            deleteButton = new Button();
            searchButton = new Button();
            searchTextbox = new TextBox();
            partsLabel = new Label();
            dataGridViewParts = new DataGridView();
            partIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inventoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            allPartsBindingSource1 = new BindingSource(components);
            inventoryBindingSource = new BindingSource(components);
            allPartsBindingSource = new BindingSource(components);
            dataGridViewAssociatedParts = new DataGridView();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            associatedPartsBindingSource = new BindingSource(components);
            productBindingSource = new BindingSource(components);
            label8 = new Label();
            addProductAddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssociatedParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // button2
            // 
            button2.Location = new Point(920, 655);
            button2.Name = "button2";
            button2.Size = new Size(75, 44);
            button2.TabIndex = 53;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(816, 655);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 44);
            saveButton.TabIndex = 52;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(221, 379);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 50;
            label7.Text = "Min";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 379);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 49;
            label6.Text = "Max";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 329);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 48;
            label5.Text = "Price/Cost";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 279);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 47;
            label4.Text = "Inventory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 225);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 46;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 165);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 45;
            label2.Text = "ID";
            // 
            // minTextbox
            // 
            minTextbox.Location = new Point(285, 372);
            minTextbox.Name = "minTextbox";
            minTextbox.Size = new Size(90, 27);
            minTextbox.TabIndex = 44;
            // 
            // maxTextbox
            // 
            maxTextbox.Location = new Point(110, 372);
            maxTextbox.Name = "maxTextbox";
            maxTextbox.Size = new Size(90, 27);
            maxTextbox.TabIndex = 42;
            // 
            // priceCostTextbox
            // 
            priceCostTextbox.Location = new Point(110, 322);
            priceCostTextbox.Name = "priceCostTextbox";
            priceCostTextbox.Size = new Size(176, 27);
            priceCostTextbox.TabIndex = 41;
            // 
            // inventoryTextbox
            // 
            inventoryTextbox.Location = new Point(110, 272);
            inventoryTextbox.Name = "inventoryTextbox";
            inventoryTextbox.Size = new Size(176, 27);
            inventoryTextbox.TabIndex = 40;
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(110, 218);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(176, 27);
            nameTextbox.TabIndex = 39;
            // 
            // idTextbox
            // 
            idTextbox.Location = new Point(110, 165);
            idTextbox.Name = "idTextbox";
            idTextbox.ReadOnly = true;
            idTextbox.Size = new Size(176, 27);
            idTextbox.TabIndex = 38;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(920, 593);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 44);
            deleteButton.TabIndex = 54;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.Control;
            searchButton.Location = new Point(660, 21);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(64, 29);
            searchButton.TabIndex = 58;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // searchTextbox
            // 
            searchTextbox.Location = new Point(750, 21);
            searchTextbox.Name = "searchTextbox";
            searchTextbox.Size = new Size(245, 27);
            searchTextbox.TabIndex = 57;
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Location = new Point(458, 56);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(134, 20);
            partsLabel.TabIndex = 56;
            partsLabel.Text = "All Candidate Parts";
            // 
            // dataGridViewParts
            // 
            dataGridViewParts.AutoGenerateColumns = false;
            dataGridViewParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParts.Columns.AddRange(new DataGridViewColumn[] { partIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, inventoryDataGridViewTextBoxColumn, minDataGridViewTextBoxColumn, maxDataGridViewTextBoxColumn });
            dataGridViewParts.DataSource = allPartsBindingSource1;
            dataGridViewParts.Location = new Point(458, 88);
            dataGridViewParts.Name = "dataGridViewParts";
            dataGridViewParts.RowHeadersWidth = 51;
            dataGridViewParts.RowTemplate.Height = 29;
            dataGridViewParts.Size = new Size(537, 188);
            dataGridViewParts.TabIndex = 55;
            dataGridViewParts.CellContentClick += dataGridViewParts_CellContentClick;
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
            // allPartsBindingSource1
            // 
            allPartsBindingSource1.DataMember = "AllParts";
            allPartsBindingSource1.DataSource = inventoryBindingSource;
            // 
            // inventoryBindingSource
            // 
            inventoryBindingSource.DataSource = typeof(Inventory);
            // 
            // allPartsBindingSource
            // 
            allPartsBindingSource.DataMember = "AllParts";
            allPartsBindingSource.DataSource = inventoryBindingSource;
            // 
            // dataGridViewAssociatedParts
            // 
            dataGridViewAssociatedParts.AutoGenerateColumns = false;
            dataGridViewAssociatedParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAssociatedParts.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn1, minDataGridViewTextBoxColumn1, maxDataGridViewTextBoxColumn1 });
            dataGridViewAssociatedParts.DataSource = associatedPartsBindingSource;
            dataGridViewAssociatedParts.Location = new Point(458, 356);
            dataGridViewAssociatedParts.Name = "dataGridViewAssociatedParts";
            dataGridViewAssociatedParts.RowHeadersWidth = 51;
            dataGridViewAssociatedParts.RowTemplate.Height = 29;
            dataGridViewAssociatedParts.Size = new Size(537, 188);
            dataGridViewAssociatedParts.TabIndex = 59;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.Width = 125;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(458, 324);
            label8.Name = "label8";
            label8.Size = new Size(228, 20);
            label8.TabIndex = 60;
            label8.Text = "Parts Associated with the Product";
            // 
            // addProductAddButton
            // 
            addProductAddButton.Location = new Point(920, 290);
            addProductAddButton.Name = "addProductAddButton";
            addProductAddButton.Size = new Size(75, 44);
            addProductAddButton.TabIndex = 61;
            addProductAddButton.Text = "Add";
            addProductAddButton.UseVisualStyleBackColor = true;
            addProductAddButton.Click += addProductAddButton_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 711);
            Controls.Add(addProductAddButton);
            Controls.Add(label8);
            Controls.Add(dataGridViewAssociatedParts);
            Controls.Add(searchButton);
            Controls.Add(searchTextbox);
            Controls.Add(partsLabel);
            Controls.Add(dataGridViewParts);
            Controls.Add(deleteButton);
            Controls.Add(button2);
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
            Name = "AddProduct";
            Text = "AddProduct";
            Load += AddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAssociatedParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
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
        private Button deleteButton;
        private Button searchButton;
        private TextBox searchTextbox;
        private Label partsLabel;
        private DataGridView dataGridViewParts;
        private DataGridView dataGridViewAssociatedParts;
        private Label label8;
        private Button addProductAddButton;
        private DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private BindingSource allPartsBindingSource;
        private BindingSource inventoryBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
        private BindingSource associatedPartsBindingSource;
        private BindingSource productBindingSource;
        private BindingSource allPartsBindingSource1;
    }
}