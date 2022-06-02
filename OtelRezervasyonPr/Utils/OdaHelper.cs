using OtelRezervasyonPr.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonPr.Utils
{
    class OdaHelper
    {
        public static bool OdaCUD(Oda oda,EntityState entityState)
        {
            using(var c=new OtelRezarvasyonEntities())
            {
                c.Entry(oda).State = entityState;
                return c.SaveChanges() > 0;
            }
        }
        public static List<Oda> GetOdasByOtelID(int otelID)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                return c.Oda.Where(p => p.OtelID == otelID).ToList();
            }
        }
        public static List<Oda> GetOdasByOtelID(int otelID,string odaBoyut,bool odaDurum)
        { int durum = 0;
            
            if (odaBoyut== "AileOdası")
            {
                durum = 0;
            }
            else if (odaBoyut == "TekKisilik")
            {
                durum = 1;
            }
            else if (odaBoyut == "CiftKisilik")
            {
                durum = 2;
            }
            else if (odaBoyut == "Diger")
            {
                durum = 3;
            }
            using (var c = new OtelRezarvasyonEntities())
            {
                return c.Oda.Where(p => p.OtelID == otelID&&p.OdaDurum==odaDurum&&p.OdaBoyut==durum).ToList();
            }
        }
        public static Oda GetOdaByOdaID(int odaID)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                return c.Oda.Where(p => p.OdaID == odaID).FirstOrDefault();
            }
        }

    }
}
