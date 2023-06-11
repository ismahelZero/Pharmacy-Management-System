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
    public partial class UC_Dashboard : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        public UC_Dashboard()
        {
            InitializeComponent();
        }

        private void UC_Dashboard_Load(object sender, EventArgs e)
        {
            query = "select count(userRole) from users where userRole = 'Admin'";
            ds = fn.getData(query);
            setLabel(ds, AdminLabel);

            query = "select count(userRole) from users where userRole = 'Pharmacist'";
            ds = fn.getData(query);
            setLabel(ds, PharLabel);

            query = "select count(s_name) from supplier1";
            ds = fn.getData(query);
            setLabel(ds, SupplierLabel);
        }

        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count!=0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }


        private void btnSync_Click_1(object sender, EventArgs e)
        {
            UC_Dashboard_Load(this, null);
        }

        private void SupplierLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
