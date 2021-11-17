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
    public class ChambreDAO : IList<Chambre>
    {
        private string SAVE_CHAMBRE = @"Datas\Chambre.dat";
        private List<Chambre> liste = null;

        public ChambreDAO()
        {
            Formatter<List<Chambre>> Format = new Formatter<List<Chambre>>(SAVE_CHAMBRE);
            liste = Format.DeserializeXML();

            if (liste == null)
            {
                liste = new List<Chambre>();
            }
        }

        public int getNextId()
        {
            return (liste?.LastOrDefault()?.id_chambre ?? 0) + 1;
        }

        public Chambre this[int index]
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
                    throw new Exception(string.Format(Resource.n_existe_dèja, "La chambre"));
                }
                this.liste[index] = value;
                Formatter<List<Chambre>> f = new Formatter<List<Chambre>>(this.liste, SAVE_CHAMBRE);
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

        public void Add(Chambre item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }

            if (this.liste.Contains(item))
            {
                throw new Exception(string.Format(Resource.n_existe_dèja, "La chambre"));
            }

            this.liste.Add(item);
            Formatter<List<Chambre>> Format = new Formatter<List<Chambre>>(liste, SAVE_CHAMBRE);
            Format.SerializeXml();
        }

        public void Clear()
        {
            this.liste.Clear();
        }

        public bool Contains(Chambre item)
        {
            return this.liste.Contains(item);
        }

        public bool Contains(Func<Chambre, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException();
            }
            List<Chambre> li = Find(predicate).ToList();
            if (li.Count > 0 && li != null)
            {
                return true;
            }
            return false;
        }

        public IEnumerable<Chambre> Find(Func<Chambre, bool> predicate)
        {
            return this.liste.Where(predicate);
        }

        public Chambre FindById(int Id)
        {
            return this.liste.Where(x => x.id_chambre == Id).FirstOrDefault();
        }

        public void CopyTo(Chambre[] array, int arrayIndex)
        {
            this.liste.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Chambre> GetEnumerator()
        {
            return this.liste.GetEnumerator();
        }

        public int IndexOf(Chambre item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            return this.liste.IndexOf(item);
        }

        public void Insert(int index, Chambre item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            if (this.liste.Contains(item))
            {
                throw new Exception(string.Format(Resource.n_existe_dèja, "La chambre"));
            }
            this.liste.Insert(index, item);
            Formatter<List<Chambre>> fr = new Formatter<List<Chambre>>(liste, SAVE_CHAMBRE);
            fr.SerializeXml();

        }

        public bool Remove(Chambre item)
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
                Formatter<List<Chambre>> fr = new Formatter<List<Chambre>>(liste, SAVE_CHAMBRE);
                fr.SerializeXml();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
