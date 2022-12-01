namespace BookStore
{
    partial class Customer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd_Customer = new Guna.UI2.WinForms.Guna2Button();
            this.cbBox_SearchCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate_Customer = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete_Customer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnFilter_Customer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Button3);
            this.guna2Panel1.Controls.Add(this.btnFilter_Customer);
            this.guna2Panel1.Controls.Add(this.btnAdd_Customer);
            this.guna2Panel1.Controls.Add(this.cbBox_SearchCustomer);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1348, 75);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnAdd_Customer
            // 
            this.btnAdd_Customer.BorderColor = System.Drawing.Color.Gray;
            this.btnAdd_Customer.BorderThickness = 1;
            this.btnAdd_Customer.CheckedState.Parent = this.btnAdd_Customer;
            this.btnAdd_Customer.CustomImages.Parent = this.btnAdd_Customer;
            this.btnAdd_Customer.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd_Customer.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd_Customer.HoverState.Parent = this.btnAdd_Customer;
            this.btnAdd_Customer.Location = new System.Drawing.Point(1155, 21);
            this.btnAdd_Customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd_Customer.Name = "btnAdd_Customer";
            this.btnAdd_Customer.ShadowDecoration.Parent = this.btnAdd_Customer;
            this.btnAdd_Customer.Size = new System.Drawing.Size(132, 34);
            this.btnAdd_Customer.TabIndex = 4;
            this.btnAdd_Customer.Text = "Add Customer";
            this.btnAdd_Customer.Click += new System.EventHandler(this.btnAdd_Customer_Click);
            // 
            // cbBox_SearchCustomer
            // 
            this.cbBox_SearchCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.cbBox_SearchCustomer.DisplayMember = "fgdg";
            this.cbBox_SearchCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBox_SearchCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBox_SearchCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.cbBox_SearchCustomer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBox_SearchCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBox_SearchCustomer.FocusedState.Parent = this.cbBox_SearchCustomer;
            this.cbBox_SearchCustomer.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cbBox_SearchCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbBox_SearchCustomer.HoverState.Parent = this.cbBox_SearchCustomer;
            this.cbBox_SearchCustomer.ItemHeight = 30;
            this.cbBox_SearchCustomer.Items.AddRange(new object[] {
            "Last appointment"});
            this.cbBox_SearchCustomer.ItemsAppearance.Parent = this.cbBox_SearchCustomer;
            this.cbBox_SearchCustomer.Location = new System.Drawing.Point(527, 15);
            this.cbBox_SearchCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBox_SearchCustomer.Name = "cbBox_SearchCustomer";
            this.cbBox_SearchCustomer.ShadowDecoration.Parent = this.cbBox_SearchCustomer;
            this.cbBox_SearchCustomer.Size = new System.Drawing.Size(208, 36);
            this.cbBox_SearchCustomer.StartIndex = 0;
            this.cbBox_SearchCustomer.TabIndex = 3;
            this.cbBox_SearchCustomer.TextOffset = new System.Drawing.Point(2, 0);
            this.cbBox_SearchCustomer.SelectedIndexChanged += new System.EventHandler(this.cbBox_SearchCustomer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng khách hàng hiện có:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10F);
            this.label3.Location = new System.Drawing.Point(433, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tìm kiếm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(245, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "...";
            // 
            // btnUpdate_Customer
            // 
            this.btnUpdate_Customer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate_Customer.BorderRadius = 5;
            this.btnUpdate_Customer.BorderThickness = 1;
            this.btnUpdate_Customer.CheckedState.Parent = this.btnUpdate_Customer;
            this.btnUpdate_Customer.CustomImages.Parent = this.btnUpdate_Customer;
            this.btnUpdate_Customer.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate_Customer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate_Customer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdate_Customer.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnUpdate_Customer.HoverState.Parent = this.btnUpdate_Customer;
            this.btnUpdate_Customer.Location = new System.Drawing.Point(1175, 796);
            this.btnUpdate_Customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate_Customer.Name = "btnUpdate_Customer";
            this.btnUpdate_Customer.ShadowDecoration.Parent = this.btnUpdate_Customer;
            this.btnUpdate_Customer.Size = new System.Drawing.Size(112, 37);
            this.btnUpdate_Customer.TabIndex = 1;
            this.btnUpdate_Customer.Text = "Edit";
            this.btnUpdate_Customer.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnDelete_Customer
            // 
            this.btnDelete_Customer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete_Customer.BorderRadius = 5;
            this.btnDelete_Customer.BorderThickness = 1;
            this.btnDelete_Customer.CheckedState.Parent = this.btnDelete_Customer;
            this.btnDelete_Customer.CustomImages.Parent = this.btnDelete_Customer;
            this.btnDelete_Customer.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete_Customer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete_Customer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete_Customer.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDelete_Customer.HoverState.Parent = this.btnDelete_Customer;
            this.btnDelete_Customer.Location = new System.Drawing.Point(1055, 796);
            this.btnDelete_Customer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete_Customer.Name = "btnDelete_Customer";
            this.btnDelete_Customer.ShadowDecoration.Parent = this.btnDelete_Customer;
            this.btnDelete_Customer.Size = new System.Drawing.Size(112, 37);
            this.btnDelete_Customer.TabIndex = 2;
            this.btnDelete_Customer.Text = "Delete";
            this.btnDelete_Customer.Click += new System.EventHandler(this.btnDelete_Customer_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.guna2DataGridView1.ColumnHeadersHeight = 40;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column4});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(16, 82);
            this.guna2DataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.DividerHeight = 5;
            this.guna2DataGridView1.RowTemplate.Height = 40;
            this.guna2DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1316, 706);
            this.guna2DataGridView1.TabIndex = 3;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 40.60914F;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 10;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.FillWeight = 162.4365F;
            this.Column2.HeaderText = "";
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 40;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 99.49239F;
            this.Column8.HeaderText = "ID Khách Hàng";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 99.49239F;
            this.Column3.HeaderText = "Họ và Tên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 99.49239F;
            this.Column5.HeaderText = "Địa Chỉ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.FillWeight = 99.49239F;
            this.Column6.HeaderText = "Điện Thoại";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.FillWeight = 99.49239F;
            this.Column7.HeaderText = "Nhiệm Vụ";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 99.49239F;
            this.Column4.HeaderText = "Thứ Hạng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button3.BorderThickness = 1;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageSize = new System.Drawing.Size(14, 14);
            this.guna2Button3.Location = new System.Drawing.Point(959, 21);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(48, 34);
            this.guna2Button3.TabIndex = 6;
            // 
            // btnFilter_Customer
            // 
            this.btnFilter_Customer.BorderColor = System.Drawing.Color.Gray;
            this.btnFilter_Customer.BorderThickness = 1;
            this.btnFilter_Customer.CheckedState.Parent = this.btnFilter_Customer;
            this.btnFilter_Customer.CustomImages.Parent = this.btnFilter_Customer;
            this.btnFilter_Customer.FillColor = System.Drawing.Color.Transparent;
            this.btnFilter_Customer.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Bold);
            this.btnFilter_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFilter_Customer.HoverState.Parent = this.btnFilter_Customer;
            this.btnFilter_Customer.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter_Customer.Image")));
            this.btnFilter_Customer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFilter_Customer.ImageOffset = new System.Drawing.Point(3, 0);
            this.btnFilter_Customer.ImageSize = new System.Drawing.Size(12, 12);
            this.btnFilter_Customer.Location = new System.Drawing.Point(1015, 21);
            this.btnFilter_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter_Customer.Name = "btnFilter_Customer";
            this.btnFilter_Customer.ShadowDecoration.Parent = this.btnFilter_Customer;
            this.btnFilter_Customer.Size = new System.Drawing.Size(132, 34);
            this.btnFilter_Customer.TabIndex = 5;
            this.btnFilter_Customer.Text = "Filter";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1348, 863);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.btnDelete_Customer);
            this.Controls.Add(this.btnUpdate_Customer);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Customer";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnFilter_Customer;
        private Guna.UI2.WinForms.Guna2Button btnAdd_Customer;
        private Guna.UI2.WinForms.Guna2ComboBox cbBox_SearchCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnUpdate_Customer;
        private Guna.UI2.WinForms.Guna2Button btnDelete_Customer;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}