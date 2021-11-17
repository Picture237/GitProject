using System;
using MaterialSkin.Controls;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MaterialSkin.Controls;
using Lena.BLL;
using Lena.BO;

namespace Lena_Hotel
{
    public partial class Form1 : MaterialForm
    {
        private Chambre SelectedChambre = null;
        private List<Reservation> listeTempon = null;
        private bool close = true;
        public Form1()
        {
            InitializeComponent();
            comboBoxState.Hide();
            listeTempon = new List<Reservation>();
            WindowState = FormWindowState.Maximized;
            loadListView(new TypesChambres().Find(x => true).ToList());
            loadListView(new Chambres().Find(x => true).ToList());
            addONcomboType();
            addONcomboResa();
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue200, MaterialSkin.Primary.Blue200, MaterialSkin.Primary.DeepOrange900, MaterialSkin.Accent.Blue700, MaterialSkin.TextShade.BLACK);
        }

        public void addONcomboType()
        {
            List<TypeChambre> liste = new TypesChambres().Find(x => true).ToList();
            comboBoxTypes.Items.Clear();
            for (int i = 0; i < liste.Count; i++)
            {
                comboBoxTypes.Items.Add(liste[i].Intitule);
            }
            liste.Clear();
        }

        public void addONcomboResa()
        {
            List<Chambre> liste = new Chambres().Find(x => true).ToList();
            for (int i = 0; i < liste.Count; i++)
            {
                comboBoxNumLocal.Items.Add(liste[i].NumChambre);
            }
            liste.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void loadListView(List<TypeChambre> l)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = l;
        }

        public void loadListView(List<Chambre> le)
        {
            dataGridViewlocaux.AutoGenerateColumns = false;
            dataGridViewlocaux.DataSource = null;
            dataGridViewlocaux.Refresh();
            dataGridViewlocaux.DataSource = le;
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Réservation_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
          
        }

