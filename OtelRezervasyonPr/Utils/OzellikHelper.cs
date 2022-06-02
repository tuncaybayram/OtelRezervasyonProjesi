using OtelRezervasyonPr.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonPr.Utils
{
    class OzellikHelper
    {
        public static bool Ekle(string tur, string Ozellik)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                var y = new Ozellik();
                if (tur == "oda")
                {
                    y.OzellikTip = 1;
                }
                else if (tur == "otel")
                {
                    y.OzellikTip = 0;
                }
                y.OzellikAd = Ozellik;
                c.Entry(y).State = System.Data.Entity.EntityState.Added;
                return c.SaveChanges() > 0;
            }
        }
        public static OtelOzellik GetOtelOzellikByOzellikAd(string ad)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                return c.OtelOzellik.Where(x => x.Ozellik.OzellikAd == ad).FirstOrDefault();
            }
        }
        public static OdaOzellik GetOdaOzellikByOzellikAd(string ad)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                return c.OdaOzellik.Where(x => x.Ozellik.OzellikAd == ad).FirstOrDefault();
            }
        }
        public static Ozellik GetOzellikByOzellikAd(string ad)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                return c.Ozellik.Where(x => x.OzellikAd == ad).FirstOrDefault();
            }
        }
        public static List<Ozellik> GetOzellikOtel()
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                return c.Ozellik.Where(x => x.OzellikTip == 0).ToList();
            }
        }
        public static List<Ozellik> GetOzellikOda()
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                return c.Ozellik.Where(x => x.OzellikTip == 1).ToList();
            }
        }
        public static List<OdaOzellikModel> GetOzelliksOdaByOdaID(int OdaId)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                var x = c.OdaOzellik.Where(p => p.OdaID == OdaId).ToList();
                List<OdaOzellikModel> k = new List<OdaOzellikModel>();
                foreach (var item in x)
                {
                    var y = new OdaOzellikModel();
                    y.Ozellik = item.Ozellik;
                    y.OdaID = item.OdaID;
                    y.OzellikID = item.OzellikID;
                    y.OzellikDurum = item.OzellikDurum;
                    y.OdaOzellikID = item.OdaOzellikID;
                    k.Add(y);
                }
                return k;
            }
        }
        public static List<Ozellik> GetAllOzellik()
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                return c.Ozellik.ToList();
            }
        }
        public static List<string> GetOzellikNamesByOtelID(int ıd)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                var a = c.OtelOzellik.Where(p => p.OtelID == ıd).ToList();
                var modelList = new List<string>();
                foreach (var item in a)
                {
                    modelList.Add(item.Ozellik.OzellikAd);
                }
                if (modelList==null)
                {
                        modelList.Add("Özellik Yok");
                    return modelList;
                }
                else
                return modelList;
            }
        }
        public static Ozellik GetOzellikByOzelilkAd(string OzellikAd)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                return c.Ozellik.Where(x => x.OzellikAd == OzellikAd).FirstOrDefault();
            }
        }


        public static bool OtelOzellikCud(OtelOzellik otelOzellik, EntityState entityState)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                c.Entry(otelOzellik).State = entityState;
                return c.SaveChanges() > 0;
            }
        }
        public static bool OdaOzellikCud(OdaOzellik odaOzellik, EntityState entityState)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                c.Entry(odaOzellik).State = entityState;
                return c.SaveChanges() > 0;
            }
        }



        public static List<OdaOzellikModel> GetOdaOzellikByOdaID(int odaId)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                var a = c.OdaOzellik.Where(x => x.OdaID == odaId).ToList();
                var modelList = new List<OdaOzellikModel>();
                foreach (var item in a)
                {
                    OdaOzellikModel model = new OdaOzellikModel();
                    model.OzellikDurum = item.OzellikDurum;
                    model.Ozellik = item.Ozellik;
                    model.Oda = item.Oda;
                    model.OdaOzellikID = item.OdaOzellikID;
                    
                    modelList.Add(model);
                }
                return modelList;
            }
        }

        public static List<OtelOzellikModel> GetOtelOzellikByOtelID(int OtelId)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                var a = c.OtelOzellik.Where(x => x.OtelID == OtelId).ToList();
                var modelList = new List<OtelOzellikModel>();
                foreach (var item in a)
                {
                    OtelOzellikModel model = new OtelOzellikModel();
                    model.OzellikDurum = item.OzellikDurum;
                    model.Ozellik = item.Ozellik;
                    model.Otel = item.Otel;
                    model.OtelOzellikID = item.OtelOzellikID;
                    modelList.Add(model);
                }
                return modelList;
            }
        }

         public static bool OdadaBuOzellikVar(int odaID, string text)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
               return c.OdaOzellik.Where(p => p.Ozellik.OzellikAd == text&&p.OdaID==odaID).FirstOrDefault()==null;
            }

        }
    }
}
