namespace Pharmacy_Management_System.AdminUC
{
    partial class US_profile
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtuserrole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdob = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnreset = new Guna.UI2.WinForms.Guna2Button();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            // 
            // usernamelabel
            // 
            this.usernamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.Location = new System.Drawing.Point(318, 548);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(305, 29);
            this.usernamelabel.TabIndex = 2;
            this.usernamelabel.Text = "Username";
            this.usernamelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(865, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Role";
            // 
            // txtuserrole
            // 
            this.txtuserrole.BackColor = System.Drawing.Color.Transparent;
            this.txtuserrole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtuserrole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtuserrole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtuserrole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtuserrole.FocusedState.Parent = this.txtuserrole;
            this.txtuserrole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserrole.ForeColor = System.Drawing.Color.Black;
            this.txtuserrole.HoverState.Parent = this.txtuserrole;
            this.txtuserrole.ItemHeight = 30;
            this.txtuserrole.Items.AddRange(new object[] {
            "Admin",
            "Pharmacist",
            "Customer"});
            this.txtuserrole.ItemsAppearance.Parent = this.txtuserrole;
            this.txtuserrole.Location = new System.Drawing.Point(870, 158);
            this.txtuserrole.Name = "txtuserrole";
            this.txtuserrole.ShadowDecoration.Parent = this.txtuserrole;
            this.txtuserrole.Size = new System.Drawing.Size(390, 36);
            this.txtuserrole.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtname.DefaultText = "";
            this.txtname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.DisabledState.Parent = this.txtname;
            this.txtname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.FocusedState.Parent = this.txtname;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtname.HoverState.Parent = this.txtname;
            this.txtname.Location = new System.Drawing.Point(870, 255);
            this.txtname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PlaceholderText = "";
            this.txtname.SelectedText = "";
            this.txtname.ShadowDecoration.Parent = this.txtname;
            this.txtname.Size = new System.Drawing.Size(390, 36);
            this.txtname.TabIndex = 5;
            this.txtname.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(865, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(865, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "DoB (date of Birth)";
            // 
            // txtdob
            // 
            this.txtdob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdob.DefaultText = "";
            this.txtdob.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdob.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdob.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdob.DisabledState.Parent = this.txtdob;
            this.txtdob.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdob.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdob.FocusedState.Parent = this.txtdob;
            this.txtdob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdob.ForeColor = System.Drawing.Color.Black;
            this.txtdob.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdob.HoverState.Parent = this.txtdob;
            this.txtdob.Location = new System.Drawing.Point(870, 348);
            this.txtdob.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtdob.Name = "txtdob";
            this.txtdob.PasswordChar = '\0';
            this.txtdob.PlaceholderText = "";
            this.txtdob.SelectedText = "";
            this.txtdob.ShadowDecoration.Parent = this.txtdob;
            this.txtdob.Size = new System.Drawing.Size(390, 36);
            this.txtdob.TabIndex = 7;
            this.txtdob.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(865, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mobile No";
            // 
            // txtmobile
            // 
            this.txtmobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmobile.DefaultText = "";
            this.txtmobile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmobile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmobile.DisabledState.Parent = this.txtmobile;
            this.txtmobile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmobile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmobile.FocusedState.Parent = this.txtmobile;
            this.txtmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobile.ForeColor = System.Drawing.Color.Black;
            this.txtmobile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmobile.HoverState.Parent = this.txtmobile;
            this.txtmobile.Location = new System.Drawing.Point(870, 433);
            this.txtmobile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.PasswordChar = '\0';
            this.txtmobile.PlaceholderText = "";
            this.txtmobile.SelectedText = "";
            this.txtmobile.ShadowDecoration.Parent = this.txtmobile;
            this.txtmobile.Size = new System.Drawing.Size(390, 36);
            this.txtmobile.TabIndex = 9;
            this.txtmobile.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(865, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email Address";
            // 
            // txtemail
            // 
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.Parent = this.txtemail;
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.FocusedState.Parent = this.txtemail;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.HoverState.Parent = this.txtemail;
            this.txtemail.Location = new System.Drawing.Point(870, 519);
            this.txtemail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderText = "";
            this.txtemail.SelectedText = "";
            this.txtemail.ShadowDecoration.Parent = this.txtemail;
            this.txtemail.Size = new System.Drawing.Size(390, 36);
            this.txtemail.TabIndex = 11;
            this.txtemail.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(865, 569);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Password";
            // 
            // txtpass
            // 
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.DefaultText = "";
            this.txtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.DisabledState.Parent = this.txtpass;
            this.txtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.FocusedState.Parent = this.txtpass;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.Black;
            this.txtpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.HoverState.Parent = this.txtpass;
            this.txtpass.Location = new System.Drawing.Point(870, 600);
            this.txtpass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '\0';
            this.txtpass.PlaceholderText = "";
            this.txtpass.SelectedText = "";
            this.txtpass.ShadowDecoration.Parent = this.txtpass;
            this.txtpass.Size = new System.Drawing.Size(390, 36);
            this.txtpass.TabIndex = 13;
            this.txtpass.TextChanged += new System.EventHandler(this.guna2TextBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(930, 765);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "*Check the detailes before UPDATE";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnreset
            // 
            this.btnreset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnreset.BorderRadius = 25;
            this.btnreset.BorderThickness = 1;
            this.btnreset.CheckedState.Parent = this.btnreset;
            this.btnreset.CustomImages.Parent = this.btnreset;
            this.btnreset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnreset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnreset.HoverState.FillColor = System.Drawing.Color.White;
            this.btnreset.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnreset.HoverState.Parent = this.btnreset;
            this.btnreset.Image = global::Pharmacy_Management_System.Properties.Resources.reset_25px;
            this.btnreset.ImageSize = new System.Drawing.Size(30, 30);
            this.btnreset.Location = new System.Drawing.Point(1075, 680);
            this.btnreset.Name = "btnreset";
            this.btnreset.ShadowDecoration.Parent = this.btnreset;
            this.btnreset.Size = new System.Drawing.Size(210, 55);
            this.btnreset.TabIndex = 16;
            this.btnreset.Text = "Reset";
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnupdate.BorderRadius = 25;
            this.btnupdate.BorderThickness = 1;
            this.btnupdate.CheckedState.Parent = this.btnupdate;
            this.btnupdate.CustomImages.Parent = this.btnupdate;
            this.btnupdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnupdate.HoverState.FillColor = System.Drawing.Color.White;
            this.btnupdate.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnupdate.HoverState.Parent = this.btnupdate;
            this.btnupdate.Image = global::Pharmacy_Management_System.Properties.Resources.update_64px;
            this.btnupdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnupdate.Location = new System.Drawing.Point(845, 680);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.ShadowDecoration.Parent = this.btnupdate;
            this.btnupdate.Size = new System.Drawing.Size(210, 55);
            this.btnupdate.TabIndex = 15;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy_Management_System.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(318, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // US_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmobile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtuserrole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "US_profile";
            this.Size = new System.Drawing.Size(1460, 898);
            this.Load += new System.EventHandler(this.US_profile_Load);
            this.Enter += new System.EventHandler(this.US_profile_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox txtuserrole;
        private Guna.UI2.WinForms.Guna2TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtdob;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtmobile;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtpass;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private Guna.UI2.WinForms.Guna2Button btnreset;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
