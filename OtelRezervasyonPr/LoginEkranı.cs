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
    public partial class LoginEkranı : Form
    {
        string adminName = "admin";
        string adminPw = "123";
        public LoginEkranı()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginAd.Text==adminName&&adminPw==loginPw.Text)
            {
                MessageBox.Show("Giriş Yapıldı");
                var adminPage = new AdminSayfası();
                this.Hide();
                adminPage.Show();

            }
        }

        private void LoginEkranı_Load(object sender, EventArgs e)
        {

        }

        private void LoginEkranı_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
