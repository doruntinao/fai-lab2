using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAI_lab2.Models
{
    public class Mirembajtja
    {
        public Mirembajtja() { }

        public int MirembajtjaID { get; set; }
        public int ProduktiID { get; set; }
        public DateTime DataMirembajtjes { get; set; }
        public string Pershkrimi { get; set; }
        public int PunetoriID { get; set; }
    }
}
