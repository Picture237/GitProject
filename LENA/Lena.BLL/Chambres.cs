using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lena.DAL;
using Lena.BO;

namespace Lena.BLL
{
    public class Chambres
    {
        public void ajouter(int Numchambre,int nbrePiece,double prix ,string type)
        {
            ChambreDAO chambre = new ChambreDAO();
            TypeChambreDAO typ = new TypeChambreDAO();
            TypeChambre tc = typ.Find(x => x.Intitule == type).FirstOrDefault();
            chambre.Add(new Chambre(chambre.getNextId(), Numchambre, nbrePiece, prix, tc,tc.Intitule,Chambre.state.Libre));
        }

        public IEnumerable<Chambre> Find(Func<Chambre, bool> predicate)
        {
            return new ChambreDAO().Find(predicate);
        }

        public void remove(Chambre c)
        {
            ChambreDAO cam = new ChambreDAO();
            cam.Remove(c);
        }
        public void modify(Chambre old,int id,int numChambre,int nbpiece,double prix,string type,int etat)
        {
            ChambreDAO chambre = new ChambreDAO();
            TypeChambreDAO typ = new TypeChambreDAO();
            TypeChambre tc = typ.Find(x => x.Intitule == type).FirstOrDefault();
            Chambre di = new Chambre(
                id,
                numChambre,
                nbpiece,
                prix,
                tc,
                tc.Intitule
                ,(etat==0)?Chambre.state.Occupé:Chambre.state.Libre);
            int index = chambre.IndexOf(old);
            chambre[index] = di;
        }

        public void modify(Chambre old, int id, int numChambre, int nbpiece, double prix, string type, Chambre.state etat)
        {
            ChambreDAO chambre = new ChambreDAO();
            TypeChambreDAO typ = new TypeChambreDAO();
            TypeChambre tc = typ.Find(x => x.Intitule == type).FirstOrDefault();
            Chambre di = new Chambre(
                id,
                numChambre,
                nbpiece,
                prix,
                tc,
                tc.Intitule
                , etat);
            int index = chambre.IndexOf(old);
            chambre[index] = di;
        }

        public bool checkState(int number)
        {
            Chambre c = new ChambreDAO().Find(x => x.NumChambre == number).FirstOrDefault();
            
            if(c!=null && c.Status==Chambre.state.Occupé)
            {
                return true;
            }
            return false;
        }

        public bool CheckUserIn(int num)
        {
            List<Reservation> all = new ReservationDAO().Find(x => x.chambre.id_chambre == num).ToList();
            if (all.Count>0)
            {
                return true;
            }
            return false;
        }

        public double GetLocalMount(int numLocal)
        {
            return new ChambreDAO().Find(x => x.NumChambre.Equals(numLocal)).Select(x => x.Prix).FirstOrDefault();
        }

        public string GetLocalType(int numLocal)
        {
            return new ChambreDAO().Find(x => x.NumChambre.Equals(numLocal)).Select(x => x.Type.Intitule).FirstOrDefault();
        }
    }
}
