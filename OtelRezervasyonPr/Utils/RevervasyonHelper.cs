using OtelRezervasyonPr.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonPr.Utils
{
    class RezervasyonHelper
    {
       public static List<OtelSecimModel> OtelleriAra()
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                var a=c.Otel.ToList();
                var don = new List<OtelSecimModel>();
                foreach (var bb in a)
                {
                    var l = new OtelSecimModel();
                    l.Oda = bb.Oda;
                    l.OtelSehir = bb.OtelSehir;
                    l.OtelOzellik = bb.OtelOzellik;
                    l.OtelDurum = bb.OtelDurum;
                    l.OtelIlce = bb.OtelIlce;
                    l.OtelAdi = bb.OtelAdi;
                    l.OtelID = bb.OtelID;
                    don.Add(l);
                }
                return don;
            }
        }
        public static bool MusteriCud(Musteri musteri,EntityState entity)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                c.Entry(musteri).State = entity;
                return c.SaveChanges() > 0;
            }
        }
        public static bool RezervasyonCud(Rezervasyon rezervasyon, EntityState entity)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                c.Entry(rezervasyon).State = entity;
                return c.SaveChanges() > 0;
            }
        }
        public static int GetMusteriIDByEmail(string mail)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                return c.Musteri.Where(p => p.Email == mail).FirstOrDefault().MusteriID;
            }
        }

        internal static bool TarihArasıBosodalar(int odaID, DateTime giris, DateTime cikis)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                var rez=c.Rezervasyon.Where(p => p.OdaID == odaID).ToList();
                int sayac = 0;
                foreach (var item in rez)
                {
                    if (item.CikisTarihi.Day<giris.Day&&item.CikisTarihi.Day<cikis.Day || item.GirisTarihi.Day > giris.Day && item.GirisTarihi.Day > cikis.Day)
                    {
                        
                    }
                    else
                    {
                        sayac++;
                    }
                }
                return sayac == 0;
            }
        }
        public  static List<RezervasyonModel> GetAllRezervasyon()
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                var revList = new List<RezervasyonModel>();
               var a= c.Rezervasyon.ToList();
                foreach (var re in a)
                {
                    var reM = new RezervasyonModel { CikisTarihi = re.CikisTarihi, GirisTarihi = re.GirisTarihi, islemTarihi = re.islemTarihi, Musteri = re.Musteri, Oda = re.Oda, Otel = re.Otel, RezervasyonID = re.RezervasyonID };
                    revList.Add(reM);
                }
                return revList;
            }
        }
        public static RezervasyonModel GetAllRezervasyonByRevID(int rezId)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                var revList = new List<RezervasyonModel>();
                var a = c.Rezervasyon.Where(p => p.RezervasyonID == rezId).FirstOrDefault();
                
                    return new RezervasyonModel { CikisTarihi = a.CikisTarihi, GirisTarihi = a.GirisTarihi, islemTarihi = a.islemTarihi, Musteri = a.Musteri, Oda = a.Oda, Otel = a.Otel, RezervasyonID = a.RezervasyonID };
                  
            }
        }
        public static List<RezervasyonModel> RezervasyonFiltre(string neyeGöre, string text, DateTime giris, DateTime cıkıs,int sehir)
        {
            using (var c = new OtelRezarvasyonEntities())
            {
                if (neyeGöre == "musteri")
                {
                    return GetAllRezervasyon().Where(ce => ce.Musteri.MusteriAd.ToLower().StartsWith(text.ToLower())).ToList();
                }
                else if (neyeGöre == "otel")
                {
                    return GetAllRezervasyon().Where(ce => ce.Otel.OtelAdi.ToLower().StartsWith(text.ToLower())).ToList();
                }
                else if (neyeGöre == "sehir")
                {
                    return GetAllRezervasyon().Where(ce => ce.Otel.OtelSehir==sehir).ToList();
                }
                else
                {
                    return GetAllRezervasyon().Where(ce =>ce.GirisTarihi >= giris && ce.CikisTarihi <= cıkıs).ToList();
                }
            }
        }
    }
}
