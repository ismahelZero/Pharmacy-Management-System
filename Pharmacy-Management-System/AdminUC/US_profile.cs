using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.AdminUC
{
    public partial class US_profile : UserControl
    {
        function fn = new function();
        string query;

        public US_profile()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { usernamelabel.Text = value; }
        }

        private void US_profile_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string role = txtuserrole.Text;
            string name = txtname.Text;
            string dob = txtdob.Text;
            Int64 mobile = Convert.ToInt64(txtmobile.Text);
            string email = txtemail.Text;
            string username = usernamelabel.Text;
            string pass = txtpass.Text;

            query = "update users set userRole='" + role + "' ,name='" + name + "' ,dob='" + dob + "' ,mobile='" + mobile + "' ,email='" + email + "' ,pass='" + pass + "' where username='" + username + "'";
            fn.setData(query, "Profile Updation Successful");
        }

        private void US_profile_Enter(object sender, EventArgs e)
        {
            query="select * from users where username = '"+usernamelabel.Text+"'";
            DataSet ds = fn.getData(query);
            txtuserrole.Text = ds.Tables[0].Rows[0][1].ToString();
            txtname.Text = ds.Tables[0].Rows[0][2].ToString();
            txtdob.Text = ds.Tables[0].Rows[0][3].ToString();
            txtmobile.Text = ds.Tables[0].Rows[0][4].ToString();
            txtemail.Text = ds.Tables[0].Rows[0][5].ToString();
            txtpass.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            US_profile_Enter(this, null);
        }
    }
}
