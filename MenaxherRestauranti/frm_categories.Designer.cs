namespace MenaxherRestauranti
{
    partial class frm_categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_categories));
            this.dgv_Categories = new System.Windows.Forms.DataGridView();
            this.txt_categoryID = new System.Windows.Forms.TextBox();
            this.txt_CategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CategoryAdd = new System.Windows.Forms.Button();
            this.txt_CategoryDelete = new System.Windows.Forms.Button();
            this.txt_CategoryReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categories)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Categories
            // 
            this.dgv_Categories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Categories.Location = new System.Drawing.Point(111, 180);
            this.dgv_Categories.Name = "dgv_Categories";
            this.dgv_Categories.Size = new System.Drawing.Size(717, 313);
            this.dgv_Categories.TabIndex = 2;
            // 
            // txt_categoryID
            // 
            this.txt_categoryID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_categoryID.BackColor = System.Drawing.Color.Orange;
            this.txt_categoryID.Location = new System.Drawing.Point(280, 24);
            this.txt_categoryID.Name = "txt_categoryID";
            this.txt_categoryID.ReadOnly = true;
            this.txt_categoryID.Size = new System.Drawing.Size(277, 20);
            this.txt_categoryID.TabIndex = 0;
            // 
            // txt_CategoryName
            // 
            this.txt_CategoryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_CategoryName.BackColor = System.Drawing.Color.Orange;
            this.txt_CategoryName.Location = new System.Drawing.Point(280, 89);
            this.txt_CategoryName.Name = "txt_CategoryName";
            this.txt_CategoryName.Size = new System.Drawing.Size(277, 20);
            this.txt_CategoryName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category Name :";
            // 
            // txt_CategoryAdd
            // 
            this.txt_CategoryAdd.BackColor = System.Drawing.Color.OrangeRed;
            this.txt_CategoryAdd.Location = new System.Drawing.Point(753, 12);
            this.txt_CategoryAdd.Name = "txt_CategoryAdd";
            this.txt_CategoryAdd.Size = new System.Drawing.Size(75, 43);
            this.txt_CategoryAdd.TabIndex = 3;
            this.txt_CategoryAdd.Text = "Add";
            this.txt_CategoryAdd.UseVisualStyleBackColor = false;
            this.txt_CategoryAdd.Click += new System.EventHandler(this.txt_CategoryAdd_Click);
            // 
            // txt_CategoryDelete
            // 
            this.txt_CategoryDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.txt_CategoryDelete.Location = new System.Drawing.Point(753, 61);
            this.txt_CategoryDelete.Name = "txt_CategoryDelete";
            this.txt_CategoryDelete.Size = new System.Drawing.Size(75, 47);
            this.txt_CategoryDelete.TabIndex = 3;
            this.txt_CategoryDelete.Text = "Delete";
            this.txt_CategoryDelete.UseVisualStyleBackColor = false;
            // 
            // txt_CategoryReset
            // 
            this.txt_CategoryReset.BackColor = System.Drawing.Color.OrangeRed;
            this.txt_CategoryReset.Location = new System.Drawing.Point(753, 114);
            this.txt_CategoryReset.Name = "txt_CategoryReset";
            this.txt_CategoryReset.Size = new System.Drawing.Size(75, 47);
            this.txt_CategoryReset.TabIndex = 3;
            this.txt_CategoryReset.Text = "Reset";
            this.txt_CategoryReset.UseVisualStyleBackColor = false;
            this.txt_CategoryReset.Click += new System.EventHandler(this.txt_CategoryReset_Click);
            // 
            // frm_categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(966, 522);
            this.Controls.Add(this.txt_CategoryReset);
            this.Controls.Add(this.txt_CategoryDelete);
            this.Controls.Add(this.txt_CategoryAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CategoryName);
            this.Controls.Add(this.txt_categoryID);
            this.Controls.Add(this.dgv_Categories);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_categories";
            this.Text = "CatagoriesManager";
            this.Load += new System.EventHandler(this.frm_categories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Categories;
        private System.Windows.Forms.TextBox txt_categoryID;
        private System.Windows.Forms.TextBox txt_CategoryName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txt_CategoryAdd;
        private System.Windows.Forms.Button txt_CategoryDelete;
        private System.Windows.Forms.Button txt_CategoryReset;
    }
}