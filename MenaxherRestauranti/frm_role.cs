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
    public partial class frm_role : Form
    {
        private readonly AdministrationBLL administrationBLL;
        public frm_role()
        {
            InitializeComponent();
            administrationBLL = new AdministrationBLL();
        }

        private void frm_role_Load(object sender, EventArgs e)
        {
            InitData();
        }
        private void InitData()
        {
            var result = administrationBLL.GetAllRoles();
            dgvRoles.DataSource = result;
        }
        private void ResetForm()
        {
            txt_RoleID.Text = txt_RoleName.Text = "";
        }
        private void btn_RuajRole_Click(object sender, EventArgs e)
        {
            
            if (txt_RoleName.Text.Trim() != "")
            {
                int x = 1;
                Role role = new Role();
                role.RoleName = txt_RoleName.Text;
                role.InsertBy = x.ToString();
                role.LastUpdatedBy = x.ToString();
                //role.InsertDate = DateTime.Now;

                bool saved = administrationBLL.Add(role);

                if (saved)
                {
                    InitData();
                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Insertimi deshtoi");
                }
            }
            else
            {
                txt_RoleName.BackColor = Color.Red;
                txt_RoleName.Focus();
                txt_RoleName.SelectAll();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_RoleName.Text.Trim() != "" || txt_RoleID.Text!="")
            {
                if (MessageBox.Show("A jeni i sigurt?",caption:"vemendje",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ResetForm();
                }
            }         
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_RoleID.Text.Trim() !="")
            {
                Role role = new Role();
                role.RoleID = int.Parse(txt_RoleID.Text);
                int saved = administrationBLL.DeleteRole(role.RoleID);

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