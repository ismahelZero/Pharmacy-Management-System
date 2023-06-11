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
    public partial class UC_P_dashboard : UserControl
    {
        function fn = new function();
        string query;
        DataSet ds;
        Int64 count;
        public UC_P_dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UC_P_dashboard_Load(object sender, EventArgs e)
        {
            loadchart();
        }

        public void loadchart()
        {
            query = "select count(mname) from medic where edate >= getdate()";
            ds = fn.getData(query);
            count =Convert.ToInt64(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Valid Medicines"].Points.AddXY("Medicin Validity Chart", count);

            query = "select count(mname) from medic where edate <= getdate()";
            ds = fn.getData(query);
            count = Convert.ToInt64(ds.Tables[0].Rows[0][0].ToString());
            this.chart1.Series["Expired Medicines"].Points.AddXY("Medicin Validity Chart", count);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Valid Medicines"].Points.Clear();
            this.chart1.Series["Expired Medicines"].Points.Clear();
            loadchart();
        }
    }
}
