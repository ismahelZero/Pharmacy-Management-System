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
    public partial class loading : Form
    {
        int startpoint = 0;
        public loading()
        {
            InitializeComponent();
        }

        private void loading_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 2;
            guna2CircleProgressBar1.Value = startpoint;
            if(guna2CircleProgressBar1.Value == 100)
            {
                guna2CircleProgressBar1.Value = 0;
                timer1.Stop();
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();

            }
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
