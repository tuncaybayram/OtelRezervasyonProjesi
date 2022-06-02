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
    public partial class AnaEkran : Form
    {
        public Rezervasyon _rezervasyon = new Rezervasyon();
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void adminGirisButton_Click(object sender, EventArgs e)
        {
            var x = new LoginEkranı();
            this.Hide();
            x.Show();
        }

        private void secimOtelBtn_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count>0)
            {
            _rezervasyon.GirisTarihi = dtpGiris.Value;
            _rezervasyon.CikisTarihi = dtpCikis.Value;
            
            _rezervasyon.OdaID= int.Parse(listView2.SelectedItems[0].SubItems[0].Text);

            var x = new OtelInceleme(_rezervasyon);
            this.Hide();
            x.Show();
            }
            else
            {
                MessageBox.Show("Oda seçimi yapmadınız !\nLütfen Listeden bir oda seçiniz...");
            }
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            OtelSecimGöster();
            dtpGiris.MinDate = DateTime.Now;
            dtpCikis.MinDate = dtpGiris.Value;
            comboBox1.DataSource = Enum.GetValues(typeof(OdaTuru));


        }
        public void OtelSecimGöster()
        {
            listView1.Items.Clear();
            var oList = OtelHelper.GetOtels();
            var sayı = dtpCikis.Value.Day - dtpGiris.Value.Day;
            foreach (var item in oList)
            {
                var lele = OtelHelper.GetMinOdaFiyatByOtelId(item.OtelID).Min();
                if (lele != 0)
                {
                    if (sayı == 0)
                    {
                        sayı = 1;
                    }
                    string[] row = { item.OtelID.ToString(), item.OtelAdi, GetSehirName(item.OtelSehir), lele.ToString(), (sayı * lele).ToString() };
                    var newRow = new ListViewItem(row);
                    listView1.Items.Add(newRow);
                }

            }
        }
        public static string GetSehirName(int Plaka)
        {
            CitiesOrderByPlateCode SehirAdi = (CitiesOrderByPlateCode)Plaka + 1;
            return SehirAdi.ToString();
        }

        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpGiris_ValueChanged(object sender, EventArgs e)
        {
            dtpCikis.MinDate = dtpGiris.Value;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
           
        }
        public void Arama()
        {
            if (comboBox1.SelectedIndex > -1)
            {
                listView1.Items.Clear();
                var oList = OtelHelper.GetOtels();
                var sayı = dtpCikis.Value.Day - dtpGiris.Value.Day;
                foreach (var item in oList)
                {
                    var lele = OtelHelper.GetMinOdaFiyatByOtelId(item.OtelID, comboBox1.SelectedIndex).Min();
                    if (lele != 0 && GetSehirName(item.OtelSehir).ToLower().StartsWith(searchBox.Text.ToLower()))
                    {
                        if (sayı == 0)
                        {
                            sayı = 1;
                        }
                        string[] row = { item.OtelID.ToString(), item.OtelAdi, GetSehirName(item.OtelSehir), lele.ToString(), (sayı * lele).ToString() };
                        var newRow = new ListViewItem(row);
                        listView1.Items.Add(newRow);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Oda Tipi Seçiniz!");
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

            //listView1.Items.Clear();
            //var oList = OtelHelper.GetOtels();
            //var sayı = dtpCikis.Value.Day - dtpGiris.Value.Day;
            //foreach (var item in oList)
            //{
            //    var lele = OtelHelper.GetMinOdaFiyatByOtelId(item.OtelID).Min();
            //    if (lele != 0 && GetSehirName(item.OtelSehir).ToLower().StartsWith(searchBox.Text.ToLower()))
            //    {
            //        string[] row = { item.OtelID.ToString(), item.OtelAdi, GetSehirName(item.OtelSehir), lele.ToString(), (sayı * lele).ToString() };
            //        var newRow = new ListViewItem(row);
            //        listView1.Items.Add(newRow);
            //    }

            //}
            listView1.Items.Clear();
            var oList = OtelHelper.GetOtels();
            var sayı = dtpCikis.Value.Day - dtpGiris.Value.Day;
            foreach (var item in oList)
            {
                var lele = OtelHelper.GetMinOdaFiyatByOtelId(item.OtelID, comboBox1.SelectedIndex).Min();
                if (lele != 0 && GetSehirName(item.OtelSehir).ToLower().StartsWith(searchBox.Text.ToLower()))
                {
                    if (sayı == 0)
                    {
                        sayı = 1;
                    }
                    string[] row = { item.OtelID.ToString(), item.OtelAdi, GetSehirName(item.OtelSehir), lele.ToString(), (sayı * lele).ToString() };
                    var newRow = new ListViewItem(row);
                    listView1.Items.Add(newRow);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0&&comboBox1.SelectedIndex>-1)
            {
                otelOzellik.Controls.Clear();
                int otelIDD = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                var list = OzellikHelper.GetOzellikNamesByOtelID(otelIDD);

                foreach (var item in list)
                {
                    Button yeniButon = new Button();
                    yeniButon.Font= new Font("Arial",12);
                    yeniButon.BackColor = Color.Orange;
                    yeniButon.AutoSize = true;
                    yeniButon.Text = item.ToString();
                    yeniButon.Enabled = false;
                    otelOzellik.Controls.Add(yeniButon);
                }

                var odalar = OdaHelper.GetOdasByOtelID(otelIDD, comboBox1.SelectedItem.ToString(), true);
                listView2.Items.Clear();
                foreach (var item in odalar)
                {
                    if (RezervasyonHelper.TarihArasıBosodalar(item.OdaID,dtpGiris.Value,dtpCikis.Value))
                    {
                        string[] row = { item.OdaID.ToString(), comboBox1.SelectedItem.ToString(), item.OdaFiyat.ToString() };
                        var newRow = new ListViewItem(row);
                        listView2.Items.Add(newRow);
                    }
                   
                }
                _rezervasyon.OtelID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
               
            {
                odaOzellik.Controls.Clear();
                int odaIDD = int.Parse(listView2.SelectedItems[0].SubItems[0].Text);
                var list = OzellikHelper.GetOzelliksOdaByOdaID(odaIDD);

                foreach (var item in list)
                {
                    Button yeniButon = new Button();
                    yeniButon.Font = new Font("Arial", 12);
                    yeniButon.BackColor = Color.Green;
                    yeniButon.AutoSize = true;
                    yeniButon.Text = item.Ozellik.OzellikAd;
                    yeniButon.Enabled = false;
                    odaOzellik.Controls.Add(yeniButon);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arama();
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
