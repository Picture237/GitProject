using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lena.BO
{
    public class Chambre
    {
        public enum state
        {
            Occupé,
            Libre
        }
        public int id_chambre { get; set; }
        public int NumChambre { get; set; }
        public int NbreDePiece { get; set; }
        public double Prix { get; set; }
        public TypeChambre Type;
        public string Intit { get; set; }
        public state Status { get; set; }


        public Chambre() { }

        public Chambre(int id_chambre, int numchambre, int nbrePiece, double prix, TypeChambre type,string intit,state status)
        {
            this.id_chambre = id_chambre;
            this.NumChambre = numchambre;
            this.NbreDePiece = nbrePiece;
            this.Prix = prix;
            this.Type = type;
            this.Intit = intit;
            this.Status = status;
        }

        public Chambre(Chambre c)
        {
            this.id_chambre = c.id_chambre;
            this.NumChambre = c.NumChambre;
            this.NbreDePiece = c.NbreDePiece;
            this.Prix = c.Prix;
            this.Type = c.Type;
            this.Intit = c.Intit;
            this.Status = c.Status;
        }

        public override int GetHashCode()
        {
            return this.id_chambre.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return this.id_chambre.Equals((obj as Chambre)?.id_chambre);
        }
        public override string ToString()
        {
            return "chambre numèro " + this.NumChambre;
        }
    }
}
