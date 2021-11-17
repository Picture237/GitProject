using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lena.BO
{
    public class ClasseFacture
    {
        public DateTime Date_arriveF { get; set; }
        public DateTime Date_DepartF{ get; set; }
        public int Duree_sejourF { get; set; }
        public double Montant_totalF { get; set; }
        public double Reste_a_payer { get; set; }
        public double Prix_Unitaire { get; set; }
        public string NomF { get; set; }
        public string ProfessionF { get; set; }
        public int Id { get; set; }
        public string IdShow { get; set; }

        public ClasseFacture() { }

        public ClasseFacture( int id,string nomF, double reste_a_payer,DateTime date_arriveF, DateTime date_DepartF,  int duree_sejourF,  double montant_totalF, double prix_Unitaire,string professionF,string Idshow)
        {
            this.Id =id;
            this.IdShow = Idshow;
            this.NomF = nomF;
            this.Date_arriveF = date_arriveF;
            this.Date_DepartF = date_DepartF;
            this.Duree_sejourF = duree_sejourF;
            this.Montant_totalF = montant_totalF;
            this.Prix_Unitaire = prix_Unitaire;
            this.ProfessionF = professionF;
            this.Reste_a_payer = reste_a_payer;
        }

        public ClasseFacture(ClasseFacture r)
        {
            this.Id = r.Id;
            this.IdShow = r.IdShow;
            this.NomF = r.NomF;
            this.Date_arriveF = r.Date_arriveF;
            this.Date_DepartF = r.Date_DepartF;
            this.Duree_sejourF = r.Duree_sejourF;
            this.Montant_totalF = r.Montant_totalF;
            this.Prix_Unitaire = r.Prix_Unitaire;
            this.ProfessionF = r.ProfessionF;
            this.Reste_a_payer = r.Reste_a_payer;
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this.Id.Equals((obj as ClasseFacture)?.Id);
        }
        public override string ToString()
        {
            return "Facture de " + this.NomF;
        }
    }
}
