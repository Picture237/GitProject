using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lena.BO
{
    public class Reservation
    {
        public enum Sexe
        {
            Homme,
            Femme
        }
        public int id_reservation { get; set; }
        public string Email { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public long Numero { get; set; }
        public string NumCNI { get; set; }
        public string Nationalite { get; set; }
        public string Proffession { get; set; }
        public string Adresse { get; set; }
        public Sexe sexe { get; set; }
        public DateTime DateDuJour { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int nbrePersonne { get; set; }
        public Chambre chambre;
        public bool Status { get; set; }
        public double Montant_verse { get; set; }
        public double Montant_Total { get; set; }
        public int NumChambre { get; set; }
        public double MontantReste { get; set; }

        public Reservation() { }

        public Reservation(int id_reservation, string email, string nom, string prenom, long numero, string numcni, string nationalite, string profession, string adresse,
            Sexe sexe, DateTime datedujour, DateTime datedebut, DateTime datefin, int nbrepersonne, Chambre chambre, double montant_verse,double Montant_Total,bool status,int numlocal,double reste)
        {
            this.id_reservation = id_reservation;
            this.Email = email;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Numero = numero;
            this.NumCNI = numcni;
            this.Nationalite = nationalite;
            this.Proffession = profession;
            this.Adresse = adresse;
            this.sexe = sexe;
            this.DateDuJour = datedujour;
            this.DateDebut = datedebut;
            this.DateFin = datefin;
            this.nbrePersonne = nbrepersonne;
            this.chambre = chambre;
            this.Montant_verse = montant_verse;
            this.Montant_Total = Montant_Total;
            this.Status = status;
            this.NumChambre = numlocal;
            this.MontantReste = reste;
        }

        public Reservation(Reservation r)
        {
            this.id_reservation = r.id_reservation;
            this.Email = r.Email;
            this.Nom = r.Nom;
            this.Prenom = r.Prenom;
            this.Numero = r.Numero;
            this.NumCNI = r.NumCNI;
            this.Nationalite = r.Nationalite;
            this.Proffession = r.Proffession;
            this.Adresse = r.Adresse;
            this.sexe = r.sexe;
            this.DateDuJour = r.DateDuJour;
            this.DateDebut = r.DateDebut;
            this.DateFin = r.DateFin;
            this.nbrePersonne = r.nbrePersonne;
            this.chambre = r.chambre;
            this.Montant_verse = r.Montant_verse;
            this.Montant_Total = r.Montant_Total;
            this.Status = r.Status;
            this.NumChambre = r.NumChambre;
            this.MontantReste = r.MontantReste;
        }

        public override int GetHashCode()
        {
            return this.id_reservation.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.id_reservation.Equals((obj as Reservation)?.id_reservation);
        }

        public override string ToString()
        {
            return this.DateDebut + " " + this.DateFin + " " + nbrePersonne;
        }
    }
}
