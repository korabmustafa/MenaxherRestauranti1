namespace MenaxherRestauranti
{
    partial class frm_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_user));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Firstname = new System.Windows.Forms.TextBox();
            this.txt_Lastname = new System.Windows.Forms.TextBox();
            this.txt_userRoleID = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.txt_ExpiresDate = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.btn_ResetUser = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.btn_ShtoUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Firstname);
            this.groupBox1.Controls.Add(this.txt_Lastname);
            this.groupBox1.Controls.Add(this.txt_userRoleID);
            this.groupBox1.Controls.Add(this.txt_Password);
            this.groupBox1.Controls.Add(this.txt_UserID);
            this.groupBox1.Controls.Add(this.txt_ExpiresDate);
            this.groupBox1.Controls.Add(this.txt_Username);
            this.groupBox1.Controls.Add(this.btn_ResetUser);
            this.groupBox1.Controls.Add(this.btn_DeleteUser);
            this.groupBox1.Controls.Add(this.btn_ShtoUser);
            this.groupBox1.Location = new System.Drawing.Point(-5, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1040, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "RoleID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(140, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "ExpiresDate :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lastname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Firstname :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(186, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username :";
            // 
            // txt_Firstname
            // 
            this.txt_Firstname.BackColor = System.Drawing.Color.Orange;
            this.txt_Firstname.Location = new System.Drawing.Point(249, 181);
            this.txt_Firstname.Name = "txt_Firstname";
            this.txt_Firstname.Size = new System.Drawing.Size(265, 20);
            this.txt_Firstname.TabIndex = 3;
            // 
            // txt_Lastname
            // 
            this.txt_Lastname.BackColor = System.Drawing.Color.Orange;
            this.txt_Lastname.Location = new System.Drawing.Point(250, 219);
            this.txt_Lastname.Name = "txt_Lastname";
            this.txt_Lastname.Size = new System.Drawing.Size(264, 20);
            this.txt_Lastname.TabIndex = 4;
            // 
            // txt_userRoleID
            // 
            this.txt_userRoleID.BackColor = System.Drawing.Color.Orange;
            this.txt_userRoleID.Location = new System.Drawing.Point(248, 52);
            this.txt_userRoleID.Name = "txt_userRoleID";
            this.txt_userRoleID.Size = new System.Drawing.Size(267, 20);
            this.txt_userRoleID.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.Orange;
            this.txt_Password.Location = new System.Drawing.Point(250, 137);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(265, 20);
            this.txt_Password.TabIndex = 2;
            // 
            // txt_UserID
            // 
            this.txt_UserID.BackColor = System.Drawing.Color.Orange;
            this.txt_UserID.Location = new System.Drawing.Point(247, 14);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.ReadOnly = true;
            this.txt_UserID.Size = new System.Drawing.Size(267, 20);
            this.txt_UserID.TabIndex = 0;
            // 
            // txt_ExpiresDate
            // 
            this.txt_ExpiresDate.BackColor = System.Drawing.Color.Orange;
            this.txt_ExpiresDate.Location = new System.Drawing.Point(250, 258);
            this.txt_ExpiresDate.Name = "txt_ExpiresDate";
            this.txt_ExpiresDate.Size = new System.Drawing.Size(265, 20);
            this.txt_ExpiresDate.TabIndex = 1;
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.Orange;
            this.txt_Username.Location = new System.Drawing.Point(247, 96);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(265, 20);
            this.txt_Username.TabIndex = 1;
            // 
            // btn_ResetUser
            // 
            this.btn_ResetUser.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_ResetUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetUser.Location = new System.Drawing.Point(727, 227);
            this.btn_ResetUser.Name = "btn_ResetUser";
            this.btn_ResetUser.Size = new System.Drawing.Size(105, 51);
            this.btn_ResetUser.TabIndex = 7;
            this.btn_ResetUser.Text = "Reset";
            this.btn_ResetUser.UseVisualStyleBackColor = false;
            this.btn_ResetUser.Click += new System.EventHandler(this.btn_ResetUser_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_DeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteUser.Location = new System.Drawing.Point(726, 121);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(107, 51);
            this.btn_DeleteUser.TabIndex = 6;
            this.btn_DeleteUser.Text = "Delete";
            this.btn_DeleteUser.UseVisualStyleBackColor = false;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // btn_ShtoUser
            // 
            this.btn_ShtoUser.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_ShtoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShtoUser.Location = new System.Drawing.Point(727, 14);
            this.btn_ShtoUser.Name = "btn_ShtoUser";
            this.btn_ShtoUser.Size = new System.Drawing.Size(106, 51);
            this.btn_ShtoUser.TabIndex = 5;
            this.btn_ShtoUser.Text = "Add";
            this.btn_ShtoUser.UseVisualStyleBackColor = false;
            this.btn_ShtoUser.Click += new System.EventHandler(this.btn_ShtoUser_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvUser);
            this.panel1.Location = new System.Drawing.Point(-5, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 240);
            this.panel1.TabIndex = 1;
            // 
            // dgvUser
            // 
            this.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUser.BackgroundColor = System.Drawing.Color.DarkRed;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(0, 0);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 51;
            this.dgvUser.Size = new System.Drawing.Size(1040, 240);
            this.dgvUser.TabIndex = 8;
            // 
            // frm_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1036, 522);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_user";
            this.Text = "UserManager";
            this.Load += new System.EventHandler(this.frm_user_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TextBox txt_Firstname;
        private System.Windows.Forms.TextBox txt_Lastname;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Button btn_ResetUser;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Button btn_ShtoUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_userRoleID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ExpiresDate;
    }
}