using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lena_Hotel
{

    public partial class SpashScreem : Form
    {
        private bool close = true;
        public SpashScreem()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Home f = new Home();
            close = false;
            f.Show();
            this.Hide();
        }

        private void SpashScreem_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == true)
                Application.Exit();
        }
    }
}
