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
    public class TypeChambreDAO : IList<TypeChambre>
    {
        private string SAVE_TYPE= @"Datas\TypeChambre.dat";
        private List<TypeChambre> liste = null;

        public TypeChambreDAO()
        {
            Formatter<List<TypeChambre>> Format = new Formatter<List<TypeChambre>>(SAVE_TYPE);
            liste = Format.DeserializeXML();

            if (liste == null)
            {
                liste = new List<TypeChambre>();
            }
        }

        public TypeChambre this[int index]
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
                    throw new Exception(string.Format(Resource.n_existe_dèja, "Le type"));
                }
                this.liste[index] = value;
                Formatter<List<TypeChambre>> f = new Formatter<List<TypeChambre>>(this.liste, SAVE_TYPE);
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

        public int getNextId()
        {
            return (liste?.LastOrDefault()?.IdType ?? 0) + 1;
        }

        public void Add(TypeChambre item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }

            if (this.liste.Contains(item))
            {
                throw new Exception(string.Format(Resource.n_existe_dèja, "Le type"));
            }

            this.liste.Add(item);
            Formatter<List<TypeChambre>> Format = new Formatter<List<TypeChambre>>(liste, SAVE_TYPE);
            Format.SerializeXml();
        }

        public void Clear()
        {
            this.liste.Clear();
        }

        public bool Contains(TypeChambre item)
        {
            return this.liste.Contains(item);
        }

        public bool Contains(Func<TypeChambre, bool> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException();
            }
            List<TypeChambre> li = Find(predicate).ToList();
            if (li.Count > 0 && li != null)
            {
                return true;
            }
            return false;
        }

        public IEnumerable<TypeChambre> Find(Func<TypeChambre, bool> predicate)
        {
            return this.liste.Where(predicate);
        }

        public TypeChambre FindById(int Id)
        {
            return this.liste.Where(x => x.IdType == Id).FirstOrDefault();
        }

        public void CopyTo(TypeChambre[] array, int arrayIndex)
        {
            this.liste.CopyTo(array, arrayIndex);
        }

        public IEnumerator<TypeChambre> GetEnumerator()
        {
            return this.liste.GetEnumerator();
        }

        public int IndexOf(TypeChambre item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            int i= this.liste.IndexOf(item);
            return this.liste.IndexOf(item);
        }

        public void Insert(int index, TypeChambre item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            if (this.liste.Contains(item))
            {
                throw new Exception(string.Format(Resource.n_existe_dèja, "Le type"));
            }
            this.liste.Insert(index, item);
            Formatter<List<TypeChambre>> fr = new Formatter<List<TypeChambre>>(liste, SAVE_TYPE);
            fr.SerializeXml();

        }

        public bool Remove(TypeChambre item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            int i = this.IndexOf(item);
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
                Formatter<List<TypeChambre>> fr = new Formatter<List<TypeChambre>>(liste, SAVE_TYPE);
                fr.SerializeXml();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
