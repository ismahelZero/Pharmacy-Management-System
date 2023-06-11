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
    public partial class Form1 : Form
    {
        function fn = new function();
        string query;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if(txtUsername.Text=="root" && txtPassword.Text == "root")
                {
                    Admin admin = new Admin(txtUsername.Text);
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from users where Username ='" + txtUsername.Text + "' and pass ='" + txtPassword.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count!=0)
                {
                    string role = ds.Tables[0].Rows[0][1].ToString();
                    if(role =="Admin")
                    {
                        Admin admin = new Admin(txtUsername.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if(role == "Pharmacist")
                    {
                        Pharmacist pharm = new Pharmacist();
                        pharm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username OR Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
