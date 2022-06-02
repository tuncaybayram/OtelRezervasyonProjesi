using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonPr.Model
{
    class OtelSecimModel
    {
        public int OtelID { get; set; }
        public string OtelAdi { get; set; }
        public int OtelSehir { get; set; }
        public string OtelIlce { get; set; }
        public bool OtelDurum { get; set; }

     
        public virtual ICollection<Rezervasyon> Rezervasyon { get; set; }
        
        public virtual ICollection<OtelOzellik> OtelOzellik { get; set; }
        
        public virtual ICollection<Oda> Oda { get; set; }
    }
}
