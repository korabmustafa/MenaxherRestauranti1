using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxherRestauranti.BLL;
using MenaxherRestauranti.BO;

namespace MenaxherRestauranti
{
    public partial class frm_categories : Form
    {
        private readonly AdministrationBLL administrationBLL;
        public frm_categories()
        {
            InitializeComponent();
            administrationBLL = new AdministrationBLL();
        }
        private void InitData()
        {
            var result = administrationBLL.GetAllCategories();
            dgv_Categories.DataSource = result;
        }
        private void frm_categories_Load(object sender, EventArgs e)
        {
            InitData();
        }
        private void ResetForm()
        {
            txt_CategoryName.Text = "";

        }

        private void txt_CategoryAdd_Click(object sender, EventArgs e)
        {

            if (txt_CategoryName.Text.Trim() != "")
            {
                int x = 1;
                Category category = new Category();
                category.CategoryName = txt_CategoryName.Text;
                category.InsertBy = x.ToString();
                category.LastUpdatedBy = x.ToString();
                category.UpdateNo = x;

                bool saved = administrationBLL.Add(category);

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
        }

        private void txt_CategoryReset_Click(object sender, EventArgs e)
        {
            if (txt_CategoryName.Text.Trim() != "")
            {
                if (MessageBox.Show("A jeni i sigurt?", caption: "vemendje", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ResetForm();
                }
            }
        }
    }
}
