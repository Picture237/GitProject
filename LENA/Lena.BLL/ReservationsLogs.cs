using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lena.DAL;
using Lena.BO;

namespace Lena.BLL
{
    public class ReservationsLogs
    {
        public List<Reservation> Recherche(DateTime d1,DateTime d2)
        {
            return new ReservationDAOLOG().Find(x => Convert.ToDateTime(x.DateDuJour.Day + "/" + x.DateDuJour.Month + "/" + x.DateDuJour.Year) >=
            Convert.ToDateTime(d1.Day + "/" + d1.Month + "/" + d1.Year) && Convert.ToDateTime(x.DateDuJour.Day + "/" + x.DateDuJour.Month + "/" + x.DateDuJour.Year) <=
             Convert.ToDateTime(d2.Day + "/" + d2.Month + "/" + d2.Year)).ToList(); 
        }

        public void add(Reservation r)
        {
            ReservationDAOLOG resa = new ReservationDAOLOG();
            resa.Add(r);
        }
    }
}
