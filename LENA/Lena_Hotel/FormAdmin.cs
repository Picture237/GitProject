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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            textBoxPwd.PasswordChar = '*';
            textBoxPwd.MaxLength = 10;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text !="abigael")
            {
                MessageBox.Show("Entrer le veritable nom d'administrateur");
            }
            else
            {
                if (textBoxPwd.Text == "theboss")
                {
                    FormHome_Stat fh = new FormHome_Stat();
                    fh.Show();
                    this.Close();
                }
                else
                {
                    label3.Visible = true;
                }
            }
        }
    }
}
