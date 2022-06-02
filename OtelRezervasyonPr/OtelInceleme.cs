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
    public partial class OtelInceleme : Form
    {
        int sayac = 0;
        public OtelInceleme()
        {
            InitializeComponent();
        }
        public Rezervasyon _rezervasyon;

        public OtelInceleme(Rezervasyon rezervasyon)
        {
            _rezervasyon = rezervasyon;
            InitializeComponent();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = new AnaEkran();
            this.Hide();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = new OdemeEkranı(_rezervasyon, OdaFiyat.Text);
            this.Hide();
            x.Show();
        }

        private void OtelInceleme_Load(object sender, EventArgs e)
        {
            string tip = "";
            if (OdaHelper.GetOdaByOdaID(_rezervasyon.OdaID).OdaBoyut==0)
            {
                tip = "Aile Odası";
            }
            else if (OdaHelper.GetOdaByOdaID(_rezervasyon.OdaID).OdaBoyut == 1)
            {
                tip = "Tek Kişilik Oda";
            }
            else if (OdaHelper.GetOdaByOdaID(_rezervasyon.OdaID).OdaBoyut == 2)
            {
                tip = "Çift Kişilik Oda";
            }
            else
            {
                tip = "Diğer Tip Oda";
            }
            int gün = _rezervasyon.CikisTarihi.Day - _rezervasyon.GirisTarihi.Day;
            if (gün==0)
            {
                gün = 1;
            }
            otelNameShow.Text = OtelHelper.GetOtelByOtelId(_rezervasyon.OtelID).OtelAdi;
            ozetLabel.Text = $"{_rezervasyon.OdaID} numaralı {tip}'nıza toplam {gün} gün boyunca{otelNameShow.Text}'de konaklama ücreti=";
            OdaFiyat.Text = (OdaHelper.GetOdaByOdaID(_rezervasyon.OdaID).OdaFiyat *gün).ToString()+"TL";
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            if (sayac==0)
            {
                pictureBox1.Image = Properties.Resources.salon;
                sayac++;
            }
            else if (sayac==1)
            {
                pictureBox1.Image = Properties.Resources.yemek;
                sayac++;
            }
            else
            {
                sayac = 0;
                pictureBox1.Image = Properties.Resources.yatak;
            }
        }

        private void picPrev_Click(object sender, EventArgs e)
        {
            if (sayac == 0)
            {
                pictureBox1.Image = Properties.Resources.salon;
                sayac--;
            }
            else if (sayac == 1)
            {
                pictureBox1.Image = Properties.Resources.yemek;
                sayac--;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.yatak;
                sayac = 1;
            }
        }
    }
}
