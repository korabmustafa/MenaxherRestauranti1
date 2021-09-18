namespace MenaxherRestauranti
{
    partial class frm_Cashier
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cashier));
            this.txt_CashierID = new System.Windows.Forms.TextBox();
            this.txt_CashierQuantity = new System.Windows.Forms.TextBox();
            this.txt_Subtotal = new System.Windows.Forms.TextBox();
            this.txt_Tax = new System.Windows.Forms.TextBox();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.txt_Charge = new System.Windows.Forms.TextBox();
            this.txt_Change = new System.Windows.Forms.TextBox();
            this.fasdf = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ddd = new System.Windows.Forms.Label();
            this.ff = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Checkout = new System.Windows.Forms.Button();
            this.btn_CashierAdd = new System.Windows.Forms.Button();
            this.dgv_Cashier = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_Orders = new System.Windows.Forms.DataGridView();
            this.orderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_OrderGet = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cashier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderGet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CashierID
            // 
            this.txt_CashierID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_CashierID.BackColor = System.Drawing.Color.Orange;
            this.txt_CashierID.Location = new System.Drawing.Point(134, 18);
            this.txt_CashierID.Name = "txt_CashierID";
            this.txt_CashierID.Size = new System.Drawing.Size(334, 20);
            this.txt_CashierID.TabIndex = 0;
            // 
            // txt_CashierQuantity
            // 
            this.txt_CashierQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_CashierQuantity.BackColor = System.Drawing.Color.Orange;
            this.txt_CashierQuantity.Location = new System.Drawing.Point(134, 59);
            this.txt_CashierQuantity.Name = "txt_CashierQuantity";
            this.txt_CashierQuantity.Size = new System.Drawing.Size(334, 20);
            this.txt_CashierQuantity.TabIndex = 1;
            // 
            // txt_Subtotal
            // 
            this.txt_Subtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Subtotal.BackColor = System.Drawing.Color.Orange;
            this.txt_Subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Subtotal.Location = new System.Drawing.Point(1000, 33);
            this.txt_Subtotal.Name = "txt_Subtotal";
            this.txt_Subtotal.Size = new System.Drawing.Size(234, 20);
            this.txt_Subtotal.TabIndex = 2;
            // 
            // txt_Tax
            // 
            this.txt_Tax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Tax.BackColor = System.Drawing.Color.Orange;
            this.txt_Tax.Location = new System.Drawing.Point(1000, 122);
            this.txt_Tax.Name = "txt_Tax";
            this.txt_Tax.Size = new System.Drawing.Size(234, 20);
            this.txt_Tax.TabIndex = 3;
            // 
            // txt_Total
            // 
            this.txt_Total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Total.BackColor = System.Drawing.Color.Orange;
            this.txt_Total.Location = new System.Drawing.Point(1000, 202);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(234, 20);
            this.txt_Total.TabIndex = 4;
            // 
            // txt_Charge
            // 
            this.txt_Charge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Charge.BackColor = System.Drawing.Color.Orange;
            this.txt_Charge.Location = new System.Drawing.Point(1000, 284);
            this.txt_Charge.Name = "txt_Charge";
            this.txt_Charge.Size = new System.Drawing.Size(234, 20);
            this.txt_Charge.TabIndex = 5;
            // 
            // txt_Change
            // 
            this.txt_Change.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Change.BackColor = System.Drawing.Color.Orange;
            this.txt_Change.Location = new System.Drawing.Point(1000, 378);
            this.txt_Change.Name = "txt_Change";
            this.txt_Change.Size = new System.Drawing.Size(234, 20);
            this.txt_Change.TabIndex = 6;
            // 
            // fasdf
            // 
            this.fasdf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.fasdf.AutoSize = true;
            this.fasdf.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fasdf.Location = new System.Drawing.Point(62, 18);
            this.fasdf.Name = "fasdf";
            this.fasdf.Size = new System.Drawing.Size(66, 18);
            this.fasdf.TabIndex = 2;
            this.fasdf.Text = "Product :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(898, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subtotal";
            // 
            // ddd
            // 
            this.ddd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddd.AutoSize = true;
            this.ddd.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddd.Location = new System.Drawing.Point(893, 122);
            this.ddd.Name = "ddd";
            this.ddd.Size = new System.Drawing.Size(63, 18);
            this.ddd.TabIndex = 2;
            this.ddd.Text = "Tax 18%";
            // 
            // ff
            // 
            this.ff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ff.AutoSize = true;
            this.ff.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ff.Location = new System.Drawing.Point(898, 204);
            this.ff.Name = "ff";
            this.ff.Size = new System.Drawing.Size(39, 18);
            this.ff.TabIndex = 2;
            this.ff.Text = "Total";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(893, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Charge";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(893, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Change";
            // 
            // btn_Checkout
            // 
            this.btn_Checkout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Checkout.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Checkout.Location = new System.Drawing.Point(1038, 456);
            this.btn_Checkout.Name = "btn_Checkout";
            this.btn_Checkout.Size = new System.Drawing.Size(158, 51);
            this.btn_Checkout.TabIndex = 7;
            this.btn_Checkout.Text = "Check Out";
            this.btn_Checkout.UseVisualStyleBackColor = false;
            this.btn_Checkout.Click += new System.EventHandler(this.btn_Checkout_Click);
            // 
            // btn_CashierAdd
            // 
            this.btn_CashierAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_CashierAdd.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_CashierAdd.Location = new System.Drawing.Point(566, 177);
            this.btn_CashierAdd.Name = "btn_CashierAdd";
            this.btn_CashierAdd.Size = new System.Drawing.Size(189, 72);
            this.btn_CashierAdd.TabIndex = 8;
            this.btn_CashierAdd.Text = "Add";
            this.btn_CashierAdd.UseVisualStyleBackColor = false;
            this.btn_CashierAdd.Click += new System.EventHandler(this.btn_CashierAdd_Click);
            // 
            // dgv_Cashier
            // 
            this.dgv_Cashier.AllowUserToOrderColumns = true;
            this.dgv_Cashier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_Cashier.AutoGenerateColumns = false;
            this.dgv_Cashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cashier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.Category,
            this.productNameDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn});
            this.dgv_Cashier.DataSource = this.productBindingSource;
            this.dgv_Cashier.Location = new System.Drawing.Point(30, 137);
            this.dgv_Cashier.Name = "dgv_Cashier";
            this.dgv_Cashier.Size = new System.Drawing.Size(438, 201);
            this.dgv_Cashier.TabIndex = 9;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "productID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            // 
            // Category
            // 
            this.Category.DataPropertyName = "CategoryName";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "productDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "Product Description";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "productPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "productPrice";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(MenaxherRestauranti.BO.Product);
            // 
            // dgv_Orders
            // 
            this.dgv_Orders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_Orders.AutoGenerateColumns = false;
            this.dgv_Orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Orders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderDataGridViewTextBoxColumn,
            this.orderSubtotal,
            this.orderTotal,
            this.orderTax,
            this.orderChange,
            this.orderCharge});
            this.dgv_Orders.DataSource = this.orderDetailBindingSource;
            this.dgv_Orders.Location = new System.Drawing.Point(506, 358);
            this.dgv_Orders.Name = "dgv_Orders";
            this.dgv_Orders.Size = new System.Drawing.Size(357, 208);
            this.dgv_Orders.TabIndex = 10;
            // 
            // orderDataGridViewTextBoxColumn
            // 
            this.orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            this.orderDataGridViewTextBoxColumn.HeaderText = "Order";
            this.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            // 
            // orderSubtotal
            // 
            this.orderSubtotal.DataPropertyName = "orderSubtotal";
            this.orderSubtotal.HeaderText = "orderSubtotal";
            this.orderSubtotal.Name = "orderSubtotal";
            // 
            // orderTotal
            // 
            this.orderTotal.DataPropertyName = "orderTotal";
            this.orderTotal.HeaderText = "orderTotal";
            this.orderTotal.Name = "orderTotal";
            // 
            // orderTax
            // 
            this.orderTax.DataPropertyName = "orderTax";
            this.orderTax.HeaderText = "orderTax";
            this.orderTax.Name = "orderTax";
            // 
            // orderChange
            // 
            this.orderChange.DataPropertyName = "orderChange";
            this.orderChange.HeaderText = "orderChange";
            this.orderChange.Name = "orderChange";
            // 
            // orderCharge
            // 
            this.orderCharge.DataPropertyName = "orderCharge";
            this.orderCharge.HeaderText = "orderCharge";
            this.orderCharge.Name = "orderCharge";
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(MenaxherRestauranti.BO.OrderDetail);
            // 
            // dgv_OrderGet
            // 
            this.dgv_OrderGet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_OrderGet.AutoGenerateColumns = false;
            this.dgv_OrderGet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderGet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.quantity,
            this.orderIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn,
            this.insertByDataGridViewTextBoxColumn,
            this.insertDateDataGridViewTextBoxColumn,
            this.lastUpdatedByDataGridViewTextBoxColumn,
            this.lastUpdateDateDataGridViewTextBoxColumn,
            this.updateNoDataGridViewTextBoxColumn});
            this.dgv_OrderGet.DataSource = this.orderBindingSource;
            this.dgv_OrderGet.Location = new System.Drawing.Point(30, 358);
            this.dgv_OrderGet.Name = "dgv_OrderGet";
            this.dgv_OrderGet.Size = new System.Drawing.Size(438, 208);
            this.dgv_OrderGet.TabIndex = 10;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(MenaxherRestauranti.BO.Order);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSearch.Location = new System.Drawing.Point(474, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(158, 34);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "orderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "orderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "productID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "productID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            // 
            // insertByDataGridViewTextBoxColumn
            // 
            this.insertByDataGridViewTextBoxColumn.DataPropertyName = "InsertBy";
            this.insertByDataGridViewTextBoxColumn.HeaderText = "InsertBy";
            this.insertByDataGridViewTextBoxColumn.Name = "insertByDataGridViewTextBoxColumn";
            // 
            // insertDateDataGridViewTextBoxColumn
            // 
            this.insertDateDataGridViewTextBoxColumn.DataPropertyName = "InsertDate";
            this.insertDateDataGridViewTextBoxColumn.HeaderText = "InsertDate";
            this.insertDateDataGridViewTextBoxColumn.Name = "insertDateDataGridViewTextBoxColumn";
            // 
            // lastUpdatedByDataGridViewTextBoxColumn
            // 
            this.lastUpdatedByDataGridViewTextBoxColumn.DataPropertyName = "LastUpdatedBy";
            this.lastUpdatedByDataGridViewTextBoxColumn.HeaderText = "LastUpdatedBy";
            this.lastUpdatedByDataGridViewTextBoxColumn.Name = "lastUpdatedByDataGridViewTextBoxColumn";
            // 
            // lastUpdateDateDataGridViewTextBoxColumn
            // 
            this.lastUpdateDateDataGridViewTextBoxColumn.DataPropertyName = "LastUpdateDate";
            this.lastUpdateDateDataGridViewTextBoxColumn.HeaderText = "LastUpdateDate";
            this.lastUpdateDateDataGridViewTextBoxColumn.Name = "lastUpdateDateDataGridViewTextBoxColumn";
            // 
            // updateNoDataGridViewTextBoxColumn
            // 
            this.updateNoDataGridViewTextBoxColumn.DataPropertyName = "UpdateNo";
            this.updateNoDataGridViewTextBoxColumn.HeaderText = "UpdateNo";
            this.updateNoDataGridViewTextBoxColumn.Name = "updateNoDataGridViewTextBoxColumn";
            // 
            // frm_Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1307, 578);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgv_OrderGet);
            this.Controls.Add(this.dgv_Orders);
            this.Controls.Add(this.dgv_Cashier);
            this.Controls.Add(this.btn_CashierAdd);
            this.Controls.Add(this.btn_Checkout);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ff);
            this.Controls.Add(this.ddd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fasdf);
            this.Controls.Add(this.txt_Change);
            this.Controls.Add(this.txt_Charge);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_Tax);
            this.Controls.Add(this.txt_Subtotal);
            this.Controls.Add(this.txt_CashierQuantity);
            this.Controls.Add(this.txt_CashierID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Cashier";
            this.Text = "Cashier";
            this.Load += new System.EventHandler(this.frm_Cashier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cashier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderGet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CashierID;
        private System.Windows.Forms.TextBox txt_CashierQuantity;
        private System.Windows.Forms.TextBox txt_Subtotal;
        private System.Windows.Forms.TextBox txt_Tax;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.TextBox txt_Charge;
        private System.Windows.Forms.TextBox txt_Change;
        private System.Windows.Forms.Label fasdf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ddd;
        private System.Windows.Forms.Label ff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Checkout;
        private System.Windows.Forms.Button btn_CashierAdd;
        private System.Windows.Forms.DataGridView dgv_Cashier;
        private System.Windows.Forms.DataGridView dgv_Orders;
        private System.Windows.Forms.DataGridView dgv_OrderGet;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource orderDetailBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderSubtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insertDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateNoDataGridViewTextBoxColumn;
    }
}