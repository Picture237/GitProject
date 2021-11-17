using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lena.BO;
using Coffre_Fort;

namespace Lena.DAL
{
    public class ReservationDAO : IList<Reservation>
    {
        private string SAVE_RESERVATION = @"Datas\Reservations.dat";

        public List<Reservation> liste = null;

        public ReservationDAO()
        {
            Formatter <List<Reservation>> Format = new Formatter<List<Reservation>>(SAVE_RESERVATION);
            liste = Format.DeserializeXML();

            if (liste==null)
            {
                liste = new List<Reservation>();
            }
        }
        public int getNextId()
        {
            return (liste?.LastOrDefault()?.id_reservation ?? 0) + 1;
        }

        public Reservation this[int index]
        {
            get
            {
                return this[index];
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                int i = this.IndexOf(value);
                if (i >= 0 && i != index)
                {
                    throw new Exception(string.Format(Resource.n_existe_dèja, "La reservation"));
                }
                this.liste[index] = value;
                Formatter<List<Reservation>> f = new Formatter<List<Reservation>>(this.liste, SAVE_RESERVATION);
                f.SerializeXml();
            }
        }

        public int Count
        {
            get
            {
                return this.liste.Count();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(Reservation item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }

            if (this.liste.Contains(item))
            {
                throw new Exception(string.Format(Resource.n_existe_dèja, "La reservation"));
            }

            this.liste.Add(item);
            Formatter<List<Reservation>> Format = new Formatter<List<Reservation>>(liste,SAVE_RESERVATION);
            Format.SerializeXml();
        }

        public void Clear()
        {
            this.liste.Clear();
        }

        public bool Contains(Reservation item)
        {
            return this.liste.Contains(item);
        }

        public bool Contains(Func<Reservation,bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException();
            }
            List<Reservation> li = Find(predicate).ToList();
            if (li.Count > 0 && li != null)
            {
                return true;
            }
            return false;
        }

        public IEnumerable<Reservation> Find(Func<Reservation,bool> predicate)
        {
            return this.liste.Where(predicate);
        }

        public Reservation FindById(int Id)
        {
            return this.liste.Where(x => x.id_reservation == Id).FirstOrDefault();
        }

        public void CopyTo(Reservation[] array, int arrayIndex)
        {
            this.liste.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Reservation> GetEnumerator()
        {
            return this.liste.GetEnumerator();
        }

        public int IndexOf(Reservation item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            return this.liste.IndexOf(item);
        }

        public void Insert(int index, Reservation item)
        {
            if(item == null)
            {
                throw new ArgumentNullException();
            }
            if (this.liste.Contains(item))
            {
                throw new Exception(string.Format(Resource.n_existe_dèja, "La reservation"));
            }
            this.liste.Insert(index, item);
            Formatter<List<Reservation>> fr = new Formatter<List<Reservation>>(liste, SAVE_RESERVATION);
            fr.SerializeXml();

        }

        public bool Remove(Reservation item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            int i = IndexOf(item);
            if (i >= 0)
            {
                this.RemoveAt(i);
                return true;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            if (index >= 0)
            {
                this.liste.RemoveAt(index);
                Formatter<List<Reservation>> fr = new Formatter<List<Reservation>>(liste, SAVE_RESERVATION);
                fr.SerializeXml();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
