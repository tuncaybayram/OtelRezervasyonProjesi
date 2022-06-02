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
using static OtelRezervasyonPr.Enumlar.OtelEnum;

namespace OtelRezervasyonPr
{
    public partial class OdemeEkranı : Form
    {
        public OdemeEkranı()
        {
            InitializeComponent();
        }
        Rezervasyon _rezervasyon;
        string _odaFiyat;
        public OdemeEkranı(Rezervasyon rezervasyon,string OdaFiyat)
        {
            _rezervasyon = rezervasyon;
            _odaFiyat = OdaFiyat;
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (newName.TextLength>0&&newSurname.TextLength > 0&&maskedTextBox3.TextLength>9&& cinsBox.SelectedIndex>-1 && newAdres.TextLength > 0&&newMail.TextLength > 0&&textBox1.TextLength > 0 )
            {
                Musteri must = new Musteri();
                must.MusteriAd = newName.Text;
                must.MusteriSoyad = newSurname.Text;
                must.MusteriDTarih = dogumPck.Value.Date;
                must.Tel = maskedTextBox3.Text.ToString();
                must.Adres = newAdres.Text;
                must.Email = newMail.Text;
                must.Cinsiyet = cinsBox.SelectedIndex;
               
                if (!(RezervasyonHelper.GetMusteriIDByEmail(newMail.Text)>=1))
                {
                    RezervasyonHelper.MusteriCud(must, System.Data.Entity.EntityState.Added);
                }
                else
                {
                    must.MusteriID = RezervasyonHelper.GetMusteriIDByEmail(newMail.Text);
                    RezervasyonHelper.MusteriCud(must, System.Data.Entity.EntityState.Modified);
                    MessageBox.Show("Daha önceden kayıtlı olduğunuz için müşteri bilgileri güncellendi !");
                }


                _rezervasyon.MusteriID = must.MusteriID;
                _rezervasyon.islemTarihi = DateTime.Now;
               var a= RezervasyonHelper.RezervasyonCud(_rezervasyon, System.Data.Entity.EntityState.Added);
                if (a)
                {
                    MessageBox.Show("Odanız başarı ile rezerve edilmiştir\nFatura sayfasına gitmek için tıklayın");
                }

            
            var x = new Fatura(_rezervasyon,fiyattext.Text);
            this.Hide();
            x.Show();
            }
            else
            {
                MessageBox.Show("Girdiğiniz değerleri kontrol edin");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var x = new OtelInceleme(_rezervasyon);
            this.Hide();
            x.Show();
        }
        public static string GetSehirName(int Plaka)
        {
            CitiesOrderByPlateCode SehirAdi = (CitiesOrderByPlateCode)Plaka + 1;
            return SehirAdi.ToString();
        }
        private void OdemeEkranı_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            cinsBox.Items.Clear();
            cinsBox.Items.Add("Kadın");
            cinsBox.Items.Add("Erkek");
            for (int i = 1; i < 13; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int i = 2019; i < 2031; i++)
            {
                comboBox2.Items.Add(i);
            }
            fiyattext.Text = _odaFiyat;
            int gün = (_rezervasyon.CikisTarihi.Day - _rezervasyon.GirisTarihi.Day);
            if (gün==0)
            {
                gün = 1;
            }
            var OTEL = OtelHelper.GetOtelByOtelId(_rezervasyon.OtelID);
            dtpGirisOnay.Text = _rezervasyon.GirisTarihi.Date.ToShortDateString();
            dtpCikisOnay.Text = _rezervasyon.CikisTarihi.Date.ToShortDateString();
            otelOnay.Text = OTEL.OtelAdi + " Oda no=" + _rezervasyon.OdaID + " Konum=" + GetSehirName(OTEL.OtelSehir) + " " + OTEL.OtelIlce;
            kalısSüresiOnay.Text = gün.ToString()+"Gün";
            //Oda Özellikleri Gösterme
            odaPanel.Controls.Clear();
            
            var list = OzellikHelper.GetOzelliksOdaByOdaID(_rezervasyon.OdaID);

            foreach (var item in list)
            {
                Button yeniButon = new Button();
                yeniButon.BackColor = Color.White;
                yeniButon.ForeColor = Color.Black;
                yeniButon.AutoSize = true;
                yeniButon.Text = item.Ozellik.OzellikAd;
                yeniButon.Enabled = false;

                odaPanel.Controls.Add(yeniButon);
            }
            // otle özellikleride ekleme
            
            var list2 = OzellikHelper.GetOzellikNamesByOtelID(_rezervasyon.OtelID);

            foreach (var item in list2)
            {
                Button yeniButon = new Button();
                yeniButon.BackColor = Color.White;
                yeniButon.ForeColor = Color.Black;
                yeniButon.AutoSize = true;
                yeniButon.Text = item.ToString();
                yeniButon.Enabled = false;
                odaPanel.Controls.Add(yeniButon);
            }

        }

        private void newName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void newName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void newSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void newSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cartIsimLAbel.Text = textBox1.Text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void newTel_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            kartLabel.Text = maskedTextBox1.Text;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            label17.Text = maskedTextBox2.Text  ;
        }
    }
}
