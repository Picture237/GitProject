using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lena.DAL;
using Lena.BO;

namespace Lena.BLL
{
    public class Factures
    {
        public List<ClasseFacture> Transformer(List<Reservation> listResa)
        {
            List<ClasseFacture> listefacture = new List<ClasseFacture>();
            foreach (var i in listResa)
            {
                ClasseFacture cf = new ClasseFacture();
                cf.Date_arriveF = i.DateDebut;
                cf.Date_DepartF = i.DateFin;
                cf.Montant_totalF = i.Montant_Total;
                cf.NomF = i.Nom;
                cf.Prix_Unitaire = i.Montant_verse;
                cf.ProfessionF = i.Proffession;
                cf.IdShow = "Lena" + cf.Id + DateTime.Now.Year;
                TimeSpan t = cf.Date_DepartF - cf.Date_arriveF;
                cf.Duree_sejourF = Convert.ToInt32(t.TotalDays);
                listefacture.Add(cf);
            }
            return listefacture;
        }

        public void AddFactures(List<ClasseFacture> liste)
        {
            FactureDAO f = new FactureDAO();
            f.Add(liste);
        }

        public List<ClasseFacture> findByPersonne(string chaine)
        {
            return new FactureDAO().Find(x => x.NomF == chaine).ToList();
        }

        public IEnumerable<ClasseFacture> Find(Func<ClasseFacture, bool> predicate)
        {
            return new FactureDAO().Find(predicate);
        }
    }
}
