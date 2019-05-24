using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Produkti
    {
        public Produkti() { }

        public int ProduktiID { get; set; }
        public string Emri { get; set; }
        public string Pershkrimi { get; set; }
        public string Prodhuesi { get; set; }
        public string Modeli { get; set; }
        public int Jetegjatesia { get; set; }
        public Boolean Asset { get; set; }
        public int Sasia { get; set; }
        public int Grupi { get; set; }
        public Boolean Statusi { get; set; }
        public int salvageValue { get; set; }

    }
}
