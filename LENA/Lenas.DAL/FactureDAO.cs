using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lena.BO;
using System.Collections;
using Coffre_Fort;

namespace Lena.DAL
{
    public class FactureDAO : IList<ClasseFacture>
    {
        private string SAVE_CHAMBRE = @"Datas\Factures.dat";
        private List<ClasseFacture> liste = null;

        public FactureDAO()
        {
            Formatter<List<ClasseFacture>> Format = new Formatter<List<ClasseFacture>>(SAVE_CHAMBRE);
            liste = Format.DeserializeXML();

            if (liste == null)
            {
                liste = new List<ClasseFacture>();
            }
        }

        public int getNextId()
        {
            return (liste?.LastOrDefault()?.Id ?? 100) + 1;
        }

        public ClasseFacture this[int index]
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
                    throw new Exception(string.Format(Resource.n_existe_dèja, "La Facture"));
                }
                this.liste[index] = value;
                Formatter<List<ClasseFacture>> f = new Formatter<List<ClasseFacture>>(this.liste, SAVE_CHAMBRE);
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

        public void Add(ClasseFacture item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }

            if (this.liste.Contains(item))
            {
                throw new Exception(string.Format(Resource.n_existe_dèja, "La Facture"));
            }

            this.liste.Add(item);
            Formatter<List<ClasseFacture>> Format = new Formatter<List<ClasseFacture>>(liste, SAVE_CHAMBRE);
            Format.SerializeXml();
        }

        public void Add(List<ClasseFacture> item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            item = Clean(item);
            foreach (var i in item)
            {
                this.liste.Add(i);
            }
            Formatter<List<ClasseFacture>> Format = new Formatter<List<ClasseFacture>>(liste, SAVE_CHAMBRE);
            Format.SerializeXml();
        }
        public void Clear()
        {
            this.liste.Clear();
        }

        public bool Contains(ClasseFacture item)
        {
            return this.liste.Contains(item);
        }

        public List<ClasseFacture> Clean(List<ClasseFacture> item)
        {
            foreach(var i in item)
            {
                if (this.liste.Contains(i))
                {
                    item.Remove(i);
                    continue;
                }
            }
            return item;
        }

        public bool Contains(Func<ClasseFacture, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException();
            }
            List<ClasseFacture> li = Find(predicate).ToList();
            if (li.Count > 0 && li != null)
            {
                return true;
            }
            return false;
        }

        public IEnumerable<ClasseFacture> Find(Func<ClasseFacture, bool> predicate)
        {
            return this.liste.Where(predicate);
        }

        public ClasseFacture FindById(int Id)
        {
            return this.liste.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void CopyTo(ClasseFacture[] array, int arrayIndex)
        {
            this.liste.CopyTo(array, arrayIndex);
        }

        public IEnumerator<ClasseFacture> GetEnumerator()
        {
            return this.liste.GetEnumerator();
        }

        public int IndexOf(ClasseFacture item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            return this.liste.IndexOf(item);
        }

        public void Insert(int index, ClasseFacture item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            if (this.liste.Contains(item))
            {
                throw new Exception(string.Format(Resource.n_existe_dèja, "La Facture"));
            }
            this.liste.Insert(index, item);
            Formatter<List<ClasseFacture>> fr = new Formatter<List<ClasseFacture>>(liste, SAVE_CHAMBRE);
            fr.SerializeXml();

        }

        public bool Remove(ClasseFacture item)
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
                Formatter<List<ClasseFacture>> fr = new Formatter<List<ClasseFacture>>(liste, SAVE_CHAMBRE);
                fr.SerializeXml();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
