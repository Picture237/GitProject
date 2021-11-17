using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;


namespace Lena_Hotel
{
    public partial class Home : Form
    {
        private bool close = true;
        public Home()
        {
            InitializeComponent();
            
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAdmin F = new FormAdmin();
            close = false;
            this.Close();
            F.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form1 F = new Form1();
            close = false;
            this.Close();
            F.Show();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == true)
            {
                Application.Exit();
            }
        }
    }
}