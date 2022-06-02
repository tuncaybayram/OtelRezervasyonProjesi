using OtelRezervasyonPr.Enumlar;
using OtelRezervasyonPr.Model;
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
    public partial class AdminSayfası : Form
    {

        public AdminSayfası()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void AdminSayfası_Load(object sender, EventArgs e)
        {//comboboxların doldurulması
            newSehirCb.DataSource = Enum.GetValues(typeof(CitiesOrderByPlateCode));
            updatedSehir.DataSource = Enum.GetValues(typeof(CitiesOrderByPlateCode));
            turCB2.DataSource = Enum.GetValues(typeof(OdaTuru));
            turCB3.DataSource = Enum.GetValues(typeof(OdaTuru));
            tipCB.DataSource = Enum.GetValues(typeof(OzellikTur));
            comboBox1.DataSource = Enum.GetValues(typeof(CitiesOrderByPlateCode));
            RezervGoster();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tipCB.SelectedIndex < 0)
            {
                MessageBox.Show("TÜR SEÇ");
            }
            if (OzellikTB.TextLength == 0)
            {
                MessageBox.Show("ÖZELLİK ADINI GİRMEDİN");
            }
            if (OzellikTB.TextLength > 0 && tipCB.SelectedIndex > -1)
            {
                OzellikHelper.Ekle(tipCB.SelectedItem.ToString(), OzellikTB.Text);

                OzellikGoster(OzellikHelper.GetAllOzellik());
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOtels(OtelHelper.GetOtels(), listView2);
            LoadOtels(OtelHelper.GetOtels(), otelList);
            LoadOtels(OtelHelper.GetOtels(), otelList2);
            OzellikGoster(OzellikHelper.GetAllOzellik());

            listBox1.Items.Clear();
            listBox3.Items.Clear();
            otelOzellikList.Items.Clear();
            otelOzellikList2.Items.Clear();
            foreach (var item in OzellikHelper.GetOzellikOda())
            {
                listBox1.Items.Add(item.OzellikAd);
                listBox3.Items.Add(item.OzellikAd);
            }
            foreach (var item in OzellikHelper.GetOzellikOtel())
            {
                otelOzellikList.Items.Add(item.OzellikAd);
                otelOzellikList2.Items.Add(item.OzellikAd);
            }
        }
        //özellik göster
        public void OzellikGoster(List<Ozellik> ozList)//özellikleri listeler
        {
            listView1.Items.Clear();
            foreach (var item in ozList)
            {
                string tip;
                if (item.OzellikTip == 0)
                {
                    tip = "otel";
                }
                else
                {
                    tip = "oda";
                }
                string[] row = { item.OzellikID.ToString(), item.OzellikAd, tip };
                var newRow = new ListViewItem(row);
                listView1.Items.Add(newRow);
            }
        }
        public void RezervGoster()
        {
            var a = RezervasyonHelper.GetAllRezervasyon();
            listView3.Items.Clear();
            foreach (var rez in a)
            {
                int gün = rez.CikisTarihi.Day - rez.GirisTarihi.Day;
                if (gün == 0)
                {
                    gün = 1;
                }
                string[] row = { rez.RezervasyonID.ToString(), rez.Musteri.MusteriAd + " " + rez.Musteri.MusteriSoyad, GetSehirName(rez.Otel.OtelSehir), rez.Otel.OtelAdi, rez.GirisTarihi.ToShortDateString(), rez.CikisTarihi.ToShortDateString(), (rez.Oda.OdaFiyat * gün).ToString(), rez.islemTarihi.ToString() };
                var newRow = new ListViewItem(row);
                listView3.Items.Add(newRow);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Otel newOtel = new Otel { OtelAdi = newOtelName.Text, OtelSehir = newSehirCb.SelectedIndex, OtelDurum = true, OtelIlce = newIlce.Text };
            OtelHelper.OtelCUD(newOtel, System.Data.Entity.EntityState.Added);
            LoadOtels(OtelHelper.GetOtels(), listView2);
            //listboxta bulunan özellikleri otele adama işlemi
            foreach (var item in newOtelOzellik.Items)
            {

                OtelOzellik hO = new OtelOzellik();
                hO.OtelID = newOtel.OtelID;
                hO.OzellikDurum = true;
                hO.OzellikID = OzellikHelper.GetOzellikByOzelilkAd(item.ToString()).OzellikID;
                OzellikHelper.OtelOzellikCud(hO, System.Data.Entity.EntityState.Added);
            }

        }
        #region
        public static void LoadOtels(List<Otel> otelList, ListView hangiListe)
        {

            hangiListe.Items.Clear();
            foreach (var item in otelList)
            {
                string[] row = { item.OtelID.ToString(), item.OtelAdi, GetSehirName(item.OtelSehir) };
                var newRow = new ListViewItem(row);
                if (item.OtelDurum == true)
                {
                    hangiListe.Items.Add(newRow);

                }
            }
        }
        public static string GetSehirName(int Plaka)
        {
            CitiesOrderByPlateCode SehirAdi = (CitiesOrderByPlateCode)Plaka + 1;
            return SehirAdi.ToString();
        }
        #endregion//otel listeleme

        private void button9_Click(object sender, EventArgs e)
        {
            if (!newOtelOzellik.Items.Contains(otelOzellikList.SelectedItem.ToString())&&otelOzellikList.SelectedIndex>-1)
            {
                newOtelOzellik.Items.Add(otelOzellikList.SelectedItem.ToString());

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (newOtelOzellik.SelectedIndex > -1)
            {
                newOtelOzellik.Items.RemoveAt(newOtelOzellik.SelectedIndex);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!updatedOzellikOtel.Items.Contains(otelOzellikList2.SelectedItem.ToString())&&otelOzellikList2.SelectedIndex>-1)
            {
                updatedOzellikOtel.Items.Add(otelOzellikList2.SelectedItem.ToString());

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (updatedOzellikOtel.SelectedItems.Count>0)
            {

            updatedOzellikOtel.Items.RemoveAt(updatedOzellikOtel.SelectedIndex);
            }
        }

        private void otelModifyBtn_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                updatedOzellikOtel.Items.Clear();
                var a = OzellikHelper.GetOtelOzellikByOtelID(int.Parse(listView2.SelectedItems[0].SubItems[0].Text));
                foreach (var item in a)
                {
                    if (item.OzellikDurum == true)
                    {
                        updatedOzellikOtel.Items.Add(item.Ozellik.OzellikAd);
                    }
                }
                updatedSehir.Text = listView2.SelectedItems[0].SubItems[2].Text;
                updatedIlce.Text = OtelHelper.GetOtelByOtelId(int.Parse(listView2.SelectedItems[0].SubItems[0].Text)).OtelIlce;
                updatedOtelName.Text = listView2.SelectedItems[0].SubItems[1].Text;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var y = OtelHelper.GetOtelByOtelId(int.Parse(listView2.SelectedItems[0].SubItems[0].Text));
            y.OtelAdi = updatedOtelName.Text;
            y.OtelIlce = updatedIlce.Text;
            y.OtelSehir = updatedSehir.SelectedIndex;
            OtelHelper.OtelCUD(y, System.Data.Entity.EntityState.Modified);
            var a = OzellikHelper.GetOtelOzellikByOtelID(y.OtelID);

            foreach (var item in a)
            {

                if (!updatedOzellikOtel.Items.Contains(item.Ozellik.OzellikAd))
                {
                    var oc = OzellikHelper.GetOtelOzellikByOzellikAd(item.Ozellik.OzellikAd);
                    oc.OzellikDurum = false;

                    OzellikHelper.OtelOzellikCud(oc, System.Data.Entity.EntityState.Modified);
                    OzellikHelper.OtelOzellikCud(oc, System.Data.Entity.EntityState.Deleted);
                }
            }
            foreach (var item in updatedOzellikOtel.Items)
            {
                if (!OzellikHelper.GetOzellikNamesByOtelID(y.OtelID).Contains(item))
                {

                    OtelOzellik hO = new OtelOzellik();
                    hO.OtelID = y.OtelID;
                    hO.OzellikDurum = true;
                    hO.OzellikID = OzellikHelper.GetOzellikByOzelilkAd(item.ToString()).OzellikID;
                    OzellikHelper.OtelOzellikCud(hO, System.Data.Entity.EntityState.Added);
                }
            }
            LoadOtels(OtelHelper.GetOtels(), listView2);
            LoadOtels(OtelHelper.GetOtels(), otelList);
            LoadOtels(OtelHelper.GetOtels(), otelList2);


        }

        private void otelKaldırBtn_Click(object sender, EventArgs e)
        {
            var a = OtelHelper.GetOtelByOtelId(int.Parse(listView2.SelectedItems[0].SubItems[0].Text));
            a.OtelDurum = false;
            var y = OtelHelper.OtelCUD(a, System.Data.Entity.EntityState.Modified);
            if (y)
            {
                MessageBox.Show("Başarılı");
                LoadOtels(OtelHelper.GetOtels(), listView2);
            }
        }

        private void otelList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //odaEkleSayfası

        private void odaEkleBtn_Click(object sender, EventArgs e)
        {
            if (otelList2.SelectedItems.Count == 0)
            {
                MessageBox.Show("OTEL SEÇ");
            }
            if (turCB2.SelectedIndex < 0)
            {
                MessageBox.Show("ODA TÜRÜ SEÇ");
            }
            if (textBox3.TextLength == 0)
            {
                MessageBox.Show("FİYAT GİR");
            }

            if (otelList2.SelectedItems.Count > 0 && turCB2.SelectedIndex > -1 && textBox3.TextLength > 0)
            {
                Oda yeniOda = new Oda();
                yeniOda.OtelID = int.Parse(otelList2.SelectedItems[0].SubItems[0].Text);
                yeniOda.OdaFiyat = int.Parse(textBox3.Text);
                yeniOda.OdaBoyut = turCB2.SelectedIndex;
                yeniOda.OdaDurum = true;
                var y = OdaHelper.OdaCUD(yeniOda, System.Data.Entity.EntityState.Added);
                foreach (var item in listBox4.Items)
                {
                    var ozellikOda = new OdaOzellik { OdaID = yeniOda.OdaID, OzellikDurum = true, OzellikID = OzellikHelper.GetOzellikByOzellikAd(item.ToString()).OzellikID };
                    OzellikHelper.OdaOzellikCud(ozellikOda, System.Data.Entity.EntityState.Added);

                }
                if (y)
                {
                    MessageBox.Show($"Oda başarı ile {otelList2.SelectedItems[0].SubItems[1].Text} oteline eklendi");

                }
                else
                {
                    MessageBox.Show("hata");
                }
            }





        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SearchOtelsBySehir(OtelHelper.GetOtels(), otelList2, textBox2.Text);
        }
        public static void SearchOtelsBySehir(List<Otel> otelList, ListView hangiListe, string text)
        {

            hangiListe.Items.Clear();
            foreach (var item in otelList)
            {
                string[] row = { item.OtelID.ToString(), item.OtelAdi, GetSehirName(item.OtelSehir) };
                var newRow = new ListViewItem(row);
                if (item.OtelDurum == true && GetSehirName(item.OtelSehir).ToLower().StartsWith(text.ToLower()))
                {
                    hangiListe.Items.Add(newRow);

                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            SearchOtelsBySehir(OtelHelper.GetOtels(), otelList, textBox5.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox3.SelectedItems.Count > 0)
            {
                if (!listBox4.Items.Contains(listBox3.SelectedItem.ToString()))
                {
                    listBox4.Items.Add(listBox3.SelectedItem.ToString());

                }
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox4.SelectedIndex > -1)
            {


                listBox4.Items.RemoveAt(listBox4.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!listBox2.Items.Contains(listBox1.SelectedItem.ToString())&&listBox1.SelectedItems.Count>0)
            {
                listBox2.Items.Add(listBox1.SelectedItem.ToString());
            }

        }

        private void otelList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

        }
        public void OdalarıGoster()
        {
            odalarList.Items.Clear();
            string odatipii = "";
            var odalar = OdaHelper.GetOdasByOtelID(int.Parse(otelList.SelectedItems[0].SubItems[0].Text));
            foreach (var item in odalar)
            {
                if (item.OdaDurum == true)
                {
                    if (item.OdaBoyut == 0) { odatipii = "AileOdası"; }
                    if (item.OdaBoyut == 1) { odatipii = "TekKisilik"; }
                    if (item.OdaBoyut == 2) { odatipii = "CiftKisilik"; }
                    if (item.OdaBoyut == 3) { odatipii = "Diger"; }


                    string[] row = { otelList.SelectedItems[0].SubItems[0].Text, item.OdaID.ToString(), odatipii, item.OdaFiyat.ToString() };
                    var newRow = new ListViewItem(row);
                    odalarList.Items.Add(newRow);
                }
            }
        }
        private void otelList_Click(object sender, EventArgs e)
        {
            OdalarıGoster();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (odalarList.SelectedItems.Count > 0)
            {


                var düzenleOda = OdaHelper.GetOdaByOdaID(int.Parse(odalarList.SelectedItems[0].SubItems[1].Text));
                düzenleOda.OdaDurum = false;
                var z = OdaHelper.OdaCUD(düzenleOda, System.Data.Entity.EntityState.Modified);
                if (z)
                {
                    MessageBox.Show("Oda kaldırıldı");
                }
                else
                {
                    MessageBox.Show("hata");
                }
            }

        }
        public void OdaOzellikLoad()
        {
            if (odalarList.SelectedItems.Count > 0)
            {
                listBox2.Items.Clear();
                var a = OzellikHelper.GetOzelliksOdaByOdaID(int.Parse(odalarList.SelectedItems[0].SubItems[1].Text));
                foreach (var item in a)
                {
                    listBox2.Items.Add(item.Ozellik.OzellikAd);
                }
            }
        }
        private void odalarList_Click(object sender, EventArgs e)
        {
            if (odalarList.SelectedItems.Count > 0)
            {
                listBox2.Items.Clear();
                var a = OzellikHelper.GetOzelliksOdaByOdaID(int.Parse(odalarList.SelectedItems[0].SubItems[1].Text));
                foreach (var item in a)
                {
                    if (item.OzellikDurum == true)
                    {
                        listBox2.Items.Add(item.Ozellik.OzellikAd);
                    }
                }
            }

        }

        private void odaDuzenle_Click(object sender, EventArgs e)
        {
            if (odalarList.SelectedItems.Count > 0 && !string.IsNullOrEmpty(duzenleOdaFiyat.Text))
            {


                var y = OdaHelper.GetOdaByOdaID(int.Parse(odalarList.SelectedItems[0].SubItems[1].Text));
                y.OdaFiyat = int.Parse(duzenleOdaFiyat.Text);
                y.OdaBoyut = turCB3.SelectedIndex;

                OdaHelper.OdaCUD(y, System.Data.Entity.EntityState.Modified);


                var a = OzellikHelper.GetOzelliksOdaByOdaID(y.OdaID);
                foreach (var item in a)
                {

                    if (!listBox2.Items.Contains(item.Ozellik.OzellikAd))
                    {
                        var oc = OzellikHelper.GetOdaOzellikByOzellikAd(item.Ozellik.OzellikAd);
                        var t = OzellikHelper.OdaOzellikCud(oc, System.Data.Entity.EntityState.Deleted);
                        if (t)
                        {
                            MessageBox.Show("Oda Özellik Kapatıldı");
                        }
                    }
                }
                foreach (var item in listBox2.Items)
                {
                    if (OzellikHelper.OdadaBuOzellikVar(y.OdaID, item.ToString()))
                    {
                        OdaOzellik hO = new OdaOzellik();
                        hO.OdaID = y.OdaID;
                        hO.OzellikDurum = true;
                        hO.OzellikID = OzellikHelper.GetOzellikByOzelilkAd(item.ToString()).OzellikID;
                        var c = OzellikHelper.OdaOzellikCud(hO, System.Data.Entity.EntityState.Added);
                        if (c)
                        {
                            MessageBox.Show("Odaya yeni Özellik Eklendi");
                        }
                    }
                }
                OdaOzellikLoad();
                OdalarıGoster();
            }
            else
            {
                MessageBox.Show("Odayı ve boş kutucukları kontrol edin!");
            }


        }

        private void gecisBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var x = new AnaEkran();
            x.Show();
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            string aramaTipi = "";
            if (musteriCek.Checked == true)
            {
                aramaTipi = "musteri";
            }
            else if (otelAdCek.Checked == true)
            {
                aramaTipi = "otel";
            }
            else if (sehirCek.Checked == true)
            {
                aramaTipi = "sehir";
            }
            else if (tarihBox.Checked == true)
            {
                aramaTipi = "tarihlere";
            }
            var a = RezervasyonHelper.RezervasyonFiltre(aramaTipi, textBox4.Text, adminDtp1.Value, adminDtp2.Value, comboBox1.SelectedIndex);
            foreach (var rez in a)
            {
                int gün = rez.CikisTarihi.Day - rez.GirisTarihi.Day;
                if (gün == 0)
                {
                    gün = 1;
                }
                string[] row = { rez.RezervasyonID.ToString(), rez.Musteri.MusteriAd + " " + rez.Musteri.MusteriSoyad, GetSehirName(rez.Otel.OtelSehir), rez.Otel.OtelAdi, rez.GirisTarihi.ToShortDateString(), rez.CikisTarihi.ToShortDateString(), (rez.Oda.OdaFiyat * gün).ToString(), rez.islemTarihi.ToString() };
                var newRow = new ListViewItem(row);
                listView3.Items
                    .Add(newRow);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void odalarList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void otelList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newIlce_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void updatedIlce_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatedIlce_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void duzenleOdaFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
