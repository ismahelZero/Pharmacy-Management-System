using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;
using Pharmacy_Management_System.Properties;

namespace Pharmacy_Management_System.AdminUC
{
    public partial class UC_AddUser : UserControl
    {

        function fn = new function();
        string query;

        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtUserRole.Text=="" || txtName.Text=="" || txtDob.Text=="" || txtMobileNo.Text=="" || txtEmail.Text=="" || txtUsername.Text=="" || txtPassword.Text=="")
            {

                MessageBox.Show("Please Fill All Datas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                String role = txtUserRole.Text;
                string name = txtName.Text;
                string dob = txtDob.Text;
                Int64 mobile = Int64.Parse(txtMobileNo.Text);
                string email = txtEmail.Text;
                string username = txtUsername.Text;
                string pass = txtPassword.Text;

                try
                {
                    query = "insert into users (userRole,name,dob,mobile,email,username,pass) values ('" + role + "','" + name + "','" + dob + "','" + mobile + "','" + email + "','" + username + "','" + pass + "')";
                    fn.setData(query, "Sign Up Succesfull");
                    ClearAll();
                }
                catch (Exception)
                {
                    MessageBox.Show("Username Allready Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           


           
        }

       

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            txtUserRole.SelectedIndex = -1;
            txtName.Clear();
            txtDob.ResetText();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where Username = '" + txtUsername.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                PictureBox1.Image = Resources.yes;
            }
            else
            {
                PictureBox1.Image = Resources.no;
            }
        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
