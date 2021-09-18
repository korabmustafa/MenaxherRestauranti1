using MenaxherRestauranti.App_code;
using MenaxherRestauranti.BLL;
using MenaxherRestauranti.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenaxherRestauranti
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void Login()
        {
            try {
                string username = txt_username.Text;
                string password = txt_password.Text;
                if (username != "" && password != "")
                {
                    AdministrationBLL administration = new AdministrationBLL();
                    User user = administration.Login(username, password);
                    UserSession.LoggedUser = user;
                    if (user != null)
                    {
                        if (user.ExpiresDate > DateTime.Now)
                        {
                            if (user.RoleID == 1)
                            {
                                frm_main frm_Main = new frm_main(user.RoleID);
                                this.Hide();
                                frm_Main.StartPosition = FormStartPosition.CenterScreen;
                                frm_Main.ShowDialog();

                            }
                            else if (user.RoleID == 2)
                            {
                                frm_main frm_Main = new frm_main(user.RoleID);
                                //frm_user frm_User = new frm_user();
                                this.Hide();
                                frm_Main.StartPosition = FormStartPosition.CenterScreen;
                                frm_Main.ShowDialog();
                              //  frm_User.Visible = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ka skaduar", "", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch { 

            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Login();

            //if (Login(username, password))
            //{
            //    MessageBox.Show("jeni kyqur");
            //}
            //else
            //    MessageBox.Show("jeni gabim");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
            txt_password.BackColor = Color.White;
        }

        private void txt_username_Click(object sender, EventArgs e)
        {
            txt_username.BackColor = Color.White;
        }
    }
}
    