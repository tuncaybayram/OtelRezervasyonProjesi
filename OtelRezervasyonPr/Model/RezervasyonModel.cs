using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonPr.Model
{
    class RezervasyonModel
    {
        public int RezervasyonID { get; set; }
        public int MusteriID { get; set; }
        public System.DateTime GirisTarihi { get; set; }
        public System.DateTime CikisTarihi { get; set; }
        public int OtelID { get; set; }
        public int OdaID { get; set; }
        public Nullable<System.DateTime> islemTarihi { get; set; }

        public virtual Musteri Musteri { get; set; }
        public virtual Oda Oda { get; set; }
        public virtual Otel Otel { get; set; }
    }
}
