using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lena.BO
{
    public class TypeChambre
    {
        public int IdType { get; set; }
        public string Intitule { get; set; }

        public TypeChambre()
        {

        }
        public TypeChambre(int id_type, string intitule)
        {
            this.IdType = id_type;
            this.Intitule = intitule;
        }
        public override int GetHashCode()
        {
            return this.IdType.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return this.IdType.Equals((obj as TypeChambre)?.IdType);
        }
        public override string ToString()
        {
            return "Chambre de type " + this.Intitule;
        }
        
    }
}
