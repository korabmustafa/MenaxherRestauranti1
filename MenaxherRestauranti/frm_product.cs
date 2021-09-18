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
    public partial class frm_product : Form
    {
        private readonly AdministrationBLL administrationBLL;
        public frm_product()
        {
            InitializeComponent();
            administrationBLL = new AdministrationBLL();
        }
        private void InitData()
        {
            var result = administrationBLL.GetAllProducts();
            dgvProducts.DataSource = result;
        }
        private void frm_product_Load(object sender, EventArgs e)
        {
            InitData();
        }
        private void ResetForm()
        {
            txt_ProductID.Text = txt_ProductName.Text = txt_ProductPrice.Text = txt_CategoryID.Text = rich_ProductDescription.Text = "";
                
        }
        private void btn_ResetProduct_Click(object sender, EventArgs e)
        {
            if (txt_ProductID.Text.Trim() != "" || txt_ProductName.Text.Trim() != "" || txt_ProductPrice.Text.Trim() != "" || txt_CategoryID.Text.Trim() != "" || rich_ProductDescription.Text != "")
            {
                if (MessageBox.Show("A jeni i sigurt?", caption: "vemendje", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    ResetForm();
                }
            }
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            if (txt_ProductName.Text.Trim() != "")
            {
                int x = 1;
                Product product = new Product();
                product.productName = txt_ProductName.Text;
                product.productDescription = rich_ProductDescription.Text;
                product.categoryID = int.Parse(txt_CategoryID.Text);
                product.userID = int.Parse(txt_userID.Text);
                product.productPrice = decimal.Parse(txt_ProductPrice.Text);
                product.InsertBy = x.ToString();
                product.LastUpdatedBy = x.ToString();
                product.UpdateNo = x;
               
                bool saved = administrationBLL.Add(product);

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

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
