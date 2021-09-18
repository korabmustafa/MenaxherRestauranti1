namespace MenaxherRestauranti
{
    partial class frm_product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_product));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rich_ProductDescription = new System.Windows.Forms.RichTextBox();
            this.txt_ProductPrice = new System.Windows.Forms.TextBox();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.txt_CategoryID = new System.Windows.Forms.TextBox();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ResetProduct = new System.Windows.Forms.Button();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Controls.Add(this.rich_ProductDescription);
            this.groupBox1.Controls.Add(this.txt_ProductPrice);
            this.groupBox1.Controls.Add(this.txt_ProductName);
            this.groupBox1.Controls.Add(this.txt_userID);
            this.groupBox1.Controls.Add(this.txt_CategoryID);
            this.groupBox1.Controls.Add(this.txt_ProductID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_ResetProduct);
            this.groupBox1.Controls.Add(this.btn_DeleteProduct);
            this.groupBox1.Controls.Add(this.btn_AddProduct);
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rich_ProductDescription
            // 
            this.rich_ProductDescription.BackColor = System.Drawing.Color.Orange;
            this.rich_ProductDescription.Location = new System.Drawing.Point(156, 102);
            this.rich_ProductDescription.Name = "rich_ProductDescription";
            this.rich_ProductDescription.Size = new System.Drawing.Size(346, 96);
            this.rich_ProductDescription.TabIndex = 3;
            this.rich_ProductDescription.Text = "";
            // 
            // txt_ProductPrice
            // 
            this.txt_ProductPrice.BackColor = System.Drawing.Color.Orange;
            this.txt_ProductPrice.Location = new System.Drawing.Point(156, 204);
            this.txt_ProductPrice.Name = "txt_ProductPrice";
            this.txt_ProductPrice.Size = new System.Drawing.Size(346, 20);
            this.txt_ProductPrice.TabIndex = 4;
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.BackColor = System.Drawing.Color.Orange;
            this.txt_ProductName.Location = new System.Drawing.Point(156, 75);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(346, 20);
            this.txt_ProductName.TabIndex = 2;
            // 
            // txt_CategoryID
            // 
            this.txt_CategoryID.BackColor = System.Drawing.Color.Orange;
            this.txt_CategoryID.Location = new System.Drawing.Point(156, 44);
            this.txt_CategoryID.Name = "txt_CategoryID";
            this.txt_CategoryID.Size = new System.Drawing.Size(346, 20);
            this.txt_CategoryID.TabIndex = 1;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.BackColor = System.Drawing.Color.Orange;
            this.txt_ProductID.Location = new System.Drawing.Point(156, 13);
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.ReadOnly = true;
            this.txt_ProductID.Size = new System.Drawing.Size(346, 20);
            this.txt_ProductID.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Product Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Product Description :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "CategoryID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ProductID :";
            // 
            // btn_ResetProduct
            // 
            this.btn_ResetProduct.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_ResetProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetProduct.Location = new System.Drawing.Point(423, 230);
            this.btn_ResetProduct.Name = "btn_ResetProduct";
            this.btn_ResetProduct.Size = new System.Drawing.Size(79, 29);
            this.btn_ResetProduct.TabIndex = 7;
            this.btn_ResetProduct.Text = "Reset";
            this.btn_ResetProduct.UseVisualStyleBackColor = false;
            this.btn_ResetProduct.Click += new System.EventHandler(this.btn_ResetProduct_Click);
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_DeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteProduct.Location = new System.Drawing.Point(291, 230);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(81, 29);
            this.btn_DeleteProduct.TabIndex = 6;
            this.btn_DeleteProduct.Text = "Delete";
            this.btn_DeleteProduct.UseVisualStyleBackColor = false;
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddProduct.Location = new System.Drawing.Point(156, 230);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(86, 29);
            this.btn_AddProduct.TabIndex = 5;
            this.btn_AddProduct.Text = "Add";
            this.btn_AddProduct.UseVisualStyleBackColor = false;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProducts);
            this.panel1.Location = new System.Drawing.Point(1, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 232);
            this.panel1.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.DarkRed;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(3, 3);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.Size = new System.Drawing.Size(992, 229);
            this.dgvProducts.TabIndex = 8;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // txt_userID
            // 
            this.txt_userID.BackColor = System.Drawing.Color.DarkRed;
            this.txt_userID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_userID.ForeColor = System.Drawing.Color.DarkRed;
            this.txt_userID.Location = new System.Drawing.Point(847, 44);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(57, 13);
            this.txt_userID.TabIndex = 11;
            this.txt_userID.Text = "1";
            this.txt_userID.Visible = false;
            // 
            // frm_product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(997, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_product";
            this.Text = "ProductManager";
            this.Load += new System.EventHandler(this.frm_product_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btn_ResetProduct;
        private System.Windows.Forms.Button btn_DeleteProduct;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.RichTextBox rich_ProductDescription;
        private System.Windows.Forms.TextBox txt_ProductPrice;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.TextBox txt_CategoryID;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_userID;
    }
}