namespace Pharmacy_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSignIn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnReset = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 948);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 352);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(71, 516);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 219);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacy\r\nManagement\r\nSystem";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(90)))), ((int)(((byte)(150)))));
            this.panel2.Location = new System.Drawing.Point(736, 165);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 615);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(989, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sign In";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(867, 418);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(359, 40);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtPassword.Location = new System.Drawing.Point(867, 567);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(359, 40);
            this.txtPassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(860, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label4.Location = new System.Drawing.Point(860, 532);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // btnSignIn
            // 
            this.btnSignIn.AnimationHoverSpeed = 0.07F;
            this.btnSignIn.AnimationSpeed = 0.03F;
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnSignIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnSignIn.BorderSize = 1;
            this.btnSignIn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSignIn.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSignIn.CheckedForeColor = System.Drawing.Color.White;
            this.btnSignIn.CheckedImage = null;
            this.btnSignIn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSignIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignIn.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Image = null;
            this.btnSignIn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSignIn.LineColor = System.Drawing.Color.Transparent;
            this.btnSignIn.Location = new System.Drawing.Point(824, 656);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnSignIn.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnSignIn.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnSignIn.OnHoverImage = null;
            this.btnSignIn.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnSignIn.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignIn.Radius = 21;
            this.btnSignIn.Size = new System.Drawing.Size(213, 55);
            this.btnSignIn.TabIndex = 9;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnReset
            // 
            this.btnReset.AnimationHoverSpeed = 0.07F;
            this.btnReset.AnimationSpeed = 0.03F;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnReset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnReset.BorderSize = 1;
            this.btnReset.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnReset.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReset.CheckedForeColor = System.Drawing.Color.White;
            this.btnReset.CheckedImage = null;
            this.btnReset.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReset.FocusedColor = System.Drawing.Color.Empty;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = null;
            this.btnReset.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset.ImageOffsetX = 3;
            this.btnReset.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReset.LineColor = System.Drawing.Color.Transparent;
            this.btnReset.Location = new System.Drawing.Point(1060, 656);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnReset.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(120)))), ((int)(((byte)(190)))));
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Radius = 21;
            this.btnReset.Size = new System.Drawing.Size(213, 55);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(964, 121);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1749, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnExit.Size = new System.Drawing.Size(67, 41);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaAdvenceButton btnSignIn;
        private Guna.UI.WinForms.GunaAdvenceButton btnReset;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
    }
}

