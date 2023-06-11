using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pharmacy_Management_System.AdminUC
{
    public partial class UC_AddSuplier : UserControl
    {
        function fn = new function();
        string query;

        public UC_AddSuplier()
        {
            InitializeComponent();
        }
        
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            string name = txtName.Text;
            string country = txtCountry.Text;
            Int64 mobile = Int64.Parse(txtMobileNo.Text);
            string email = txtEmail.Text;
            string street = txtStreet.Text;
            string city = txtCity.Text;

            try
            {
                query = "insert into supplier1 (s_name,country,mobile,email,street,city) values ('" + name + "','" + country + "','" + mobile + "','" + email + "','" + street + "','" + city + "')";
                fn.setData(query, "Supplier Added Succesfull");
                ClearAll();
            }
            catch 
            {
               
            }
        }

        private void UC_AddSuplier_Load(object sender, EventArgs e)
        {

        }

        public void ClearAll()
        {
            
            txtName.Clear();
            txtEmail.ResetText();
            txtMobileNo.Clear();
            txtCountry.Clear();
            txtCity.Clear();
            txtStreet.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        
    }
}
