namespace BookStore
{
    partial class BuyProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyProduct));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_AddOrd = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete_Product = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave_Product = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose_Product = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit_Product = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd_Product = new Guna.UI2.WinForms.Guna2Button();
            this.dtgv_BuyProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Panel_Order = new Guna.UI2.WinForms.Guna2Panel();
            this.cbx_IdCus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_DateBuy = new Guna.UI.WinForms.GunaDateTimePicker();
            this.cbx_Employee = new Guna.UI2.WinForms.Guna2ComboBox();
            this.rad_KHVL = new System.Windows.Forms.RadioButton();
            this.rad_KH = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_IdCus = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Panel_OrderDetail = new Guna.UI2.WinForms.Guna2Panel();
            this.cbx_OrderID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboBookID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Quantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_PrintBill = new Guna.UI2.WinForms.Guna2Button();
            this.btn_SaveOrderDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btn_DeleteOrderDetail = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BuyProduct)).BeginInit();
            this.Panel_Order.SuspendLayout();
            this.Panel_OrderDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btn_AddOrd);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.btnDelete_Product);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.btnSave_Product);
            this.guna2Panel1.Controls.Add(this.btnClose_Product);
            this.guna2Panel1.Controls.Add(this.btnEdit_Product);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1011, 46);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btn_AddOrd
            // 
            this.btn_AddOrd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_AddOrd.BorderRadius = 5;
            this.btn_AddOrd.BorderThickness = 1;
            this.btn_AddOrd.CheckedState.Parent = this.btn_AddOrd;
            this.btn_AddOrd.CustomImages.Parent = this.btn_AddOrd;
            this.btn_AddOrd.FillColor = System.Drawing.Color.Transparent;
            this.btn_AddOrd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_AddOrd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_AddOrd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_AddOrd.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_AddOrd.HoverState.Parent = this.btn_AddOrd;
            this.btn_AddOrd.Location = new System.Drawing.Point(521, 7);
            this.btn_AddOrd.Name = "btn_AddOrd";
            this.btn_AddOrd.ShadowDecoration.Parent = this.btn_AddOrd;
            this.btn_AddOrd.Size = new System.Drawing.Size(84, 30);
            this.btn_AddOrd.TabIndex = 54;
            this.btn_AddOrd.Text = "Thêm";
            this.btn_AddOrd.Click += new System.EventHandler(this.btn_AddOrd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phiếu Mua Hàng";
            // 
            // btnDelete_Product
            // 
            this.btnDelete_Product.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete_Product.BorderRadius = 5;
            this.btnDelete_Product.BorderThickness = 1;
            this.btnDelete_Product.CheckedState.Parent = this.btnDelete_Product;
            this.btnDelete_Product.CustomImages.Parent = this.btnDelete_Product;
            this.btnDelete_Product.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete_Product.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete_Product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete_Product.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete_Product.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelete_Product.HoverState.Parent = this.btnDelete_Product;
            this.btnDelete_Product.Location = new System.Drawing.Point(611, 7);
            this.btnDelete_Product.Name = "btnDelete_Product";
            this.btnDelete_Product.ShadowDecoration.Parent = this.btnDelete_Product;
            this.btnDelete_Product.Size = new System.Drawing.Size(84, 30);
            this.btnDelete_Product.TabIndex = 53;
            this.btnDelete_Product.Text = "Xóa";
            this.btnDelete_Product.Click += new System.EventHandler(this.btnDelete_Product_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(128, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 0;
            // 
            // btnSave_Product
            // 
            this.btnSave_Product.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave_Product.BorderRadius = 5;
            this.btnSave_Product.BorderThickness = 1;
            this.btnSave_Product.CheckedState.Parent = this.btnSave_Product;
            this.btnSave_Product.CustomImages.Parent = this.btnSave_Product;
            this.btnSave_Product.FillColor = System.Drawing.Color.Transparent;
            this.btnSave_Product.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave_Product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave_Product.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSave_Product.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave_Product.HoverState.Parent = this.btnSave_Product;
            this.btnSave_Product.Location = new System.Drawing.Point(791, 7);
            this.btnSave_Product.Name = "btnSave_Product";
            this.btnSave_Product.ShadowDecoration.Parent = this.btnSave_Product;
            this.btnSave_Product.Size = new System.Drawing.Size(84, 30);
            this.btnSave_Product.TabIndex = 5;
            this.btnSave_Product.Text = "Lưu";
            this.btnSave_Product.Click += new System.EventHandler(this.btnSave_Product_Click);
            // 
            // btnClose_Product
            // 
            this.btnClose_Product.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClose_Product.BorderRadius = 5;
            this.btnClose_Product.BorderThickness = 1;
            this.btnClose_Product.CheckedState.Parent = this.btnClose_Product;
            this.btnClose_Product.CustomImages.Parent = this.btnClose_Product;
            this.btnClose_Product.FillColor = System.Drawing.Color.Transparent;
            this.btnClose_Product.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose_Product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClose_Product.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClose_Product.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose_Product.HoverState.Parent = this.btnClose_Product;
            this.btnClose_Product.Location = new System.Drawing.Point(881, 7);
            this.btnClose_Product.Name = "btnClose_Product";
            this.btnClose_Product.ShadowDecoration.Parent = this.btnClose_Product;
            this.btnClose_Product.Size = new System.Drawing.Size(84, 30);
            this.btnClose_Product.TabIndex = 1;
            this.btnClose_Product.Text = "Thoát";
            this.btnClose_Product.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnEdit_Product
            // 
            this.btnEdit_Product.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEdit_Product.BorderRadius = 5;
            this.btnEdit_Product.BorderThickness = 1;
            this.btnEdit_Product.CheckedState.Parent = this.btnEdit_Product;
            this.btnEdit_Product.CustomImages.Parent = this.btnEdit_Product;
            this.btnEdit_Product.FillColor = System.Drawing.Color.Transparent;
            this.btnEdit_Product.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit_Product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEdit_Product.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEdit_Product.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnEdit_Product.HoverState.Parent = this.btnEdit_Product;
            this.btnEdit_Product.Location = new System.Drawing.Point(701, 7);
            this.btnEdit_Product.Name = "btnEdit_Product";
            this.btnEdit_Product.ShadowDecoration.Parent = this.btnEdit_Product;
            this.btnEdit_Product.Size = new System.Drawing.Size(84, 30);
            this.btnEdit_Product.TabIndex = 4;
            this.btnEdit_Product.Text = "Chỉnh Sửa";
            this.btnEdit_Product.Click += new System.EventHandler(this.btnEdit_Product_Click);
            // 
            // btnAdd_Product
            // 
            this.btnAdd_Product.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd_Product.BorderRadius = 5;
            this.btnAdd_Product.BorderThickness = 1;
            this.btnAdd_Product.CheckedState.Parent = this.btnAdd_Product;
            this.btnAdd_Product.CustomImages.Parent = this.btnAdd_Product;
            this.btnAdd_Product.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd_Product.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd_Product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd_Product.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd_Product.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAdd_Product.HoverState.Parent = this.btnAdd_Product;
            this.btnAdd_Product.Location = new System.Drawing.Point(18, 354);
            this.btnAdd_Product.Name = "btnAdd_Product";
            this.btnAdd_Product.ShadowDecoration.Parent = this.btnAdd_Product;
            this.btnAdd_Product.Size = new System.Drawing.Size(162, 47);
            this.btnAdd_Product.TabIndex = 2;
            this.btnAdd_Product.Text = "Thêm Chi Tiết Đơn Hàng";
            this.btnAdd_Product.Click += new System.EventHandler(this.btnAdd_Product_Click);
            // 
            // dtgv_BuyProduct
            // 
            this.dtgv_BuyProduct.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgv_BuyProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_BuyProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_BuyProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtgv_BuyProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_BuyProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_BuyProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_BuyProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_BuyProduct.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_BuyProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_BuyProduct.EnableHeadersVisualStyles = false;
            this.dtgv_BuyProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtgv_BuyProduct.Location = new System.Drawing.Point(215, 291);
            this.dtgv_BuyProduct.Name = "dtgv_BuyProduct";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_BuyProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_BuyProduct.RowHeadersVisible = false;
            this.dtgv_BuyProduct.RowHeadersWidth = 51;
            this.dtgv_BuyProduct.RowTemplate.DividerHeight = 5;
            this.dtgv_BuyProduct.RowTemplate.Height = 40;
            this.dtgv_BuyProduct.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dtgv_BuyProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_BuyProduct.Size = new System.Drawing.Size(813, 346);
            this.dtgv_BuyProduct.TabIndex = 3;
            this.dtgv_BuyProduct.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgv_BuyProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_BuyProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_BuyProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_BuyProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_BuyProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_BuyProduct.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtgv_BuyProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtgv_BuyProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.dtgv_BuyProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_BuyProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dtgv_BuyProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.dtgv_BuyProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv_BuyProduct.ThemeStyle.HeaderStyle.Height = 40;
            this.dtgv_BuyProduct.ThemeStyle.ReadOnly = false;
            this.dtgv_BuyProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_BuyProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_BuyProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgv_BuyProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgv_BuyProduct.ThemeStyle.RowsStyle.Height = 40;
            this.dtgv_BuyProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dtgv_BuyProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dtgv_BuyProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            this.dtgv_BuyProduct.SelectionChanged += new System.EventHandler(this.dtgv_BuyProduct_SelectionChanged);
            // 
            // Panel_Order
            // 
            this.Panel_Order.Controls.Add(this.cbx_IdCus);
            this.Panel_Order.Controls.Add(this.txt_DateBuy);
            this.Panel_Order.Controls.Add(this.cbx_Employee);
            this.Panel_Order.Controls.Add(this.rad_KHVL);
            this.Panel_Order.Controls.Add(this.rad_KH);
            this.Panel_Order.Controls.Add(this.label10);
            this.Panel_Order.Controls.Add(this.label11);
            this.Panel_Order.Controls.Add(this.label9);
            this.Panel_Order.Controls.Add(this.label4);
            this.Panel_Order.Controls.Add(this.txtBox_IdCus);
            this.Panel_Order.Controls.Add(this.label5);
            this.Panel_Order.Controls.Add(this.label6);
            this.Panel_Order.CustomBorderColor = System.Drawing.Color.Silver;
            this.Panel_Order.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.Panel_Order.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.Panel_Order.Location = new System.Drawing.Point(0, 53);
            this.Panel_Order.Name = "Panel_Order";
            this.Panel_Order.ShadowDecoration.Parent = this.Panel_Order;
            this.Panel_Order.Size = new System.Drawing.Size(1011, 124);
            this.Panel_Order.TabIndex = 7;
            // 
            // cbx_IdCus
            // 
            this.cbx_IdCus.BackColor = System.Drawing.Color.Transparent;
            this.cbx_IdCus.BorderRadius = 18;
            this.cbx_IdCus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_IdCus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_IdCus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_IdCus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_IdCus.FocusedState.Parent = this.cbx_IdCus;
            this.cbx_IdCus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_IdCus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbx_IdCus.HoverState.Parent = this.cbx_IdCus;
            this.cbx_IdCus.ItemHeight = 30;
            this.cbx_IdCus.ItemsAppearance.Parent = this.cbx_IdCus;
            this.cbx_IdCus.Location = new System.Drawing.Point(112, 66);
            this.cbx_IdCus.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_IdCus.Name = "cbx_IdCus";
            this.cbx_IdCus.ShadowDecoration.Parent = this.cbx_IdCus;
            this.cbx_IdCus.Size = new System.Drawing.Size(143, 36);
            this.cbx_IdCus.TabIndex = 73;
            this.cbx_IdCus.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // txt_DateBuy
            // 
            this.txt_DateBuy.BaseColor = System.Drawing.Color.White;
            this.txt_DateBuy.BorderColor = System.Drawing.Color.Silver;
            this.txt_DateBuy.BorderSize = 1;
            this.txt_DateBuy.CustomFormat = null;
            this.txt_DateBuy.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_DateBuy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_DateBuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DateBuy.ForeColor = System.Drawing.Color.Black;
            this.txt_DateBuy.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_DateBuy.Location = new System.Drawing.Point(565, 26);
            this.txt_DateBuy.Margin = new System.Windows.Forms.Padding(2);
            this.txt_DateBuy.MaxDate = new System.DateTime(2022, 12, 25, 23, 59, 59, 0);
            this.txt_DateBuy.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txt_DateBuy.Name = "txt_DateBuy";
            this.txt_DateBuy.OnHoverBaseColor = System.Drawing.Color.White;
            this.txt_DateBuy.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_DateBuy.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_DateBuy.OnPressedColor = System.Drawing.Color.Black;
            this.txt_DateBuy.Size = new System.Drawing.Size(142, 24);
            this.txt_DateBuy.TabIndex = 72;
            this.txt_DateBuy.Text = "12/24/2022";
            this.txt_DateBuy.Value = new System.DateTime(2022, 12, 24, 15, 58, 4, 975);
            // 
            // cbx_Employee
            // 
            this.cbx_Employee.BackColor = System.Drawing.Color.Transparent;
            this.cbx_Employee.BorderRadius = 18;
            this.cbx_Employee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Employee.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_Employee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_Employee.FocusedState.Parent = this.cbx_Employee;
            this.cbx_Employee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_Employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbx_Employee.HoverState.Parent = this.cbx_Employee;
            this.cbx_Employee.ItemHeight = 30;
            this.cbx_Employee.ItemsAppearance.Parent = this.cbx_Employee;
            this.cbx_Employee.Location = new System.Drawing.Point(321, 22);
            this.cbx_Employee.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_Employee.Name = "cbx_Employee";
            this.cbx_Employee.ShadowDecoration.Parent = this.cbx_Employee;
            this.cbx_Employee.Size = new System.Drawing.Size(143, 36);
            this.cbx_Employee.TabIndex = 52;
            this.cbx_Employee.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // rad_KHVL
            // 
            this.rad_KHVL.AutoSize = true;
            this.rad_KHVL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_KHVL.ForeColor = System.Drawing.Color.Black;
            this.rad_KHVL.Location = new System.Drawing.Point(433, 84);
            this.rad_KHVL.Margin = new System.Windows.Forms.Padding(2);
            this.rad_KHVL.Name = "rad_KHVL";
            this.rad_KHVL.Size = new System.Drawing.Size(108, 18);
            this.rad_KHVL.TabIndex = 51;
            this.rad_KHVL.Text = "Khách Vãng Lai";
            this.rad_KHVL.UseVisualStyleBackColor = true;
            // 
            // rad_KH
            // 
            this.rad_KH.AutoSize = true;
            this.rad_KH.Checked = true;
            this.rad_KH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_KH.ForeColor = System.Drawing.Color.Black;
            this.rad_KH.Location = new System.Drawing.Point(312, 84);
            this.rad_KH.Margin = new System.Windows.Forms.Padding(2);
            this.rad_KH.Name = "rad_KH";
            this.rad_KH.Size = new System.Drawing.Size(90, 18);
            this.rad_KH.TabIndex = 50;
            this.rad_KH.TabStop = true;
            this.rad_KH.Text = "Khách Hàng";
            this.rad_KH.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(15, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 14);
            this.label10.TabIndex = 49;
            this.label10.Text = "ID Khách Hàng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(212, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 14);
            this.label11.TabIndex = 44;
            this.label11.Text = "ID Nhân Viên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(496, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 14);
            this.label9.TabIndex = 43;
            this.label9.Text = "Ngày Mua:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 42;
            this.label4.Text = "Order ID:";
            // 
            // txtBox_IdCus
            // 
            this.txtBox_IdCus.AutoRoundedCorners = true;
            this.txtBox_IdCus.BorderRadius = 15;
            this.txtBox_IdCus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBox_IdCus.DefaultText = "";
            this.txtBox_IdCus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBox_IdCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBox_IdCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_IdCus.DisabledState.Parent = this.txtBox_IdCus;
            this.txtBox_IdCus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBox_IdCus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_IdCus.FocusedState.Parent = this.txtBox_IdCus;
            this.txtBox_IdCus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBox_IdCus.HoverState.Parent = this.txtBox_IdCus;
            this.txtBox_IdCus.Location = new System.Drawing.Point(80, 26);
            this.txtBox_IdCus.Name = "txtBox_IdCus";
            this.txtBox_IdCus.PasswordChar = '\0';
            this.txtBox_IdCus.PlaceholderText = "Id..";
            this.txtBox_IdCus.SelectedText = "";
            this.txtBox_IdCus.ShadowDecoration.Parent = this.txtBox_IdCus;
            this.txtBox_IdCus.Size = new System.Drawing.Size(124, 32);
            this.txtBox_IdCus.TabIndex = 41;
            this.txtBox_IdCus.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Thông Tin Đơn Hàng";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(128, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 36);
            this.label6.TabIndex = 0;
            // 
            // Panel_OrderDetail
            // 
            this.Panel_OrderDetail.Controls.Add(this.cbx_OrderID);
            this.Panel_OrderDetail.Controls.Add(this.cboBookID);
            this.Panel_OrderDetail.Controls.Add(this.label12);
            this.Panel_OrderDetail.Controls.Add(this.label15);
            this.Panel_OrderDetail.Controls.Add(this.label16);
            this.Panel_OrderDetail.Controls.Add(this.label17);
            this.Panel_OrderDetail.Controls.Add(this.label18);
            this.Panel_OrderDetail.Controls.Add(this.label19);
            this.Panel_OrderDetail.Controls.Add(this.txt_Price);
            this.Panel_OrderDetail.Controls.Add(this.txt_Quantity);
            this.Panel_OrderDetail.Controls.Add(this.label20);
            this.Panel_OrderDetail.Controls.Add(this.label21);
            this.Panel_OrderDetail.CustomBorderColor = System.Drawing.Color.Silver;
            this.Panel_OrderDetail.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.Panel_OrderDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.Panel_OrderDetail.Location = new System.Drawing.Point(0, 184);
            this.Panel_OrderDetail.Name = "Panel_OrderDetail";
            this.Panel_OrderDetail.ShadowDecoration.Parent = this.Panel_OrderDetail;
            this.Panel_OrderDetail.Size = new System.Drawing.Size(1011, 101);
            this.Panel_OrderDetail.TabIndex = 52;
            // 
            // cbx_OrderID
            // 
            this.cbx_OrderID.BackColor = System.Drawing.Color.Transparent;
            this.cbx_OrderID.BorderRadius = 18;
            this.cbx_OrderID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_OrderID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_OrderID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_OrderID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_OrderID.FocusedState.Parent = this.cbx_OrderID;
            this.cbx_OrderID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_OrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbx_OrderID.HoverState.Parent = this.cbx_OrderID;
            this.cbx_OrderID.ItemHeight = 30;
            this.cbx_OrderID.ItemsAppearance.Parent = this.cbx_OrderID;
            this.cbx_OrderID.Location = new System.Drawing.Point(293, 21);
            this.cbx_OrderID.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_OrderID.Name = "cbx_OrderID";
            this.cbx_OrderID.ShadowDecoration.Parent = this.cbx_OrderID;
            this.cbx_OrderID.Size = new System.Drawing.Size(143, 36);
            this.cbx_OrderID.TabIndex = 53;
            this.cbx_OrderID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cbx_OrderID.SelectedIndexChanged += new System.EventHandler(this.cbx_OrderID_SelectedIndexChanged);
            // 
            // cboBookID
            // 
            this.cboBookID.BackColor = System.Drawing.Color.Transparent;
            this.cboBookID.BorderRadius = 18;
            this.cboBookID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBookID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBookID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboBookID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboBookID.FocusedState.Parent = this.cboBookID;
            this.cboBookID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboBookID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboBookID.HoverState.Parent = this.cboBookID;
            this.cboBookID.ItemHeight = 30;
            this.cboBookID.ItemsAppearance.Parent = this.cboBookID;
            this.cboBookID.Location = new System.Drawing.Point(66, 18);
            this.cboBookID.Margin = new System.Windows.Forms.Padding(2);
            this.cboBookID.Name = "cboBookID";
            this.cboBookID.ShadowDecoration.Parent = this.cboBookID;
            this.cboBookID.Size = new System.Drawing.Size(143, 36);
            this.cboBookID.TabIndex = 51;
            this.cboBookID.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(615, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 36);
            this.label12.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(9, 28);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 14);
            this.label15.TabIndex = 49;
            this.label15.Text = "ID Sách:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(173, 12);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 36);
            this.label16.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(683, 27);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 14);
            this.label17.TabIndex = 44;
            this.label17.Text = "Số Lượng:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(462, 28);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 14);
            this.label18.TabIndex = 43;
            this.label18.Text = "Giá Bán:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(224, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 14);
            this.label19.TabIndex = 42;
            this.label19.Text = "Order ID:";
            // 
            // txt_Price
            // 
            this.txt_Price.AutoRoundedCorners = true;
            this.txt_Price.BorderRadius = 15;
            this.txt_Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Price.DefaultText = "";
            this.txt_Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.DisabledState.Parent = this.txt_Price;
            this.txt_Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.FocusedState.Parent = this.txt_Price;
            this.txt_Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Price.HoverState.Parent = this.txt_Price;
            this.txt_Price.Location = new System.Drawing.Point(517, 18);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.PasswordChar = '\0';
            this.txt_Price.PlaceholderText = "Giá Bán..";
            this.txt_Price.SelectedText = "";
            this.txt_Price.ShadowDecoration.Parent = this.txt_Price;
            this.txt_Price.Size = new System.Drawing.Size(142, 32);
            this.txt_Price.TabIndex = 39;
            this.txt_Price.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.AutoRoundedCorners = true;
            this.txt_Quantity.BorderRadius = 15;
            this.txt_Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Quantity.DefaultText = "";
            this.txt_Quantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Quantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Quantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Quantity.DisabledState.Parent = this.txt_Quantity;
            this.txt_Quantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Quantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Quantity.FocusedState.Parent = this.txt_Quantity;
            this.txt_Quantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Quantity.HoverState.Parent = this.txt_Quantity;
            this.txt_Quantity.Location = new System.Drawing.Point(756, 21);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.PasswordChar = '\0';
            this.txt_Quantity.PlaceholderText = "Số Lượng..";
            this.txt_Quantity.SelectedText = "";
            this.txt_Quantity.ShadowDecoration.Parent = this.txt_Quantity;
            this.txt_Quantity.Size = new System.Drawing.Size(142, 32);
            this.txt_Quantity.TabIndex = 40;
            this.txt_Quantity.TextOffset = new System.Drawing.Point(8, 0);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label20.Location = new System.Drawing.Point(2, -3);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(178, 18);
            this.label20.TabIndex = 1;
            this.label20.Text = "Thông Tin Chi Tiết Đơn Hàng";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label21.Location = new System.Drawing.Point(344, 1);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 36);
            this.label21.TabIndex = 0;
            // 
            // btn_PrintBill
            // 
            this.btn_PrintBill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_PrintBill.BorderRadius = 5;
            this.btn_PrintBill.BorderThickness = 1;
            this.btn_PrintBill.CheckedState.Parent = this.btn_PrintBill;
            this.btn_PrintBill.CustomImages.Parent = this.btn_PrintBill;
            this.btn_PrintBill.FillColor = System.Drawing.Color.Transparent;
            this.btn_PrintBill.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.btn_PrintBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_PrintBill.HoverState.Parent = this.btn_PrintBill;
            this.btn_PrintBill.Image = ((System.Drawing.Image)(resources.GetObject("btn_PrintBill.Image")));
            this.btn_PrintBill.ImageSize = new System.Drawing.Size(14, 14);
            this.btn_PrintBill.Location = new System.Drawing.Point(18, 515);
            this.btn_PrintBill.Name = "btn_PrintBill";
            this.btn_PrintBill.ShadowDecoration.Parent = this.btn_PrintBill;
            this.btn_PrintBill.Size = new System.Drawing.Size(162, 43);
            this.btn_PrintBill.TabIndex = 54;
            this.btn_PrintBill.Text = "     In Hóa Đơn";
            this.btn_PrintBill.Click += new System.EventHandler(this.btn_PrintBill_Click);
            // 
            // btn_SaveOrderDetail
            // 
            this.btn_SaveOrderDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveOrderDetail.BorderRadius = 5;
            this.btn_SaveOrderDetail.BorderThickness = 1;
            this.btn_SaveOrderDetail.CheckedState.Parent = this.btn_SaveOrderDetail;
            this.btn_SaveOrderDetail.CustomImages.Parent = this.btn_SaveOrderDetail;
            this.btn_SaveOrderDetail.FillColor = System.Drawing.Color.Transparent;
            this.btn_SaveOrderDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_SaveOrderDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveOrderDetail.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_SaveOrderDetail.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_SaveOrderDetail.HoverState.Parent = this.btn_SaveOrderDetail;
            this.btn_SaveOrderDetail.Location = new System.Drawing.Point(18, 409);
            this.btn_SaveOrderDetail.Name = "btn_SaveOrderDetail";
            this.btn_SaveOrderDetail.ShadowDecoration.Parent = this.btn_SaveOrderDetail;
            this.btn_SaveOrderDetail.Size = new System.Drawing.Size(162, 47);
            this.btn_SaveOrderDetail.TabIndex = 55;
            this.btn_SaveOrderDetail.Text = "Lưu Chi Tiết Đơn Hàng";
            this.btn_SaveOrderDetail.Click += new System.EventHandler(this.btn_SaveOrderDetail_Click);
            // 
            // btn_DeleteOrderDetail
            // 
            this.btn_DeleteOrderDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_DeleteOrderDetail.BorderRadius = 5;
            this.btn_DeleteOrderDetail.BorderThickness = 1;
            this.btn_DeleteOrderDetail.CheckedState.Parent = this.btn_DeleteOrderDetail;
            this.btn_DeleteOrderDetail.CustomImages.Parent = this.btn_DeleteOrderDetail;
            this.btn_DeleteOrderDetail.FillColor = System.Drawing.Color.Transparent;
            this.btn_DeleteOrderDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_DeleteOrderDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_DeleteOrderDetail.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_DeleteOrderDetail.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteOrderDetail.HoverState.Parent = this.btn_DeleteOrderDetail;
            this.btn_DeleteOrderDetail.Location = new System.Drawing.Point(18, 462);
            this.btn_DeleteOrderDetail.Name = "btn_DeleteOrderDetail";
            this.btn_DeleteOrderDetail.ShadowDecoration.Parent = this.btn_DeleteOrderDetail;
            this.btn_DeleteOrderDetail.Size = new System.Drawing.Size(162, 47);
            this.btn_DeleteOrderDetail.TabIndex = 56;
            this.btn_DeleteOrderDetail.Text = "Xóa Chi Tiết Đơn Hàng";
            this.btn_DeleteOrderDetail.Click += new System.EventHandler(this.btn_DeleteOrderDetail_Click);
            // 
            // BuyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1011, 639);
            this.Controls.Add(this.btn_DeleteOrderDetail);
            this.Controls.Add(this.btn_SaveOrderDetail);
            this.Controls.Add(this.btn_PrintBill);
            this.Controls.Add(this.Panel_OrderDetail);
            this.Controls.Add(this.Panel_Order);
            this.Controls.Add(this.dtgv_BuyProduct);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnAdd_Product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuyProduct";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.BuyProduct_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_BuyProduct)).EndInit();
            this.Panel_Order.ResumeLayout(false);
            this.Panel_Order.PerformLayout();
            this.Panel_OrderDetail.ResumeLayout(false);
            this.Panel_OrderDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnClose_Product;
        private Guna.UI2.WinForms.Guna2Button btnAdd_Product;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_BuyProduct;
        private Guna.UI2.WinForms.Guna2Button btnSave_Product;
        private Guna.UI2.WinForms.Guna2Button btnEdit_Product;
        private Guna.UI2.WinForms.Guna2Panel Panel_Order;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtBox_IdCus;
        private Guna.UI2.WinForms.Guna2Panel Panel_OrderDetail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2TextBox txt_Quantity;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private Guna.UI2.WinForms.Guna2Button btnDelete_Product;
        private System.Windows.Forms.RadioButton rad_KHVL;
        private System.Windows.Forms.RadioButton rad_KH;
        private Guna.UI2.WinForms.Guna2ComboBox cboBookID;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_Employee;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_OrderID;
        private Guna.UI2.WinForms.Guna2Button btn_PrintBill;
        private Guna.UI2.WinForms.Guna2Button btn_AddOrd;
        private Guna.UI.WinForms.GunaDateTimePicker txt_DateBuy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2TextBox txt_Price;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_IdCus;
        private Guna.UI2.WinForms.Guna2Button btn_SaveOrderDetail;
        private Guna.UI2.WinForms.Guna2Button btn_DeleteOrderDetail;
    }
}