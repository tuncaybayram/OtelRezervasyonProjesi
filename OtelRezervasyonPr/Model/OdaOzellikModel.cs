using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonPr.Model
{
    class OdaOzellikModel
    {
        public int OdaOzellikID { get; set; }
        public int OdaID { get; set; }
        public int OzellikID { get; set; }
        public bool OzellikDurum { get; set; }
        public  Oda Oda { get; set; }
        public  Ozellik Ozellik { get; set; }
    }
}
