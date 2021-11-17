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
    public partial class FrmChoice : MaterialForm
    {
        public FrmChoice()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            StatistiqueC stc = new StatistiqueC(new ReservationsLogs().Recherche(dateTimePickerfirst.Value, dateTimePickersecond.Value), DateTime.Now.ToString());
            stc.Show();
        }

        private void FrmChoice_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            FormHome_Stat fsta = new FormHome_Stat();
            fsta.Show();
            this.Hide();
        }

        private void FrmChoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHome_Stat fsta = new FormHome_Stat();
            fsta.Show();
            this.Hide();
        }
    }
}
