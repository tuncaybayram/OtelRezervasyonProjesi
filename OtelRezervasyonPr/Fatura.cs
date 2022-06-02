using OtelRezervasyonPr.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonPr
{
    public partial class Fatura : Form
    {
        string fiyat;
        public Fatura()
        {
            InitializeComponent();
        }
        Rezervasyon _rezervasyon;
        public Fatura(Rezervasyon rezervasyon,string fiyat)
        {
            this.fiyat = fiyat;
            _rezervasyon = rezervasyon;
            InitializeComponent();
        }

        private void cıkısBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void anaSayfaBtn_Click(object sender, EventArgs e)
        {
            var x = new AnaEkran();
            this.Hide();
            x.Show();
        }

        private void Fatura_Load(object sender, EventArgs e)
        { var a=RezervasyonHelper.GetAllRezervasyonByRevID(_rezervasyon.RezervasyonID);
            faturaName.Text = a.Musteri.MusteriAd;
            faturaSoyad.Text = a.Musteri.MusteriSoyad;
            faturaTel.Text = a.Musteri.Tel;
            faturaMail.Text = a.Musteri.Email;
            faturaAdres.Text = a.Musteri.Adres;
            faturaOtel.Text = a.Otel.OtelAdi;
            faturaOda.Text = a.Otel.OtelID.ToString();
            faturaTarih.Text = a.islemTarihi.ToString();
            faturaTutar.Text = fiyat;
            //fiyat vedoa tipi
                
        }
    }
}
