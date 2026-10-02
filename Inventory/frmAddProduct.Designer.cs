namespace Inventory
{
    partial class frmAddProduct
    {

        private System.ComponentModel.IContainer components = null;

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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.dtPickerMfgDate = new System.Windows.Forms.DateTimePicker();
            this.dtPickerExpDate = new System.Windows.Forms.DateTimePicker();
            this.richTxtDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gridViewProductList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Location = new System.Drawing.Point(151, 57);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(197, 20);
            this.txtProductName.TabIndex = 0;
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSellPrice.Location = new System.Drawing.Point(151, 267);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(197, 20);
            this.txtSellPrice.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(151, 221);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(197, 20);
            this.txtQuantity.TabIndex = 2;
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Beverages",
            "Bread/Bakery",
            "Canned/Jarred Goods",
            "Dairy",
            "Frozen Goods",
            "Meat",
            "Personal Care",
            "Other"});
            this.cbCategory.Location = new System.Drawing.Point(151, 95);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(197, 21);
            this.cbCategory.TabIndex = 3;
            // 
            // dtPickerMfgDate
            // 
            this.dtPickerMfgDate.Location = new System.Drawing.Point(151, 137);
            this.dtPickerMfgDate.Name = "dtPickerMfgDate";
            this.dtPickerMfgDate.Size = new System.Drawing.Size(197, 20);
            this.dtPickerMfgDate.TabIndex = 4;
            // 
            // dtPickerExpDate
            // 
            this.dtPickerExpDate.Location = new System.Drawing.Point(151, 176);
            this.dtPickerExpDate.Name = "dtPickerExpDate";
            this.dtPickerExpDate.Size = new System.Drawing.Size(197, 20);
            this.dtPickerExpDate.TabIndex = 5;
            // 
            // richTxtDescription
            // 
            this.richTxtDescription.Location = new System.Drawing.Point(430, 101);
            this.richTxtDescription.Name = "richTxtDescription";
            this.richTxtDescription.Size = new System.Drawing.Size(312, 186);
            this.richTxtDescription.TabIndex = 6;
            this.richTxtDescription.Text = "";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(646, 305);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(96, 31);
            this.btnAddProduct.TabIndex = 7;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mfg. Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Exp. Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Qty.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sell Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(426, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Description";
            // 
            // gridViewProductList
            // 
            this.gridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewProductList.Location = new System.Drawing.Point(12, 353);
            this.gridViewProductList.Name = "gridViewProductList";
            this.gridViewProductList.RowHeadersVisible = false;
            this.gridViewProductList.Size = new System.Drawing.Size(730, 142);
            this.gridViewProductList.TabIndex = 16;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 507);
            this.Controls.Add(this.gridViewProductList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.richTxtDescription);
            this.Controls.Add(this.dtPickerExpDate);
            this.Controls.Add(this.dtPickerMfgDate);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtSellPrice);
            this.Controls.Add(this.txtProductName);
            this.Name = "frmAddProduct";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DateTimePicker dtPickerMfgDate;
        private System.Windows.Forms.DateTimePicker dtPickerExpDate;
        private System.Windows.Forms.RichTextBox richTxtDescription;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView gridViewProductList;
    }
}

