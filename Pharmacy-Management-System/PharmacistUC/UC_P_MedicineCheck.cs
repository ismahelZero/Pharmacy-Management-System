﻿using System;
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
    public partial class UC_P_MedicineCheck : UserControl
    {
        function fn = new function();
        string query;

        public UC_P_MedicineCheck()
        {
            InitializeComponent();
        }

        private void UC_P_MedicineCheck_Load(object sender, EventArgs e)
        {
            setLabel.Text = "";
        }

        private void txtCheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCheck.SelectedIndex == 0)
            {
                query = "select *from medic where edate >= getdate()";
                setDataGridView(query, "Valid Medicines.", Color.Green);
            }
            else if (txtCheck.SelectedIndex == 1)
            {
                query = "select *from medic where edate <= getdate()";
                setDataGridView(query, "Expired Medicines.", Color.Red);
            }
            else if (txtCheck.SelectedIndex == 2)
            {
                query = "select *from medic";
                setDataGridView(query, "View All Medicines.", Color.Black);
            }
        }
        private void setDataGridView(String query, String labelName, Color col)
        {
            DataSet ds = fn.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];
            setLabel.Text = labelName;
            setLabel.ForeColor = col;
        }
    }
}
