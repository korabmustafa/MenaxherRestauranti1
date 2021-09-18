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
    public partial class frm_main : Form
    {
        private readonly int roli;

        public frm_main(int role)
        {
            InitializeComponent();

                roli = role;
                GetUser(roli);
        }

        private void GetUser(int roli)
        {
            if (roli == 2)
            {
                usersToolStripMenuItem.Enabled = false;
                rolesToolStripMenuItem.Enabled = false;
                productsToolStripMenuItem.Enabled = false;
                categoriesToolStripMenuItem.Enabled = false;
            }
        }

        private void frm_main_Shown(object sender, EventArgs e)
        {
            
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void frm_main_Shown_1(object sender, EventArgs e)
        {
            //frm_Login loginForm = new frm_Login();
            //loginForm.ShowDialog();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_role roleForm = new frm_role();
            roleForm.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_user userForm = new frm_user();
            userForm.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_product productForm = new frm_product();
            productForm.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cashier cashierForm = new frm_Cashier();
            cashierForm.Show();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categories frm_Categories = new frm_categories();
            frm_Categories.Show();
        }
    }
}
