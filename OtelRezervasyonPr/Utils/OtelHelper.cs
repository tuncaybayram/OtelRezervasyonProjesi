using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonPr.Utils
{
    class OtelHelper
    {

        public static bool OtelCUD(Otel otel, EntityState state)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                c.Entry(otel).State = state;
                return c.SaveChanges() > 0;
            }
        }
        public static List<Otel> GetOtels()
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                return c.Otel.ToList();
            }
        }
        public static List<Otel> GetOtelsBySehir(int sehirPlaka)
        {
            using (var c = new OtelRezarvasyonEntities())
            {

                return c.Otel.Where(x => x.OtelSehir == sehirPlaka).ToList();
            }

        }
        public static Otel GetOtelByOtelId(int otelId)
        {
            using (var c = new OtelRezarvasyonEntities())
            {

                return c.Otel.Where(x => x.OtelID == otelId).FirstOrDefault();
            }
        }
        public static List<int> GetMinOdaFiyatByOtelId(int otelId)
        {
            List<int> fiyatlar = new List<int>();
            using (var c = new OtelRezarvasyonEntities())
            {

                var t = c.Oda.Where(x => x.OtelID == otelId).ToList();
                foreach (var item in t)
                {
                    fiyatlar.Add(item.OdaFiyat);
                }


                if (fiyatlar.Count < 1)
                {
                    fiyatlar.Add(0);
                    return fiyatlar;
                }
                else
                {
                    return fiyatlar;
                }
            }
        }
        public static List<int> GetMinOdaFiyatByOtelId(int otelId,int odatip)
        {
            List<int> fiyatlar = new List<int>();
            using (var c = new OtelRezarvasyonEntities())
            {

                var t = c.Oda.Where(x => x.OtelID == otelId&&x.OdaBoyut==odatip).ToList();
                foreach (var item in t)
                {
                    fiyatlar.Add(item.OdaFiyat);
                }


                if (fiyatlar.Count < 1)
                {
                    fiyatlar.Add(0);
                    return fiyatlar;
                }
                else
                {
                    return fiyatlar;
                }
            }
        }
    }
}
