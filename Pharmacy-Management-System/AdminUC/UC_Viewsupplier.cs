using System;
using System.Collections;
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
    public partial class UC_Viewsupplier : UserControl
    {
        function fn = new function();
        string query;
        string suppliername;
        public UC_Viewsupplier()
        {
            InitializeComponent();
        }

        private void UC_Viewsupplier_Load(object sender, EventArgs e)
        {
            query = "select *from supplier1";
            DataSet ds = fn.getData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                suppliername = gunaDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                
                    query = "Delete from supplier1 where s_name = '" + suppliername + "'";
                    fn.setData(query, "User Record Deleted.");
                    UC_Viewsupplier_Load(this, null);
                
               
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            UC_Viewsupplier_Load(this, null);
        }

        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from supplier1 where s_name like '" + txtSupplierName.Text + "%'";
            DataSet ds = fn.getData(query);
            gunaDataGridView1.DataSource = ds.Tables[0];
        }
    }
}
