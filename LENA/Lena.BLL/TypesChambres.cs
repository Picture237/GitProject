using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lena.DAL;
using Lena.BO;

namespace Lena.BLL
{
    public class TypesChambres
    {
        public void addType(TypeChambre type)
        {
            TypeChambreDAO tp = new TypeChambreDAO();
            tp.Add(type);
        }

        public void add(string intitule)
        {
            TypeChambreDAO tp = new TypeChambreDAO();
            if (!string.IsNullOrEmpty(intitule))
            {
                tp.Add(new TypeChambre(new TypeChambreDAO().getNextId(), intitule));
            }
        }
        public IEnumerable<TypeChambre> Find(Func<TypeChambre, bool> predicate)
        {
            return new TypeChambreDAO().Find(predicate);
        }

        public bool remove(TypeChambre tc)
        {
            TypeChambreDAO typ = new TypeChambreDAO();
            if (typ.Remove(tc))
            {
                return true;
            }
            return false;
        }
    }
}
