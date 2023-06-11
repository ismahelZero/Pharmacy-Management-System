using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.PharmacistUC
{
    public partial class UC_P_AddMedicine : UserControl
    {
        function fn = new function();
        string query;
        public UC_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtmedid.Text!="" && txtmedname.Text!="" && txtmadein.Text!="" && txtmedtype.Text!="" && txtquantity.Text!="" && txtprice.Text!="")
            {
                string mid = txtmedid.Text;
                string mname = txtmedname.Text;
                string madein = txtmadein.Text;
                string mtype = txtmedtype.Text;
                Int64 quantity = Convert.ToInt64(txtquantity.Text);
                Int64 price = Convert.ToInt64(txtprice.Text);
                string mdate = txtmdate.Text;
                string edate = txtedate.Text;
                query = "insert into medic (mid,mname,made_in,mtype,mdate,edate,quantity,price) values ('" + mid + "','" + mname + "','" + madein + "','" + mtype + "','" + mdate + "','" + edate + "','" + quantity + "','" + price + "')";
                fn.setData(query, "Medicine Added to database.");
                clearall();
            }
            else
            {
                MessageBox.Show("Enter all data Please.","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btmreset_Click(object sender, EventArgs e)
        {
            clearall();
        }

        public void clearall()
        {
            txtmedid.Clear();
            txtmedname.Clear();
            txtmadein.Clear();
            txtmedtype.Clear();
            txtquantity.Clear();
            txtprice.Clear();
            txtmdate.ResetText();
            txtedate.ResetText();
        }

        private void UC_P_AddMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}
