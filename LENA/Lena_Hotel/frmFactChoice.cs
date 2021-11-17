using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lena.BO;
using Lena.BLL;
using MaterialSkin.Controls;

namespace Lena_Hotel
{
    public partial class frmFactChoice : MaterialForm
    {
        public frmFactChoice()
        {
            InitializeComponent();
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            auto.Clear();
            completion(Chargement(new Factures().Find(x => true).ToList(), auto), textBox1);
        }

        private void frmFactChoice_Load(object sender, EventArgs e)
        {

        }

        public void completion(AutoCompleteStringCollection l, TextBox t)
        {
            t.AutoCompleteSource = AutoCompleteSource.CustomSource;
            t.AutoCompleteCustomSource = l;
        }

        public AutoCompleteStringCollection Chargement(List<ClasseFacture> liste, AutoCompleteStringCollection auto)
        {
            foreach (var i in liste)
            {
                    auto.Add(i.NomF);
            }
            return auto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                StatFacture sf = new StatFacture(new Factures().findByPersonne(textBox1.Text),textBox1.Text);
                sf.Show();
            }
            else
            {
                MessageBox.Show("Bien vouloir le nom de votre clilent !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StatFacture sf = new StatFacture(new Factures().Find(x=>true).ToList(),"Tout les clients");
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormHome_Stat fx = new FormHome_Stat();
            fx.Show();
            this.Hide();
        }
    }
}
