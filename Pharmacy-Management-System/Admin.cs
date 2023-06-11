using Pharmacy_Management_System.AdminUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Admin : Form
    {
        string user = "";
        public Admin()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return user.ToString(); }
        }

        public Admin(string username)
        {
            InitializeComponent();
            UsernameLabel.Text = username;
            user = username;
            uC_ViewUser1.ID = ID;
            uS_profile1.ID = ID;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = false;
            uC_AddUser1.Visible = false;
            uC_ViewUser1.Visible = false;
            uS_profile1.Visible = false;
            uC_AddSuplier1.Visible = false;
            uC_Viewsupplier1.Visible = false;
            btnDashboard.PerformClick();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            uC_Dashboard1.Visible = true;
            uC_Dashboard1.BringToFront();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            uC_ViewUser1.Visible = true;
            uC_ViewUser1.BringToFront();
        }

        private void uC_ViewUser1_Load(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            uS_profile1.Visible = true;
            uS_profile1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddSuplier_Click(object sender, EventArgs e)
        {
            uC_AddSuplier1.Visible = true;
            uC_AddSuplier1.BringToFront();
        }

        private void btnViewSupplier_Click(object sender, EventArgs e)
        {
            uC_Viewsupplier1.Visible = true;
            uC_Viewsupplier1.BringToFront();
        }

        private void uC_Viewsupplier1_Load(object sender, EventArgs e)
        {

        }
    }
}
