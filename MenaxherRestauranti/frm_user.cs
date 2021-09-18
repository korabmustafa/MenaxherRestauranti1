using MenaxherRestauranti.App_code;
using MenaxherRestauranti.BLL;
using MenaxherRestauranti.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxherRestauranti
{
    public partial class frm_user : Form
    {

        private readonly AdministrationBLL administrationBLL;

        public frm_user()
        {
            InitializeComponent();
            administrationBLL = new AdministrationBLL();
        }
        private void InitData()
        {
            var result = administrationBLL.GetAllUsers();
            dgvUser.DataSource = result;
        }
        private void frm_user_Load(object sender, EventArgs e)
        {
            InitData();
        }
        private void ResetForm()
        {
            txt_Username.Text = txt_Password.Text = txt_Firstname.Text = txt_Lastname.Text = "";
        }
        private void btn_ResetUser_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text.Trim() != "" || txt_Password.Text.Trim() != "" || txt_Firstname.Text.Trim() != "" || txt_Lastname.Text != "")
            {
                if (MessageBox.Show("A jeni i sigurt?", caption: "vemendje", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ResetForm();
                }
            }
        }

        private void btn_ShtoUser_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text.Trim() == "" || txt_Password.Text.Trim() == "" || txt_Firstname.Text.Trim() == "" || txt_Lastname.Text.Trim() == "" || txt_ExpiresDate.Text == "")
            {
                MessageBox.Show("Plotesoni te gjitha detajet iu lutem");
                txt_Username.Focus();
            }
            else if (txt_Username.Text.Trim() != "" && txt_Password.Text.Trim() != "" && txt_Firstname.Text.Trim() != "" && txt_Lastname.Text.Trim() != "" || txt_ExpiresDate.Text == "")
            {
                int x = 1;

                User user = new User();
                user.Username = txt_Username.Text;
                user.Password = txt_Password.Text;
                user.Firstname = txt_Firstname.Text;
                user.Lastname = txt_Lastname.Text;
                user.RoleID = int.Parse(txt_userRoleID.Text);
                DateTime expireDate = Convert.ToDateTime(txt_ExpiresDate.Text);
                user.ExpiresDate = expireDate;
                user.InsertBy = x.ToString();
                user.LastUpdatedBy = x.ToString();
                bool saved = administrationBLL.Add(user);

                if (saved)
                {
                    InitData();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("User ekziston,shkruani nje tjeter");
                }
            }
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            if (txt_userRoleID.Text.Trim() != "")
            {
                User user = new User();
                user.RoleID = int.Parse(txt_userRoleID.Text);
                int saved = administrationBLL.DeleteUser(user.RoleID);

                if (saved != -1)
                {
                    InitData();
                    ResetForm();
                }
            }
            else
            {
                MessageBox.Show("S'mund ta fshije.");
            }
        }
    }
}