        private void materialRaisedButton11_Click(object sender, EventArgs e)
        {
            
            StatClient SC = new StatClient();
            close = false;
            this.Hide();
            SC.Show();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblIntituleType.Text))
            {
                TypesChambres tc = new TypesChambres();
                tc.add(lblIntituleType.Text);
                MessageBox.Show("le type " + lblIntituleType.Text + " a été crée avec succés!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblIntituleType.Text = "";
            }
        }

        private void btnAnnulerType_Click(object sender, EventArgs e)
        {

            lblIntituleType.Text = "";
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(lblNom.Text))
            {
                if (!string.IsNullOrWhiteSpace(lblPrenom.Text))
                {
                    if (!string.IsNullOrWhiteSpace(lblMontantVerse.Text))
                    {
                        if (Convert.ToDateTime(dateTimeDebut.Value.Day+"/"+dateTimeDebut.Value.Month+"/"+dateTimeDebut.Value.Year) >= Convert.ToDateTime(DatetimeActuel.Value.Day+"/"+DatetimeActuel.Value.Month+"/"+DatetimeActuel.Value.Year))
                        {
                            if (Convert.ToDateTime(dateTimeFin.Value.Day + "/" + dateTimeFin.Value.Month + "/" + dateTimeFin.Value.Year) >= Convert.ToDateTime(dateTimeDebut.Value.Day + "/" + dateTimeDebut.Value.Month + "/" + dateTimeDebut.Value.Year))
                            {
                                if (Convert.ToDouble(lblTotal.Text)>= Convert.ToDouble(lblMontantVerse.Text))
                                {
                                    if (!string.IsNullOrWhiteSpace(lblNumber.Text))
                                    {
                                        if (StatClient.selecteReservation == null)
                                        {
                                            try
                                            {
                                                Reservation r = new Reservation(0, lblEmail.Text, lblNom.Text, lblPrenom.Text, long.Parse(lblNumber.Text),
                                                lblPassport.Text, comboBoxNationalite.Text, lblProfession.Text, lblAdresse.Text,
                                                (comboBoxSexe.SelectedIndex == 0) ? Reservation.Sexe.Homme : Reservation.Sexe.Femme, DatetimeActuel.Value, dateTimeDebut.Value,
                                                dateTimeFin.Value, Convert.ToInt32(lblHotes.Text), new Chambre(), Convert.ToDouble(lblMontantVerse.Text), Convert.ToDouble(lblTotal.Text), false, 0, Convert.ToDouble(lblRestePayer.Text));
                                                listeTempon.Add(r);
                                                Reservations resa = new Reservations();
                                                resa.Ajouter(r, Convert.ToInt32(comboBoxNumLocal.Text));
                                                loadListView(new Chambres().Find(x => true).ToList());
                                                MessageBox.Show("La reservation a bien été crée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                lblEmail.Text = "";
                                                lblNom.Text = "";
                                                lblPrenom.Text = "";
                                                lblNumber.Text = "";
                                                lblPassport.Text = "";
                                                comboBoxNationalite.Text = "";
                                                lblProfession.Text = "";
                                                lblAdresse.Text = "";
                                                comboBoxSexe.Text = "";
                                                DatetimeActuel.Value = DateTime.Now;
                                                dateTimeDebut.Value = DateTime.Now;
                                                dateTimeFin.Value = DateTime.Now;
                                                lblHotes.Text = "";
                                                lblMontantVerse.Text = "";
                                                lblTotal.Text = "";
                                                comboBoxNumLocal.Text = "";
                                                lblRestePayer.Text = "";

                                            }
                                            catch (Exception)
                                            {
                                                MessageBox.Show("Bien vouloir entrer des valeurs Entiére dans les champs concernés", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                        else
                                        {
                                            try
                                            {
                                                new Reservations().modfifier(StatClient.selecteReservation, lblEmail.Text, lblNom.Text, lblPrenom.Text, long.Parse(lblNumber.Text),
                                                lblPassport.Text, comboBoxNationalite.Text, lblProfession.Text, lblAdresse.Text,
                                                (comboBoxSexe.SelectedIndex == 0) ? Reservation.Sexe.Homme : Reservation.Sexe.Femme, DatetimeActuel.Value, dateTimeDebut.Value,
                                                dateTimeFin.Value, Convert.ToInt32(lblHotes.Text), Convert.ToInt32(comboBoxNumLocal.Text), Convert.ToDouble(lblMontantVerse.Text), Convert.ToDouble(lblTotal.Text), Convert.ToDouble(lblRestePayer.Text));
                                                loadListView(new Chambres().Find(x => true).ToList());
                                                MessageBox.Show("La reservation a bien été modifiée", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                lblEmail.Text = "";
                                                lblNom.Text = "";
                                                lblPrenom.Text = "";
                                                lblNumber.Text = "";
                                                lblPassport.Text = "";
                                                comboBoxNationalite.Text = "";
                                                lblProfession.Text = "";
                                                lblAdresse.Text = "";
                                                comboBoxSexe.Text = "";
                                                DatetimeActuel.Value = DateTime.Now;
                                                dateTimeDebut.Value = DateTime.Now;
                                                dateTimeFin.Value = DateTime.Now;
                                                lblHotes.Text = "";
                                                lblMontantVerse.Text = "";
                                                lblTotal.Text = "";
                                                comboBoxNumLocal.Text = "";
                                                lblRestePayer.Text = "";
                                                StatClient.selecteReservation = null;
                                            }
                                            catch (Exception)
                                            {
                                                MessageBox.Show("Bien vouloir entrer des valeurs Entiére dans les champs concernés", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Le numero de telephone doit être mentionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Le montant totale ne peut pas être inférieur au montant versé !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("La date de fin est inferieur à la date de debut", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La date de debut est inferieur à la date d'enregistrement", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Le montant doit être obligatoirement être mentionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Le Prenom doit obligatoirement être mentionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Le Nom doit obligatoirement être mentionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblNumChambre.Text))
            {
                if (!string.IsNullOrWhiteSpace(comboBoxTypes.Text))
                {
                    if (!string.IsNullOrWhiteSpace(lblPrix.Text))
                    {

                        Chambres cam = new Chambres();
                        try
                        {
                            cam.ajouter(Convert.ToInt32(lblNumChambre.Text), Convert.ToInt32(lblNbrepiece.Text), Convert.ToDouble(lblPrix.Text), comboBoxTypes.Text);
                            MessageBox.Show("La chambre a été ajouté avec succés", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            materialRaisedButtonRefresh_Click(sender, e);
                            comboBoxNumLocal.Items.Clear();
                            addONcomboResa();
                        }
                        catch(Exception)
                        {
                            MessageBox.Show("Bien vouloir entrer des valeurs Entiére dans les champs concernés", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }  
                        
                    }
                    else
                    {
                        MessageBox.Show("Quel est le prix de votre chambre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vous devez mentionné le type de votre chambre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Le numero de chambre doit obligatoirement être mentionné", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewlocaux_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void materialRaisedButtonRefresh_Click(object sender, EventArgs e)
        {
            lblNumChambre.Text = "";
            lblNbrepiece.Text = "";
            lblPrix.Text = "";
            comboBoxTypes.Text = "";
            loadListView(new Chambres().Find(x => true).ToList());
        }

        private void materialRaisedButtonSuprimer_Click(object sender, EventArgs e)
        {
            if (dataGridViewlocaux.SelectedRows.Count > 0)
            {

                if(MessageBox.Show("êtes vous sur de bien vouloir supprimer cette ligne?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow c in dataGridViewlocaux.SelectedRows)
                    {
                        Chambre d = c.DataBoundItem as Chambre;
                        bool test = new Chambres().CheckUserIn(d.id_chambre);
                        if (test == false)
                        {
                            new Chambres().remove(d);
                            materialRaisedButtonRefresh_Click(sender, e);
                            MessageBox.Show(
                                "Supression effectué!",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                            
                        else
                            MessageBox.Show("Désolé, pour question de sécurité vous ne pouvez pas supprimer une chambre qui a déjà été attribué ! Bien vouloir le faire lorsqu'elle sera libre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    
                }
            }
            else
            {
                MessageBox.Show(
                    "Bien vouloir sélectionner une ligne à supprimer",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void dataGridViewlocaux_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewlocaux.SelectedRows.Count > 0)
            {
                Chambre d = dataGridViewlocaux.SelectedRows[0].DataBoundItem as Chambre;
                lblNumChambre.Text = d.NumChambre.ToString();
                lblNbrepiece.Text = d.NbreDePiece.ToString();
                lblPrix.Text = d.Prix.ToString();
                comboBoxTypes.Text = d.Type.Intitule.ToString();
                comboBoxState.Text = d.Status.ToString();
                comboBoxState.Hide();
                SelectedChambre = d;
            }
        }

        private void materialRaisedButtonModifier_Click(object sender, EventArgs e)
        {
            if (SelectedChambre == null)
            {
                MessageBox.Show(
                    "Bien vouloir doublecliquer sur la ligne à modifier !",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (SelectedChambre != null)
            {
                bool test = new Chambres().CheckUserIn(SelectedChambre.id_chambre);
                if (test==false)
                {
                    try
                    {
                        new Chambres().modify(SelectedChambre, SelectedChambre.id_chambre, Convert.ToInt32(lblNumChambre.Text), Convert.ToInt32(lblNbrepiece.Text), Convert.ToDouble(lblPrix.Text), comboBoxTypes.Text, comboBoxState.SelectedIndex);
                        MessageBox.Show(
                        "La chambre a été modifié avec succés",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        materialRaisedButtonRefresh_Click(sender, e);
                        lblNumChambre.Text = "";
                        lblNbrepiece.Text = "";
                        lblPrix.Text = "";
                        comboBoxTypes.Text = "";
                        comboBoxState.Show();
                        comboBoxState.Text = "";
                        SelectedChambre = null;

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bien vouloir entrer des valeurs Entiére dans les champs concernés", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Désolé, pour question de sécurité vous ne pouvez pas modifier un chambre qui a déjà été attribué ! Bien vouloir le faire lorsqu'elle sera libre.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblMontantVerse_Leave(object sender, EventArgs e)
        {
            try
            {
                double total = Convert.ToDouble(lblTotal.Text);
                double mv = Convert.ToDouble(lblMontantVerse.Text);
                lblRestePayer.Text = (total - mv).ToString();
            }
            catch (Exception)
            {

            }
            
        }

        private void materialRaisedButton9_Click(object sender, EventArgs e)
        {
            
            Home h = new Home();
            close = false;
            this.Hide();
            h.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (close == true)
            {
                Home h = new Home();
                this.Hide();
                h.Show();
            }
            
        }

        private void Types_de_chambres_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnulerType_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("êtes vous sur de bien vouloir supprimer cette (ces) ligne?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow c in dataGridView1.SelectedRows)
                    {
                        TypeChambre d = c.DataBoundItem as TypeChambre;
                        new TypesChambres().remove(d);
                    }
                    loadListView(new TypesChambres().Find(x => true).ToList());
                    MessageBox.Show(
                        "Supression effectué!",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    addONcomboType();
                }
            }
            else
            {
                MessageBox.Show(
                    "Bien vouloir sélectionner une ligne à supprimer",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (listeTempon != null && listeTempon.Count!=0)
            {
                List<ClasseFacture> l = new Factures().Transformer(listeTempon);
                foreach (ClasseFacture i in l)
                {
                    
                        if (MessageBox.Show("Imprimer la facture de monsieur " + i.NomF + " ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            List<ClasseFacture> c = new List<ClasseFacture>();
                            c.Add(i);
                            Facture f = new Facture(c, "scilagou20@yahoo.fr", 696205804d);
                            f.Show();
                            c.Clear();
                        }
                        else
                        {
                            l.Remove(i);
                            MessageBox.Show("La facture a bien été annulé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    
                }
                new Factures().AddFactures(l);
                listeTempon.Clear();
                //listeTempon = null;

            }
            else
            {
                MessageBox.Show(
                    "Vous n'avez pas de factures en mémoire",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
           
        }

        private void comboBoxNumLocal_SelectedValueChanged(object sender, EventArgs e)
        {
            int valeur = Convert.ToInt32(comboBoxNumLocal.Text);
            bool test = new Chambres().checkState(valeur);
            try
            {
                TimeSpan t = dateTimeFin.Value - dateTimeDebut.Value;
                int time = Convert.ToInt32(t.TotalDays);
                if (time >= 1)
                {
                    txtTYPE.Text = new Chambres().GetLocalType(Convert.ToInt32(comboBoxNumLocal.Text));
                    lblTotal.Text = (new Chambres().GetLocalMount(Convert.ToInt32(comboBoxNumLocal.Text)) * time).ToString();
                }
                else
                {
                    txtTYPE.Text = new Chambres().GetLocalType(Convert.ToInt32(comboBoxNumLocal.Text));
                    lblTotal.Text = (new Chambres().GetLocalMount(Convert.ToInt32(comboBoxNumLocal.Text))).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(
                   "Le numero de locale est mauvais ou n'existe pas !",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            if (test==true)
            {

                MessageBox.Show(
                   "Cette chambre est déja occupée",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblIntituleType.Text))
            {
                TypesChambres tc = new TypesChambres();
                tc.add(lblIntituleType.Text);
                loadListView(new TypesChambres().Find(x => true).ToList());
                MessageBox.Show("le type " + lblIntituleType.Text + " a été crée avec succés!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblIntituleType.Text = "";
                addONcomboType();
            }
        }

        private void btnActualiseResa_Click(object sender, EventArgs e)
        {
            lblEmail.Text = "";
            lblNom.Text = "";
            lblPrenom.Text = "";
            lblNumber.Text = "";
            lblPassport.Text = "";
            comboBoxNationalite.Text = "";
            lblProfession.Text = "";
            lblAdresse.Text = "";
            comboBoxSexe.Text = "";
            DatetimeActuel.Value = DateTime.Now;
            dateTimeDebut.Value = DateTime.Now;
            dateTimeFin.Value = DateTime.Now;
            lblHotes.Text = "";
            lblMontantVerse.Text = "";
            lblTotal.Text = "";
            comboBoxNumLocal.Text = "";
            lblRestePayer.Text = "";
        }
    }
}
