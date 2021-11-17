using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lena.DAL;
using Lena.BO;

namespace Lena.BLL
{
    public class Reservations
    {
        public void  Ajouter(Reservation r,int numCam)
        {
            ReservationDAO resaDAO = new ReservationDAO();
            if (r != null)
            {
                ChambreDAO typ = new ChambreDAO();
                Chambre c = typ.Find(x => x.NumChambre == numCam).FirstOrDefault();
                r.id_reservation = resaDAO.getNextId();
                r.chambre = c;
                r.NumChambre = c.NumChambre;
                r.chambre.Status = Chambre.state.Occupé;
                new Chambres().modify(r.chambre, r.chambre.id_chambre, r.chambre.NumChambre, r.chambre.NbreDePiece, r.chambre.Prix, r.chambre.Type.Intitule, Chambre.state.Occupé);
                r.id_reservation.ToString();
                resaDAO.Add(r);
                new ReservationsLogs().add(r);
            }
            else
            {
                throw new Exception("La reservation que vous voulez ajouter est null");
            }
        }

        public IEnumerable<Reservation> Find(Func<Reservation, bool> predicate)
        {
            return new ReservationDAO().Find(predicate);
        }

        public void remove(Reservation r)
        {
            ReservationDAO resa = new ReservationDAO();
            List<Chambre> cc = new ReservationDAO().Find(x => x.chambre.Equals(r.chambre)).Select(x => x.chambre).ToList();
            foreach(Chambre c in cc)
            {
                new Chambres().modify(c, c.id_chambre, c.NumChambre, c.NbreDePiece, c.Prix, c.Type.Intitule, Chambre.state.Libre);
            }
            resa.Remove(r);
        }

        public void modfifier(Reservation old,String Email, String Nom, String Prenom, long Number, String Cni, String Nationalite,
            String Profession, String Adresse,Reservation.Sexe sexe,DateTime DateActuel,DateTime dateDebut,DateTime dateFin,
            int nbHotes,int numchambre,double MontantVerse,double lTotal,double reste)
        {
            ChambreDAO typ = new ChambreDAO();
            Chambre c = typ.Find(x => x.NumChambre == numchambre).FirstOrDefault();
            Reservation r = new Reservation();
            new Chambres().modify(old.chambre, old.chambre.id_chambre, old.chambre.NumChambre, old.chambre.NbreDePiece, old.chambre.Prix, old.chambre.Type.Intitule, Chambre.state.Libre);
            new Chambres().modify(c, c.id_chambre, c.NumChambre, c.NbreDePiece, c.Prix, c.Type.Intitule, Chambre.state.Occupé);
            r.chambre = c;
            r.id_reservation = old.id_reservation;
            r.Email = Email;
            r.Nom = Nom;
            r.Prenom = Prenom;
            r.Numero = Number;
            r.NumCNI = Cni;
            r.Nationalite = Nationalite;
            r.Proffession = Profession;
            r.Adresse = Adresse;
            r.sexe = sexe;
            r.DateDuJour = DateActuel;
            r.DateDebut = dateDebut;
            r.DateFin = dateFin;
            r.nbrePersonne = nbHotes;
            r.Montant_verse = MontantVerse;
            r.Montant_Total = lTotal;
            r.MontantReste = reste;
            r.Status = old.Status;
            r.NumChambre = c.NumChambre;
            ReservationDAO resa = new ReservationDAO();
            ReservationDAOLOG resaLOG = new ReservationDAOLOG();
            int indexLOG = resaLOG.IndexOf(old);
            int index = resa.IndexOf(old);
            resa[index] = r;
            resaLOG[indexLOG] = r;
        }

        public void statusChange(Reservation old ,bool state)
        {
            Reservation re = new Reservation(old);
            re.Status = state;
            ReservationDAO resa = new ReservationDAO();
            ReservationDAOLOG resaLOG = new ReservationDAOLOG();
            int index = resa.IndexOf(old);
            int indexLOG = resaLOG.IndexOf(old);
            resa[index] = re;
            resaLOG[indexLOG] = re;
        }

        public bool CheckEndValidation()
        {
            List<Reservation> list = new List<Reservation>();
            list = new ReservationDAO().Find(x => x.DateFin.Equals(DateTime.Now)).ToList();
            if (list.Count == 0)
            {
                return false;
            }
            return true;
        }


    }
}
