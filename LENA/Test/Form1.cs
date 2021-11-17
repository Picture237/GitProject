using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public class personne
        {
            

            public string Nom { get; set; }
            public string Prenom { get; set; }
            public personne(string nom, string prenom)
            {
                Nom = nom;
                Prenom = prenom;
            }
        }
        public Form1()
        {
            InitializeComponent();
            loadlistview();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void loadlistview()
        {
            List<personne> list = new List<personne>()
            {
                new personne("junior","lionel")
            };
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = list;
        }
    }
}
