namespace Pharmacy_Management_System.PharmacistUC
{
    partial class UC_P_SellMedicin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxMedicin = new System.Windows.Forms.ListBox();
            this.txtEdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMedname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmedid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnpurches = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnaddTocart = new Guna.UI2.WinForms.Guna2Button();
            this.btnSync = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sell Medicine";
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(43, 146);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Here";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(279, 41);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search";
            // 
            // listBoxMedicin
            // 
            this.listBoxMedicin.FormattingEnabled = true;
            this.listBoxMedicin.ItemHeight = 16;
            this.listBoxMedicin.Location = new System.Drawing.Point(43, 220);
            this.listBoxMedicin.Name = "listBoxMedicin";
            this.listBoxMedicin.Size = new System.Drawing.Size(279, 596);
            this.listBoxMedicin.TabIndex = 12;
            this.listBoxMedicin.SelectedIndexChanged += new System.EventHandler(this.listBoxMedicin_SelectedIndexChanged);
            // 
            // txtEdate
            // 
            this.txtEdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))));
            this.txtEdate.BorderThickness = 2;
            this.txtEdate.CheckedState.Parent = this.txtEdate;
            this.txtEdate.FillColor = System.Drawing.Color.White;
            this.txtEdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtEdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.txtEdate.HoverState.Parent = this.txtEdate;
            this.txtEdate.Location = new System.Drawing.Point(434, 354);
            this.txtEdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtEdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtEdate.Name = "txtEdate";
            this.txtEdate.ShadowDecoration.Parent = this.txtEdate;
            this.txtEdate.Size = new System.Drawing.Size(340, 37);
            this.txtEdate.TabIndex = 32;
            this.txtEdate.Value = new System.DateTime(2023, 3, 25, 6, 11, 1, 554);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(429, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 31;
            this.label8.Text = "Expire Date";
            // 
            // txtprice
            // 
            this.txtprice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))));
            this.txtprice.BorderThickness = 2;
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.DefaultText = "";
            this.txtprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.DisabledState.Parent = this.txtprice;
            this.txtprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.txtprice.FocusedState.Parent = this.txtprice;
            this.txtprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.ForeColor = System.Drawing.Color.Black;
            this.txtprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.txtprice.HoverState.Parent = this.txtprice;
            this.txtprice.Location = new System.Drawing.Point(1027, 146);
            this.txtprice.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.PlaceholderText = "";
            this.txtprice.ReadOnly = true;
            this.txtprice.SelectedText = "";
            this.txtprice.ShadowDecoration.Parent = this.txtprice;
            this.txtprice.Size = new System.Drawing.Size(340, 36);
            this.txtprice.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1022, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Price Per Unit";
            // 
            // txtNoUnit
            // 
            this.txtNoUnit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))));
            this.txtNoUnit.BorderThickness = 2;
            this.txtNoUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNoUnit.DefaultText = "";
            this.txtNoUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNoUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNoUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoUnit.DisabledState.Parent = this.txtNoUnit;
            this.txtNoUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNoUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.txtNoUnit.FocusedState.Parent = this.txtNoUnit;
            this.txtNoUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoUnit.ForeColor = System.Drawing.Color.Black;
            this.txtNoUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.txtNoUnit.HoverState.Parent = this.txtNoUnit;
            this.txtNoUnit.Location = new System.Drawing.Point(1027, 251);
            this.txtNoUnit.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtNoUnit.Name = "txtNoUnit";
            this.txtNoUnit.PasswordChar = '\0';
            this.txtNoUnit.PlaceholderText = "";
            this.txtNoUnit.SelectedText = "";
            this.txtNoUnit.ShadowDecoration.Parent = this.txtNoUnit;
            this.txtNoUnit.Size = new System.Drawing.Size(340, 36);
            this.txtNoUnit.TabIndex = 28;
            this.txtNoUnit.TextChanged += new System.EventHandler(this.txtNoUnit_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1022, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "No of Units";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))));
            this.txtTotalPrice.BorderThickness = 2;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.DefaultText = "";
            this.txtTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.DisabledState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.txtTotalPrice.FocusedState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txtTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.txtTotalPrice.HoverState.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Location = new System.Drawing.Point(1027, 354);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.PlaceholderText = "";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.ShadowDecoration.Parent = this.txtTotalPrice;
            this.txtTotalPrice.Size = new System.Drawing.Size(340, 37);
            this.txtTotalPrice.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1022, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Total Price";
            // 
            // txtMedname
            // 
            this.txtMedname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))));
            this.txtMedname.BorderThickness = 2;
            this.txtMedname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedname.DefaultText = "";
            this.txtMedname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMedname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMedname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedname.DisabledState.Parent = this.txtMedname;
            this.txtMedname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMedname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.txtMedname.FocusedState.Parent = this.txtMedname;
            this.txtMedname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedname.ForeColor = System.Drawing.Color.Black;
            this.txtMedname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.txtMedname.HoverState.Parent = this.txtMedname;
            this.txtMedname.Location = new System.Drawing.Point(434, 251);
            this.txtMedname.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtMedname.Name = "txtMedname";
            this.txtMedname.PasswordChar = '\0';
            this.txtMedname.PlaceholderText = "";
            this.txtMedname.ReadOnly = true;
            this.txtMedname.SelectedText = "";
            this.txtMedname.ShadowDecoration.Parent = this.txtMedname;
            this.txtMedname.Size = new System.Drawing.Size(340, 36);
            this.txtMedname.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Medicine Name";
            // 
            // txtmedid
            // 
            this.txtmedid.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(60)))), ((int)(((byte)(140)))));
            this.txtmedid.BorderThickness = 2;
            this.txtmedid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmedid.DefaultText = "";
            this.txtmedid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmedid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmedid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmedid.DisabledState.Parent = this.txtmedid;
            this.txtmedid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmedid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.txtmedid.FocusedState.Parent = this.txtmedid;
            this.txtmedid.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedid.ForeColor = System.Drawing.Color.Black;
            this.txtmedid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.txtmedid.HoverState.Parent = this.txtmedid;
            this.txtmedid.Location = new System.Drawing.Point(434, 146);
            this.txtmedid.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtmedid.Name = "txtmedid";
            this.txtmedid.PasswordChar = '\0';
            this.txtmedid.PlaceholderText = "";
            this.txtmedid.ReadOnly = true;
            this.txtmedid.SelectedText = "";
            this.txtmedid.ShadowDecoration.Parent = this.txtmedid;
            this.txtmedid.Size = new System.Drawing.Size(340, 36);
            this.txtmedid.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Medicine ID";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 27;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(434, 529);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(933, 212);
            this.guna2DataGridView1.TabIndex = 34;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 27;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medicine ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Medicine Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Expiry Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Price Pr Unit";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "No of Units";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Price";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // btnpurches
            // 
            this.btnpurches.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnpurches.BorderRadius = 19;
            this.btnpurches.BorderThickness = 1;
            this.btnpurches.CheckedState.Parent = this.btnpurches;
            this.btnpurches.CustomImages.Parent = this.btnpurches;
            this.btnpurches.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnpurches.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnpurches.ForeColor = System.Drawing.Color.White;
            this.btnpurches.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnpurches.HoverState.FillColor = System.Drawing.Color.White;
            this.btnpurches.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnpurches.HoverState.Parent = this.btnpurches;
            this.btnpurches.Image = global::Pharmacy_Management_System.Properties.Resources.purchase_40px;
            this.btnpurches.ImageSize = new System.Drawing.Size(30, 30);
            this.btnpurches.Location = new System.Drawing.Point(1128, 768);
            this.btnpurches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnpurches.Name = "btnpurches";
            this.btnpurches.ShadowDecoration.Parent = this.btnpurches;
            this.btnpurches.Size = new System.Drawing.Size(239, 48);
            this.btnpurches.TabIndex = 36;
            this.btnpurches.Text = "Purchase & Print";
            this.btnpurches.Click += new System.EventHandler(this.btnpurches_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnRemove.BorderRadius = 19;
            this.btnRemove.BorderThickness = 1;
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnRemove.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Image = global::Pharmacy_Management_System.Properties.Resources.remove_25px1;
            this.btnRemove.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRemove.Location = new System.Drawing.Point(434, 768);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(186, 48);
            this.btnRemove.TabIndex = 35;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnaddTocart
            // 
            this.btnaddTocart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnaddTocart.BorderRadius = 19;
            this.btnaddTocart.BorderThickness = 1;
            this.btnaddTocart.CheckedState.Parent = this.btnaddTocart;
            this.btnaddTocart.CustomImages.Parent = this.btnaddTocart;
            this.btnaddTocart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnaddTocart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnaddTocart.ForeColor = System.Drawing.Color.White;
            this.btnaddTocart.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnaddTocart.HoverState.FillColor = System.Drawing.Color.White;
            this.btnaddTocart.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnaddTocart.HoverState.Parent = this.btnaddTocart;
            this.btnaddTocart.Image = global::Pharmacy_Management_System.Properties.Resources.add_to_cart_40px;
            this.btnaddTocart.ImageSize = new System.Drawing.Size(30, 30);
            this.btnaddTocart.Location = new System.Drawing.Point(1179, 440);
            this.btnaddTocart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaddTocart.Name = "btnaddTocart";
            this.btnaddTocart.ShadowDecoration.Parent = this.btnaddTocart;
            this.btnaddTocart.Size = new System.Drawing.Size(188, 48);
            this.btnaddTocart.TabIndex = 33;
            this.btnaddTocart.Text = "Add to Cart";
            this.btnaddTocart.Click += new System.EventHandler(this.btnaddTocart_Click);
            // 
            // btnSync
            // 
            this.btnSync.AnimationHoverSpeed = 0.07F;
            this.btnSync.AnimationSpeed = 0.03F;
            this.btnSync.BaseColor = System.Drawing.Color.Transparent;
            this.btnSync.BorderColor = System.Drawing.Color.Black;
            this.btnSync.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSync.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSync.CheckedForeColor = System.Drawing.Color.White;
            this.btnSync.CheckedImage = null;
            this.btnSync.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSync.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSync.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSync.FocusedColor = System.Drawing.Color.Empty;
            this.btnSync.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSync.ForeColor = System.Drawing.Color.White;
            this.btnSync.Image = global::Pharmacy_Management_System.Properties.Resources.sync_green;
            this.btnSync.ImageOffsetX = -10;
            this.btnSync.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSync.LineColor = System.Drawing.Color.Transparent;
            this.btnSync.Location = new System.Drawing.Point(368, 36);
            this.btnSync.Margin = new System.Windows.Forms.Padding(4);
            this.btnSync.Name = "btnSync";
            this.btnSync.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnSync.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSync.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSync.OnHoverImage = null;
            this.btnSync.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnSync.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnSync.Size = new System.Drawing.Size(49, 39);
            this.btnSync.TabIndex = 9;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Pharmacy_Management_System.Properties.Resources.sync;
            this.pictureBox1.Location = new System.Drawing.Point(343, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(815, 768);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(108, 36);
            this.TotalLabel.TabIndex = 37;
            this.TotalLabel.Text = "00 IQD";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // UC_P_SellMedicin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.btnpurches);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.btnaddTocart);
            this.Controls.Add(this.txtEdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNoUnit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMedname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmedid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxMedicin);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_P_SellMedicin";
            this.Size = new System.Drawing.Size(1460, 898);
            this.Load += new System.EventHandler(this.UC_P_SellMedicin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaAdvenceButton btnSync;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxMedicin;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtEdate;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtprice;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtNoUnit;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtTotalPrice;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtMedname;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtmedid;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnaddTocart;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnpurches;
        private System.Windows.Forms.Label TotalLabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
