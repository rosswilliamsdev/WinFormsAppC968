using WinFormsAppC968.InventoryPartProduct;

namespace WinFormsAppC968
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewParts = new DataGridView();
            partIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inventoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceCostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            allPartsBindingSource5 = new BindingSource(components);
            inventoryBindingSource1 = new BindingSource(components);
            allPartsBindingSource2 = new BindingSource(components);
            allPartsBindingSource1 = new BindingSource(components);
            inventoryBindingSource = new BindingSource(components);
            allPartsBindingSource = new BindingSource(components);
            dataGridViewProducts = new DataGridView();
            productIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            inStockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            productsBindingSource3 = new BindingSource(components);
            productsBindingSource2 = new BindingSource(components);
            productsBindingSource1 = new BindingSource(components);
            partsLabel = new Label();
            productsLabel = new Label();
            partsAddButton = new Button();
            partsModifyButton = new Button();
            partsDeleteButton = new Button();
            productsDeleteButton = new Button();
            productsModifyButton = new Button();
            productsAddButton = new Button();
            exitButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            partsSearchButton = new Button();
            productsSearchButton = new Button();
            mainScreenHeader = new Label();
            productsBindingSource = new BindingSource(components);
            allPartsBindingSource3 = new BindingSource(components);
            allPartsBindingSource4 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource4).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewParts
            // 
            dataGridViewParts.AutoGenerateColumns = false;
            dataGridViewParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParts.Columns.AddRange(new DataGridViewColumn[] { partIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, inventoryDataGridViewTextBoxColumn, priceCostDataGridViewTextBoxColumn, minDataGridViewTextBoxColumn, maxDataGridViewTextBoxColumn });
            dataGridViewParts.DataSource = allPartsBindingSource5;
            dataGridViewParts.Location = new Point(30, 145);
            dataGridViewParts.Name = "dataGridViewParts";
            dataGridViewParts.RowHeadersWidth = 51;
            dataGridViewParts.RowTemplate.Height = 29;
            dataGridViewParts.Size = new Size(444, 188);
            dataGridViewParts.TabIndex = 0;
            dataGridViewParts.CellContentClick += dataGridView1_CellContentClick;
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
            // priceCostDataGridViewTextBoxColumn
            // 
            priceCostDataGridViewTextBoxColumn.DataPropertyName = "PriceCost";
            priceCostDataGridViewTextBoxColumn.HeaderText = "PriceCost";
            priceCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceCostDataGridViewTextBoxColumn.Name = "priceCostDataGridViewTextBoxColumn";
            priceCostDataGridViewTextBoxColumn.Width = 125;
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
            // allPartsBindingSource5
            // 
            allPartsBindingSource5.DataMember = "AllParts";
            allPartsBindingSource5.DataSource = inventoryBindingSource1;
            // 
            // inventoryBindingSource1
            // 
            inventoryBindingSource1.DataSource = typeof(Inventory);
            // 
            // allPartsBindingSource2
            // 
            allPartsBindingSource2.DataMember = "AllParts";
            allPartsBindingSource2.DataSource = inventoryBindingSource1;
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
            // dataGridViewProducts
            // 
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Columns.AddRange(new DataGridViewColumn[] { productIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn1, priceDataGridViewTextBoxColumn1, inStockDataGridViewTextBoxColumn, minDataGridViewTextBoxColumn1, maxDataGridViewTextBoxColumn1 });
            dataGridViewProducts.DataSource = productsBindingSource3;
            dataGridViewProducts.Location = new Point(588, 145);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.RowTemplate.Height = 29;
            dataGridViewProducts.Size = new Size(480, 188);
            dataGridViewProducts.TabIndex = 1;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            priceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            priceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // inStockDataGridViewTextBoxColumn
            // 
            inStockDataGridViewTextBoxColumn.DataPropertyName = "InStock";
            inStockDataGridViewTextBoxColumn.HeaderText = "InStock";
            inStockDataGridViewTextBoxColumn.MinimumWidth = 6;
            inStockDataGridViewTextBoxColumn.Name = "inStockDataGridViewTextBoxColumn";
            inStockDataGridViewTextBoxColumn.Width = 125;
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
            // productsBindingSource3
            // 
            productsBindingSource3.DataMember = "Products";
            productsBindingSource3.DataSource = inventoryBindingSource1;
            // 
            // productsBindingSource2
            // 
            productsBindingSource2.DataMember = "Products";
            productsBindingSource2.DataSource = inventoryBindingSource;
            // 
            // productsBindingSource1
            // 
            productsBindingSource1.DataMember = "Products";
            productsBindingSource1.DataSource = inventoryBindingSource;
            // 
            // partsLabel
            // 
            partsLabel.AutoSize = true;
            partsLabel.Location = new Point(26, 103);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(40, 20);
            partsLabel.TabIndex = 2;
            partsLabel.Text = "Parts";
            partsLabel.Click += label1_Click;
            // 
            // productsLabel
            // 
            productsLabel.AutoSize = true;
            productsLabel.Location = new Point(588, 103);
            productsLabel.Name = "productsLabel";
            productsLabel.Size = new Size(66, 20);
            productsLabel.TabIndex = 3;
            productsLabel.Text = "Products";
            // 
            // partsAddButton
            // 
            partsAddButton.BackgroundImageLayout = ImageLayout.None;
            partsAddButton.Location = new Point(260, 339);
            partsAddButton.Name = "partsAddButton";
            partsAddButton.Size = new Size(63, 42);
            partsAddButton.TabIndex = 4;
            partsAddButton.Text = "Add";
            partsAddButton.UseVisualStyleBackColor = true;
            partsAddButton.Click += partsAddButton_Click;
            // 
            // partsModifyButton
            // 
            partsModifyButton.Location = new Point(329, 339);
            partsModifyButton.Name = "partsModifyButton";
            partsModifyButton.Size = new Size(72, 42);
            partsModifyButton.TabIndex = 5;
            partsModifyButton.Text = "Modify";
            partsModifyButton.UseVisualStyleBackColor = true;
            partsModifyButton.Click += partsModifyButton_Click;
            // 
            // partsDeleteButton
            // 
            partsDeleteButton.Location = new Point(407, 339);
            partsDeleteButton.Name = "partsDeleteButton";
            partsDeleteButton.Size = new Size(63, 42);
            partsDeleteButton.TabIndex = 6;
            partsDeleteButton.Text = "Delete";
            partsDeleteButton.UseVisualStyleBackColor = true;
            partsDeleteButton.Click += partsDeleteButton_Click;
            // 
            // productsDeleteButton
            // 
            productsDeleteButton.Location = new Point(1005, 339);
            productsDeleteButton.Name = "productsDeleteButton";
            productsDeleteButton.Size = new Size(63, 42);
            productsDeleteButton.TabIndex = 9;
            productsDeleteButton.Text = "Delete";
            productsDeleteButton.UseVisualStyleBackColor = true;
            // 
            // productsModifyButton
            // 
            productsModifyButton.Location = new Point(927, 339);
            productsModifyButton.Name = "productsModifyButton";
            productsModifyButton.Size = new Size(72, 42);
            productsModifyButton.TabIndex = 8;
            productsModifyButton.Text = "Modify";
            productsModifyButton.UseVisualStyleBackColor = true;
            productsModifyButton.Click += productsModifyButton_Click;
            // 
            // productsAddButton
            // 
            productsAddButton.BackgroundImageLayout = ImageLayout.None;
            productsAddButton.Location = new Point(858, 339);
            productsAddButton.Name = "productsAddButton";
            productsAddButton.Size = new Size(63, 42);
            productsAddButton.TabIndex = 7;
            productsAddButton.Text = "Add";
            productsAddButton.UseVisualStyleBackColor = true;
            productsAddButton.Click += productsAddButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(1005, 481);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(63, 40);
            exitButton.TabIndex = 10;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += button7_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(312, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(904, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(164, 27);
            textBox2.TabIndex = 12;
            // 
            // partsSearchButton
            // 
            partsSearchButton.BackColor = SystemColors.Control;
            partsSearchButton.Location = new Point(212, 106);
            partsSearchButton.Name = "partsSearchButton";
            partsSearchButton.Size = new Size(94, 29);
            partsSearchButton.TabIndex = 13;
            partsSearchButton.Text = "Search";
            partsSearchButton.UseVisualStyleBackColor = false;
            partsSearchButton.Click += button8_Click;
            // 
            // productsSearchButton
            // 
            productsSearchButton.BackColor = SystemColors.Control;
            productsSearchButton.Location = new Point(804, 105);
            productsSearchButton.Name = "productsSearchButton";
            productsSearchButton.Size = new Size(94, 29);
            productsSearchButton.TabIndex = 14;
            productsSearchButton.Text = "Search";
            productsSearchButton.UseVisualStyleBackColor = false;
            // 
            // mainScreenHeader
            // 
            mainScreenHeader.AutoSize = true;
            mainScreenHeader.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            mainScreenHeader.Location = new Point(18, 10);
            mainScreenHeader.Name = "mainScreenHeader";
            mainScreenHeader.Size = new Size(261, 23);
            mainScreenHeader.TabIndex = 15;
            mainScreenHeader.Text = "Inventory Management System";
            mainScreenHeader.Click += label1_Click_1;
            // 
            // productsBindingSource
            // 
            productsBindingSource.DataMember = "Products";
            productsBindingSource.DataSource = inventoryBindingSource;
            // 
            // allPartsBindingSource3
            // 
            allPartsBindingSource3.DataMember = "AllParts";
            allPartsBindingSource3.DataSource = inventoryBindingSource1;
            // 
            // allPartsBindingSource4
            // 
            allPartsBindingSource4.DataMember = "AllParts";
            allPartsBindingSource4.DataSource = inventoryBindingSource1;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1093, 533);
            Controls.Add(mainScreenHeader);
            Controls.Add(productsSearchButton);
            Controls.Add(partsSearchButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(exitButton);
            Controls.Add(productsDeleteButton);
            Controls.Add(productsModifyButton);
            Controls.Add(productsAddButton);
            Controls.Add(partsDeleteButton);
            Controls.Add(partsModifyButton);
            Controls.Add(partsAddButton);
            Controls.Add(productsLabel);
            Controls.Add(partsLabel);
            Controls.Add(dataGridViewProducts);
            Controls.Add(dataGridViewParts);
            Name = "MainScreen";
            Text = "Main Screen";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource5).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewParts;
        private DataGridView dataGridViewProducts;
        private Label partsLabel;
        private Label productsLabel;
        private Button partsAddButton;
        private Button partsModifyButton;
        private Button partsDeleteButton;
        private Button productsDeleteButton;
        private Button productsModifyButton;
        private Button productsAddButton;
        private Button exitButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button partsSearchButton;
        private Button productsSearchButton;
        private Label mainScreenHeader;
        private BindingSource allPartsBindingSource;
        private BindingSource inventoryBindingSource;
        private DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn inStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn1;
        private BindingSource productsBindingSource1;
        private BindingSource productsBindingSource;
        private BindingSource allPartsBindingSource1;
        private BindingSource productsBindingSource2;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource allPartsBindingSource2;
        private BindingSource inventoryBindingSource1;
        private BindingSource productsBindingSource3;
        private BindingSource allPartsBindingSource4;
        private BindingSource allPartsBindingSource3;
        private DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inventoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceCostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private BindingSource allPartsBindingSource5;
    }
}
