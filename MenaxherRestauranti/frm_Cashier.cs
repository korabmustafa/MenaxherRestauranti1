using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxherRestauranti.App_code;
using MenaxherRestauranti.BLL;
using MenaxherRestauranti.BO;

namespace MenaxherRestauranti
{
    public partial class frm_Cashier : Form
    {
        private readonly AdministrationBLL administrationBLL;
        private List<Product> products = new List<Product>();

        private List<User> users = new List<User>();
     
        public frm_Cashier()
        {
            InitializeComponent();
            administrationBLL = new AdministrationBLL();

            products = administrationBLL.GetAllProducts(UserSession.LoggedUser.UserID);

            //users = administrationBLL.GetAllUsers();
            //ddlUsers.DataSource = users;
        }

        private void InitData()
        {
            //var result = administrationBLL.GetAllProducts(UserSession.LoggedUser.UserID);
            dgv_Cashier.DataSource = products;
        }

        private void InitData2()
        {
            var result2 = administrationBLL.GetAllOrderDetails();
            dgv_Orders.DataSource = result2;
        }

        private void InitData3()
        {
            var result3 = administrationBLL.getAllOrders();
            dgv_OrderGet.DataSource = result3;
        }

        private void frm_Cashier_Load(object sender, EventArgs e)
        {
            InitData();
            InitData2();
            InitData3();
        }

        private void ResetForm()
        {

        }

        private int GetProduct(DataGridView gridView, int row)
        {
            Product product = new Product
            {
                productID = (int)gridView["ProductID", row].Value
            };

            return product.productID;
        }

        private void btn_CashierAdd_Click(object sender, EventArgs e)
        {
            if (dgv_Cashier.SelectedRows.Count > 0)
            {
                var row = dgv_Cashier.SelectedRows[0].Index;
                if (row >= 0)
                {
                    var product = GetProduct(dgv_Cashier, row);
                    if (product > 0)
                    {
                        if (!string.IsNullOrEmpty(txt_CashierQuantity.Text))
                        {
                            var msgBox = MessageBox.Show("Do you want to add an order?", "Ask", MessageBoxButtons.YesNo);
                            if (msgBox == DialogResult.Yes)
                            {
                                Order order = new Order
                                {
                                    quantity = int.Parse(txt_CashierQuantity.Text),
                                    productID = product,
                                    userID = UserSession.LoggedUser.UserID,
                                    InsertBy = UserSession.LoggedUser.UserID.ToString(),
                                    LastUpdatedBy = UserSession.LoggedUser.UserID.ToString(),
                                };
                                order.UpdateNo++;

                                bool saved = administrationBLL.Add(order);

                                if (saved)
                                {
                                    InitData3();
                                    ResetForm();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Insertimi deshtoi");
                            }
                        }
                        
                    }
                }
            }

            //if (MessageBox.Show("Do you want to add an order?", "Ask", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    int x = 1;
            //    Order order = new Order
            //    {
            //        quantity = int.Parse(txt_CashierQuantity.Text),
            //        userID = UserSession.LoggedUser.UserID,
            //        InsertBy = x.ToString(),
            //        LastUpdatedBy = x.ToString(),
            //    };
            //    order.UpdateNo++;
            //    bool saved = administrationBLL.Add(order);

            //    if (saved)
            //    {
            //        InitData3();
            //        ResetForm();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Insertimi deshtoi");
            //}
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to print a receipt?", "Ask", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int x = 1;
                OrderDetail orderDetail = new OrderDetail
                {
                    orderSubtotal = decimal.Parse(txt_Subtotal.Text),
                    orderTotal = decimal.Parse(txt_Total.Text),
                    orderTax = decimal.Parse(txt_Tax.Text),
                    orderChange = decimal.Parse(txt_Change.Text),
                    orderCharge = decimal.Parse(txt_Charge.Text),
                    InsertBy = x.ToString(),
                    LastUpdatedBy = x.ToString(),
                    UpdateNo = x
                };
                bool saved = administrationBLL.Add(orderDetail);

                if (saved)
                {
                    InitData2();
                    ResetForm();
                }
            }
            else
            {
                MessageBox.Show("Insertimi deshtoi");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txt_CashierID.Text;

            var searchProducts = products.Where(f => f.productName.ToLower() == searchText.ToLower()).ToList();
            dgv_Cashier.DataSource = searchProducts;

        }
    }
}
//private void txt_CashierID_TextChanged(object sender, EventArgs e)
//{
//    if (txt_CashierID.Text.Trim() == "")
//    {
//        int x = 1;
//        OrderDetail orderDetail = new OrderDetail();
//        orderDetail.productID = int.Parse(txt_CashierID.Text);
//        orderDetail.InsertBy = x.ToString();
//        orderDetail.LastUpdatedBy = x.ToString();
//        orderDetail.UpdateNo = x;

//        int saved = administrationBLL.GetOrderDetails(orderDetail.productID);

//        if (saved == int.Parse(txt_CashierID.Text))
//        {
//            InitData();
//            ResetForm();
//        }


//    }
//}
//private void btn_Checkout_Click(object sender, EventArgs e)
//{
//    if (MessageBox.Show("Do you want to print a receipt?", "Ask", MessageBoxButtons.YesNo) == DialogResult.Yes)
//    {
//        int x = 1;
//        Order order = new Order();
//        order.orderSubtotal = decimal.Parse(txt_Subtotal.Text);
//        order.orderTax = decimal.Parse(txt_Tax.Text);
//        order.orderTotal = decimal.Parse(txt_Total.Text);
//        order.orderCharge = decimal.Parse(txt_Charge.Text);
//        order.orderChange = decimal.Parse(txt_Change.Text);
//        order.InsertBy = x.ToString();
//        order.LastUpdatedBy = x.ToString();
//        order.UpdateNo = x;
//        bool saved = administrationBLL.Add(order);

//        if (saved)
//        {
//            InitData();
//            ResetForm();
//        }
//        else
//        {
//            MessageBox.Show("Insertimi deshtoi");
//        }
//    }
//    else
//    {
//        MessageBox.Show("Palidhje");
//    }
//}


