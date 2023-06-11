using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System.PharmacistUC
{
    public partial class UC_P_UpdateMedicine : UserControl
    {
        function fn = new function();
        String query;

        public UC_P_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMediID.Text != "")
            {
                query = "select *from medic where mid = '" + txtMediID.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMediName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMadeIn.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtMedicintype.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtMDate.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtEDate.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtAvailableQuantity.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtPricePerUnit.Text = ds.Tables[0].Rows[0][8].ToString();
                }
                else
                {
                    MessageBox.Show("No Medicine with ID : "+txtMediID.Text+" exist.","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                clearAll();
            }

            
        }
        private void clearAll()
        {
            txtMediID.Clear();
            txtMediName.Clear();
            txtMadeIn.Clear();
            txtMedicintype.Clear();
            txtMDate.ResetText();
            txtEDate.ResetText();
            txtAvailableQuantity.Clear();
            txtPricePerUnit.Clear();
            if(txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }
        }

        Int64 totalQuantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String mname = txtMediName.Text;
            String madein = txtMadeIn.Text;
            String mtype = txtMedicintype.Text;
            String mdate = txtMDate.Text;
            String edate = txtEDate.Text;
            Int64 quantity = Int64.Parse(txtAvailableQuantity.Text);
            Int64 addQuantity = Int64.Parse(txtAddQuantity.Text);
            Int64 unitprice = Int64.Parse(txtPricePerUnit.Text);

            totalQuantity = quantity + addQuantity;

            query = "update medic set mname = '" + mname + "', made_in = '" + madein + "',mtype = '" + mtype + "', mdate = '" + mdate + "', edate = '" + edate + "', quantity = '" + totalQuantity + "', price = '" + unitprice + "' where  mid = '" + txtMediID.Text + "'";
            fn.setData(query, "Medicine Details Updated.");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_P_UpdateMedicine_Load(object sender, EventArgs e)
        {

        }
    }
}
