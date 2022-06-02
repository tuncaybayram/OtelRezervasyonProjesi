using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonPr.Model
{
    class OtelOzellikModel
    {
        public int OtelOzellikID { get; set; }
        public int OtelID { get; set; }
        public int OzellikID { get; set; }
        public bool OzellikDurum { get; set; }
        public  Ozellik Ozellik { get; set; }
        public  Otel Otel { get; set; }
    }
}
