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
    public partial class Planning : MaterialForm
    {
        public Planning()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue200, MaterialSkin.Primary.Blue200, MaterialSkin.Primary.DeepOrange900, MaterialSkin.Accent.Blue700, MaterialSkin.TextShade.BLACK);

        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatClient SC = new StatClient();
            SC.Show();
           
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistique EL = new Statistique();
            EL.Show();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void Planning_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
