using DGVPrinterHelper;
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
    public partial class UC_P_SellMedicin : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;

        public UC_P_SellMedicin()
        {
            InitializeComponent();
        }

        private void UC_P_SellMedicin_Load(object sender, EventArgs e)
        {
            listBoxMedicin.Items.Clear();
            query = "select mname from medic where edate >= getdate() and quantity > '0'";
            ds = fn.getData(query);

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicin.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UC_P_SellMedicin_Load(this, null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicin.Items.Clear();
            query = "select mname from medic where mname like '" + txtSearch.Text + "%' and edate >= getdate() and quantity >'0'";
            ds = fn.getData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicin.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBoxMedicin_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNoUnit.Clear();

            string name = listBoxMedicin.GetItemText(listBoxMedicin.SelectedItem);

            txtMedname.Text = name;

            query = "select mid,edate,price from medic where mname ='" + name + "'";
            ds = fn.getData(query);
            txtmedid.Text = ds.Tables[0].Rows[0][0].ToString();
            txtEdate.Text = ds.Tables[0].Rows[0][1].ToString();
            txtprice.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtNoUnit_TextChanged(object sender, EventArgs e)
        {
            if(txtNoUnit.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtprice.Text);
                Int64 noofUnite = Int64.Parse(txtNoUnit.Text);
                Int64 totalAmount = noofUnite * unitPrice;
                txtTotalPrice.Text = totalAmount.ToString();

            }
            else
            {
                txtTotalPrice.Clear();
            }
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(ValueId != null)
            {
                try
                {
                    guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
                }
                catch 
                {
                
                }
                finally
                {
                    query = "select quantity from medic where mid = '" + ValueId + "'";
                    ds = fn.getData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfunit;

                    query = "update medic set quantity = '" + newQuantity + "' where mid = '" + ValueId + "'";
                    fn.setData(query, "Medicine Removed From Cart");
                    totalAmount = totalAmount - valueAmount;
                    TotalLabel.Text =totalAmount.ToString() + " IQD";
                }
                UC_P_SellMedicin_Load(this, null);

                ValueId = null;
            }
        }

        int valueAmount;
        string ValueId;
        protected Int64 noOfunit;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                ValueId = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfunit = Int64.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch(Exception)
            {
            
            }
        }

        private void btnpurches_Click(object sender, EventArgs e)
        {
            DGVPrinter print = new DGVPrinter();
            print.Title = "Medicine Bill";
            print.SubTitle = string.Format("Date:- {0}", DateTime.Now.Date);
            print.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            print.PageNumbers = true;
            print.PageNumberInHeader = false;
            print.PorportionalColumns = true;
            print.HeaderCellAlignment = StringAlignment.Near;
            print.Footer = "Total Payble Amount : " + TotalLabel.Text;
            print.FooterSpacing = 15;
            print.PrintDataGridView(guna2DataGridView1);


            totalAmount= 0;
            TotalLabel.Text = "00 IQD";
            guna2DataGridView1.DataSource = 0;
        }

        

        private void btnaddTocart_Click(object sender, EventArgs e)
        {
            if(txtmedid.Text != "")
            {
                if (txtNoUnit.Text != "")
                {
                    query = "select quantity from medic where mid='" + txtmedid.Text + "'";
                    ds = fn.getData(query);

                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity - Int64.Parse(txtNoUnit.Text);

                    if (newQuantity >= 0)
                    {
                        n = guna2DataGridView1.Rows.Add();
                        guna2DataGridView1.Rows[n].Cells[0].Value = txtmedid.Text;
                        guna2DataGridView1.Rows[n].Cells[1].Value = txtMedname.Text;
                        guna2DataGridView1.Rows[n].Cells[2].Value = txtEdate.Text;
                        guna2DataGridView1.Rows[n].Cells[3].Value = txtprice.Text;
                        guna2DataGridView1.Rows[n].Cells[4].Value = txtNoUnit.Text;
                        guna2DataGridView1.Rows[n].Cells[5].Value = txtTotalPrice.Text;

                        totalAmount = totalAmount + int.Parse(txtTotalPrice.Text);
                        TotalLabel.Text = totalAmount.ToString() + " IQD"; ;

                        query = "update medic set quantity = '" + newQuantity + "' where mid = '" + txtmedid.Text + "'";
                        fn.setData(query, "Medicine Added");
                    }
                    else
                    {
                        MessageBox.Show("Medicine Is Out Of Stock. \n Only " + quantity + " Is Left", "warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    clearAll();
                    UC_P_SellMedicin_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Select Number Of Medicine.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Select Medicine First.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
        private void clearAll()
        {
            txtmedid.Clear();
            txtprice.Clear();
            txtMedname.Clear();
            txtNoUnit.Clear();
            txtEdate.ResetText();
        }
    }
}
