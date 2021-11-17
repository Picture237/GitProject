using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lena.BLL;
using Lena.BO;
using MaterialSkin.Controls;

namespace Lena_Hotel
{
    public partial class FormHome_Stat : MaterialForm
    {
        private bool close = true;
        public FormHome_Stat()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFactChoice SF = new frmFactChoice();
            SF.Show();
        }

        private void materialRaisedReservHeb_Click(object sender, EventArgs e)
        {
            FrmChoice FC = new FrmChoice();
            FC.Show();
            this.Hide();
        }

        private void materialRaisedChambreEtat_Click(object sender, EventArgs e)
        {
           
        }

        private void FormHome_Stat_Load(object sender, EventArgs e)
        {

        }

        private void FormHome_Stat_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == true)
            {
                Home h = new Home();
                this.Hide();
                h.Show();
               
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            StatLocaux SL = new StatLocaux(new Chambres().Find(x => true).ToList());
            SL.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
