using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    internal class function
    {
        protected SqlConnection GetConnection() 
        {
            SqlConnection conn = new SqlConnection();
           // conn.ConnectionString = "Data Source=DESKTOP-K8QHK2J\\SQLEXPRESS;Initial Catalog=iso;Integrated Security=True";
            conn.ConnectionString = "Data Source=LAPTOP-2J7D7T6H\\SQLEXPRESS;Initial Catalog=iso;Integrated Security=True";
            return conn;
        }
         
        public DataSet getData(string query)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(string query, string msg)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(msg,"Information", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
 