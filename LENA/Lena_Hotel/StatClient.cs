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

namespace Lena_Hotel
{
    public partial class StatClient : MaterialSkin.Controls.MaterialForm
    {
        public static Reservation selecteReservation = null;
        public bool significant = false;
        public StatClient()
        {
            significant = false;
            InitializeComponent();
            btnDesirable.Hide();
            BtnIndesirable.Hide();
            WindowState = FormWindowState.Maximized;
            dateTimePickersearch.Hide();
            comboBoxSearch.SelectedIndex = 0;
            loadListView(new Reservations().Find(x => true).ToList());
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue200, MaterialSkin.Primary.Blue200, MaterialSkin.Primary.DeepOrange900, MaterialSkin.Accent.Blue700, MaterialSkin.TextShade.BLACK);
        }

        private void StatClient_Load(object sender, EventArgs e)
        {
            
        }
        private void loadListView(List<Reservation> le)
        {
            dataGridViewresa.AutoGenerateColumns = false;
            dataGridViewresa.DataSource = null;
            dataGridViewresa.Refresh();
            dataGridViewresa.DataSource = le;
            significant = true;
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            if (dataGridViewresa.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("êtes vous sur de bien vouloir supprimer cette ligne?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow c in dataGridViewresa.SelectedRows)
                    {
                        Reservation d = c.DataBoundItem as Reservation;
                        new Reservations().remove(d);
                        new Form1().loadListView(new Chambres().Find(x => true).ToList());
                    }
                    materialRaisedRfreshResa_Click(sender, e);
                    new Form1().loadListView(new Chambres().Find(x => true).ToList());
                    MessageBox.Show(
                        "Supression effectué!",
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Bien vouloir sélectionner une ligne à supprimer",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void materialRaisedRfreshResa_Click(object sender, EventArgs e)
        {
            loadListView(new Reservations().Find(x => true).ToList());
            txtSearch.Text = "";
            dateTimePickersearch.Value = DateTime.Now;
        }

        private void dataGridViewresa_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void materialRaisedModification_Click(object sender, EventArgs e)
        {
            if (dataGridViewresa.SelectedRows.Count > 0)
            {
                
                Reservation d = dataGridViewresa.SelectedRows[0].DataBoundItem as Reservation;
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
                f1.TabControlResa.Show();
                f1.lblEmail.Text = d.Email;
                f1.lblNom.Text = d.Nom;
                f1.lblPrenom.Text = d.Prenom;
                f1.lblNumber.Text = d.Numero.ToString();
                f1.lblPassport.Text = d.NumCNI;
                f1.comboBoxNationalite.Text = d.Nationalite;
                f1.lblProfession.Text = d.Proffession;
                f1.lblAdresse.Text = d.Adresse;
                f1.comboBoxSexe.Text = d.sexe.ToString();
                f1.DatetimeActuel.Value = d.DateDuJour;
                f1.dateTimeDebut.Value = d.DateDebut;
                f1.dateTimeFin.Value = d.DateFin;
                f1.lblHotes.Text = d.nbrePersonne.ToString();
                f1.lblMontantVerse.Text = d.Montant_verse.ToString();
                f1.lblTotal.Text = d.Montant_Total.ToString();
                f1.comboBoxNumLocal.Text = d.chambre.NumChambre.ToString();
                f1.lblRestePayer.Text = (d.Montant_Total - d.Montant_verse).ToString();
                selecteReservation = d;
            }
            else
            {
                MessageBox.Show(
                    "Bien vouloir doublecliquer sur la ligne à modifier !",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void materialRaisedButtonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSearch.Text)||!string.IsNullOrWhiteSpace(dateTimePickersearch.Text))
            {
                if (comboBoxSearch.SelectedIndex == 1)
                {
                    loadListView(new Reservations().Find(x => x.Nom == txtSearch.Text).ToList());
                }
                else if(comboBoxSearch.SelectedIndex == 2)
                {
                    loadListView(new Reservations().Find(x => x.Prenom == txtSearch.Text).ToList());
                }
                else if (comboBoxSearch.SelectedIndex == 3)
                {
                    loadListView(new Reservations().Find(x => x.DateDebut.Day+"-"+ x.DateDebut.Month+"-"+ x.DateDebut.Year == dateTimePickersearch.Value.Day+"-"+ dateTimePickersearch.Value.Month+"-"+ dateTimePickersearch.Value.Year).ToList());
                }
                else if (comboBoxSearch.SelectedIndex == 4)
                {
                    loadListView(new Reservations().Find(x => x.DateFin.Day + "-" + x.DateFin.Month + "-" + x.DateFin.Year == dateTimePickersearch.Value.Day + "-" + dateTimePickersearch.Value.Month + "-" + dateTimePickersearch.Value.Year).ToList());
                }
                else if (comboBoxSearch.SelectedIndex == 5)
                {
                    loadListView(new Reservations().Find(x => x.DateDuJour.Day + "-" + x.DateDuJour.Month + "-" + x.DateDuJour.Year == dateTimePickersearch.Value.Day + "-" + dateTimePickersearch.Value.Month + "-" + dateTimePickersearch.Value.Year).ToList());

                }
                else if (comboBoxSearch.SelectedIndex == 6)
                {
                    loadListView(new Reservations().Find(x => x.Numero.ToString() == txtSearch.Text).ToList());
                }
                else if (comboBoxSearch.SelectedIndex == 7)
                {
                    loadListView(new Reservations().Find(x => x.Nationalite == txtSearch.Text).ToList());
                }
                else if (comboBoxSearch.SelectedIndex == 8)
                {
                    loadListView(new Reservations().Find(x => x.Montant_verse.ToString() == txtSearch.Text).ToList());
                }
                else if (comboBoxSearch.SelectedIndex == 9)
                {
                    loadListView(new Reservations().Find(x => x.Montant_Total.ToString() == txtSearch.Text).ToList());
                }
                else if (comboBoxSearch.SelectedIndex == 10)
                {
                    try
                    {
                        loadListView(new Reservations().Find(x => x.Montant_verse >= Convert.ToDouble(txtSearch.Text)).ToList());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bien vouloir entrer un montant valide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Bien vouloir sélectionner un critère de recherche", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bien vouloir Spécifier votre recherche !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void completion(AutoCompleteStringCollection l,TextBox t)
        {
            t.AutoCompleteSource= AutoCompleteSource.CustomSource;
            t.AutoCompleteCustomSource = l;
        }
        public AutoCompleteStringCollection Chargement(List<Reservation> liste, AutoCompleteStringCollection auto,int choix)
        {
            foreach(var i in liste)
            {
                if (choix==1)
                    auto.Add(i.Nom);
                if (choix == 2)
                    auto.Add(i.Prenom);
                if (choix == 4)
                    auto.Add(i.DateDebut.ToString());
                if (choix == 5)
                    auto.Add(i.DateFin.ToString());
                if (choix == 6)
                    auto.Add(i.DateDuJour.ToString());
                if (choix == 7)
                    auto.Add(i.Numero.ToString());
                if (choix == 8)
                    auto.Add(i.Nationalite);

            }
            return auto;
        }

        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSearch.SelectedIndex == 3 || comboBoxSearch.SelectedIndex == 4 || comboBoxSearch.SelectedIndex == 5)
            {
                txtSearch.Hide();
                AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
                auto.Clear();
                completion(Chargement(new Reservations().Find(x => true).ToList(), auto, comboBoxSearch.SelectedIndex), txtSearch);
                dateTimePickersearch.Show();

            }
            else
            {
                AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
                auto.Clear();
                completion(Chargement(new Reservations().Find(x => true).ToList(), auto, comboBoxSearch.SelectedIndex),txtSearch);
                txtSearch.Show();
                dateTimePickersearch.Hide();
            }
        }

        private void dataGridViewresa_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void StatClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void dataGridViewresa_CellContextMenuStripChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewresa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void materialRaisedButtonIndesirable_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewresa.SelectedRows.Count > 0)
            {
                materialRaisedButtonIndesirable.Hide();
                btnDesirable.Show();
                BtnIndesirable.Show();
            }
            else
            {
                MessageBox.Show(
                    "sélectionner la ligne indésirable/desirable !",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnIndesirable_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow c in dataGridViewresa.SelectedRows)
            {
                Reservation d = c.DataBoundItem as Reservation;
                new Reservations().statusChange(d, true);
                MessageBox.Show(
                "Le(s) client(s) " + d.Nom + " a(ont) bien été marqué(s) comme etant indésirable(s) !",
                "information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                loadListView(new Reservations().Find(x => true).ToList());
            }
            
            btnDesirable.Hide();
            BtnIndesirable.Hide();
            materialRaisedButtonIndesirable.Show();
        }

        private void btnDesirable_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow c in dataGridViewresa.SelectedRows)
            {
                Reservation d = c.DataBoundItem as Reservation;
                new Reservations().statusChange(d, false);
                MessageBox.Show(
                "Le(s) client(s) " + d.Nom + " a(ont) bien été marqué(s) comme etant désirable(s) !",
                "information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                loadListView(new Reservations().Find(x => true).ToList());
            }
            btnDesirable.Hide();
            BtnIndesirable.Hide();
            materialRaisedButtonIndesirable.Show();
        }

        private void materialRaisedResaPrint_Click(object sender, EventArgs e)
        {
            if(dataGridViewresa.SelectedRows.Count > 0)
            {
                List<Reservation> d = new List<Reservation>() { dataGridViewresa.SelectedRows[0].DataBoundItem as Reservation };
                List<ClasseFacture> l = new Factures().Transformer(d);
                Facture f = new Facture(l, "scilagou20@yahoo.fr", 696205804d);
                f.Show();
            }
            else
            {
                MessageBox.Show(
                    "Bien Sélectionner la ligne a imprimer !",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
