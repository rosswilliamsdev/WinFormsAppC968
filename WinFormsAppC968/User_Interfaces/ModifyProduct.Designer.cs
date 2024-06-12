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
            button4 = new Button();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            button8 = new Button();
            textBox6 = new TextBox();
            partsLabel = new Label();
            dataGridViewParts = new DataGridView();
            button3 = new Button();
            cancelButton = new Button();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            productBindingSource = new BindingSource(components);
            inventoryBindingSource = new BindingSource(components);
            allPartsBindingSource = new BindingSource(components);
            partIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inventoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            associatedPartsBindingSource = new BindingSource(components);
            partIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            inventoryDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            minDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            maxDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(921, 284);
            button4.Name = "button4";
            button4.Size = new Size(75, 44);
            button4.TabIndex = 84;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { partIDDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, inventoryDataGridViewTextBoxColumn1, priceDataGridViewTextBoxColumn1, minDataGridViewTextBoxColumn1, maxDataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = associatedPartsBindingSource;
            dataGridView1.Location = new Point(459, 350);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(537, 188);
            dataGridView1.TabIndex = 82;
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
            dataGridViewParts.Columns.AddRange(new DataGridViewColumn[] { partIDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, inventoryDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, minDataGridViewTextBoxColumn, maxDataGridViewTextBoxColumn });
            dataGridViewParts.DataSource = allPartsBindingSource;
            dataGridViewParts.Location = new Point(459, 82);
            dataGridViewParts.Name = "dataGridViewParts";
            dataGridViewParts.RowHeadersWidth = 51;
            dataGridViewParts.RowTemplate.Height = 29;
            dataGridViewParts.Size = new Size(537, 188);
            dataGridViewParts.TabIndex = 78;
            // 
            // button3
            // 
            button3.Location = new Point(921, 587);
            button3.Name = "button3";
            button3.Size = new Size(75, 44);
            button3.TabIndex = 77;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
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
            // button1
            // 
            button1.Location = new Point(817, 649);
            button1.Name = "button1";
            button1.Size = new Size(75, 44);
            button1.TabIndex = 75;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
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
            // textBox7
            // 
            textBox7.Location = new Point(286, 366);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(90, 27);
            textBox7.TabIndex = 68;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(111, 366);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(90, 27);
            textBox5.TabIndex = 67;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(111, 316);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(176, 27);
            textBox4.TabIndex = 66;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(111, 266);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(176, 27);
            textBox3.TabIndex = 65;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 212);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(176, 27);
            textBox2.TabIndex = 64;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 159);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(176, 27);
            textBox1.TabIndex = 63;
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
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
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
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
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
            // associatedPartsBindingSource
            // 
            associatedPartsBindingSource.DataMember = "AssociatedParts";
            associatedPartsBindingSource.DataSource = productBindingSource;
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
            // priceDataGridViewTextBoxColumn1
            // 
            priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            priceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            priceDataGridViewTextBoxColumn1.Width = 125;
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
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 711);
            Controls.Add(button4);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(button8);
            Controls.Add(textBox6);
            Controls.Add(partsLabel);
            Controls.Add(dataGridViewParts);
            Controls.Add(button3);
            Controls.Add(cancelButton);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ModifyProduct";
            Text = "ModifyProduct";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParts).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)allPartsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)associatedPartsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Label label8;
        private DataGridView dataGridView1;
        private Button button8;
        private TextBox textBox6;
        private Label partsLabel;
        private DataGridView dataGridViewParts;
        private Button button3;
        private Button cancelButton;
        private Button button1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
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