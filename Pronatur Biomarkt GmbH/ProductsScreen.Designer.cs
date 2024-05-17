namespace Pronatur_Biomarkt_GmbH
{
    partial class ProductsScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductMarke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProductsPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProductCathegory = new System.Windows.Forms.ComboBox();
            this.buttonProductSave = new System.Windows.Forms.Button();
            this.buttonProductEdit = new System.Windows.Forms.Button();
            this.buttonProductClear = new System.Windows.Forms.Button();
            this.buttonProductDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.Color.Gray;
            this.textBoxProductName.Location = new System.Drawing.Point(97, 48);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(294, 20);
            this.textBoxProductName.TabIndex = 1;
            // 
            // textBoxProductMarke
            // 
            this.textBoxProductMarke.BackColor = System.Drawing.Color.Gray;
            this.textBoxProductMarke.Location = new System.Drawing.Point(97, 84);
            this.textBoxProductMarke.Name = "textBoxProductMarke";
            this.textBoxProductMarke.Size = new System.Drawing.Size(195, 20);
            this.textBoxProductMarke.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kathegorie";
            // 
            // textBoxProductsPrice
            // 
            this.textBoxProductsPrice.BackColor = System.Drawing.Color.Gray;
            this.textBoxProductsPrice.Location = new System.Drawing.Point(98, 165);
            this.textBoxProductsPrice.Name = "textBoxProductsPrice";
            this.textBoxProductsPrice.Size = new System.Drawing.Size(74, 20);
            this.textBoxProductsPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preis";
            // 
            // comboBoxProductCathegory
            // 
            this.comboBoxProductCathegory.BackColor = System.Drawing.Color.Gray;
            this.comboBoxProductCathegory.FormattingEnabled = true;
            this.comboBoxProductCathegory.Items.AddRange(new object[] {
            "Obst",
            "Gemüse",
            "Fleisch",
            "Fisch",
            "Konserven",
            "Drogerie",
            "Getränke"});
            this.comboBoxProductCathegory.Location = new System.Drawing.Point(98, 121);
            this.comboBoxProductCathegory.Name = "comboBoxProductCathegory";
            this.comboBoxProductCathegory.Size = new System.Drawing.Size(194, 21);
            this.comboBoxProductCathegory.TabIndex = 8;
            // 
            // buttonProductSave
            // 
            this.buttonProductSave.BackColor = System.Drawing.Color.Gray;
            this.buttonProductSave.ForeColor = System.Drawing.Color.White;
            this.buttonProductSave.Location = new System.Drawing.Point(97, 207);
            this.buttonProductSave.Name = "buttonProductSave";
            this.buttonProductSave.Size = new System.Drawing.Size(75, 23);
            this.buttonProductSave.TabIndex = 9;
            this.buttonProductSave.Text = "Speichern";
            this.buttonProductSave.UseVisualStyleBackColor = false;
            this.buttonProductSave.Click += new System.EventHandler(this.buttonProductSave_Click);
            // 
            // buttonProductEdit
            // 
            this.buttonProductEdit.BackColor = System.Drawing.Color.Gray;
            this.buttonProductEdit.ForeColor = System.Drawing.Color.White;
            this.buttonProductEdit.Location = new System.Drawing.Point(179, 207);
            this.buttonProductEdit.Name = "buttonProductEdit";
            this.buttonProductEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonProductEdit.TabIndex = 10;
            this.buttonProductEdit.Text = "Bearbeiten";
            this.buttonProductEdit.UseVisualStyleBackColor = false;
            this.buttonProductEdit.Click += new System.EventHandler(this.buttonProductEdit_Click);
            // 
            // buttonProductClear
            // 
            this.buttonProductClear.BackColor = System.Drawing.Color.Gray;
            this.buttonProductClear.ForeColor = System.Drawing.Color.White;
            this.buttonProductClear.Location = new System.Drawing.Point(261, 207);
            this.buttonProductClear.Name = "buttonProductClear";
            this.buttonProductClear.Size = new System.Drawing.Size(75, 23);
            this.buttonProductClear.TabIndex = 11;
            this.buttonProductClear.Text = "Leeren";
            this.buttonProductClear.UseVisualStyleBackColor = false;
            this.buttonProductClear.Click += new System.EventHandler(this.buttonProductClear_Click);
            // 
            // buttonProductDelete
            // 
            this.buttonProductDelete.BackColor = System.Drawing.Color.Gray;
            this.buttonProductDelete.ForeColor = System.Drawing.Color.White;
            this.buttonProductDelete.Location = new System.Drawing.Point(343, 207);
            this.buttonProductDelete.Name = "buttonProductDelete";
            this.buttonProductDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonProductDelete.TabIndex = 12;
            this.buttonProductDelete.Text = "Löschen";
            this.buttonProductDelete.UseVisualStyleBackColor = false;
            this.buttonProductDelete.Click += new System.EventHandler(this.buttonProductDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 240);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(914, 243);
            this.dataGridView1.TabIndex = 13;
            // 
            // ProductsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::Pronatur_Biomarkt_GmbH.Properties.Resources.ImgBgProducts;
            this.ClientSize = new System.Drawing.Size(938, 495);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonProductDelete);
            this.Controls.Add(this.buttonProductClear);
            this.Controls.Add(this.buttonProductEdit);
            this.Controls.Add(this.buttonProductSave);
            this.Controls.Add(this.comboBoxProductCathegory);
            this.Controls.Add(this.textBoxProductsPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProductMarke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProductsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductMarke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProductsPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProductCathegory;
        private System.Windows.Forms.Button buttonProductSave;
        private System.Windows.Forms.Button buttonProductEdit;
        private System.Windows.Forms.Button buttonProductClear;
        private System.Windows.Forms.Button buttonProductDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}