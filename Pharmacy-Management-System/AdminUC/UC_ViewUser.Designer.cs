namespace Pharmacy_Management_System.AdminUC
{
    partial class UC_ViewUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.btnDelete = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "View User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(30, 265);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(1035, 350);
            this.gunaDataGridView1.TabIndex = 5;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDelete.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnDelete.CheckedForeColor = System.Drawing.Color.White;
            this.btnDelete.CheckedImage = null;
            this.btnDelete.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::Pharmacy_Management_System.Properties.Resources.remove_11;
            this.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.ImageSize = new System.Drawing.Size(32, 32);
            this.btnDelete.LineColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(885, 660);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = global::Pharmacy_Management_System.Properties.Resources.remove_11;
            this.btnDelete.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 21;
            this.btnDelete.Size = new System.Drawing.Size(180, 42);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.TextOffsetX = -7;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.Parent = this.txtUserName;
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.FocusedState.Parent = this.txtUserName;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.HoverState.Parent = this.txtUserName;
            this.txtUserName.Location = new System.Drawing.Point(378, 189);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "Search Here";
            this.txtUserName.SelectedText = "";
            this.txtUserName.ShadowDecoration.Parent = this.txtUserName;
            this.txtUserName.Size = new System.Drawing.Size(341, 33);
            this.txtUserName.TabIndex = 9;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = null;
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = global::Pharmacy_Management_System.Properties.Resources.sync_green;
            this.gunaAdvenceButton1.ImageOffsetX = -10;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(35, 35);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(202, 29);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(37, 32);
            this.gunaAdvenceButton1.TabIndex = 11;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Pharmacy_Management_System.Properties.Resources.sync;
            this.pictureBox2.Location = new System.Drawing.Point(183, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // UC_ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaDataGridView1);
            this.Name = "UC_ViewUser";
            this.Size = new System.Drawing.Size(1095, 730);
            this.Load += new System.EventHandler(this.UC_ViewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaAdvenceButton btnDelete;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
