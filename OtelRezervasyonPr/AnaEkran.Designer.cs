namespace OtelRezervasyonPr
{
    partial class AnaEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminGirisButton = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dtpGiris = new System.Windows.Forms.DateTimePicker();
            this.dtpCikis = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OtelAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sehir = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.minFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aralikFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchBtn = new System.Windows.Forms.Button();
            this.secimOtelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.odaNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.odatipi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.odaFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.odaOzellik = new System.Windows.Forms.FlowLayoutPanel();
            this.otelOzellik = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // adminGirisButton
            // 
            this.adminGirisButton.Location = new System.Drawing.Point(12, 12);
            this.adminGirisButton.Name = "adminGirisButton";
            this.adminGirisButton.Size = new System.Drawing.Size(75, 23);
            this.adminGirisButton.TabIndex = 0;
            this.adminGirisButton.Text = "Admin Giriş";
            this.adminGirisButton.UseVisualStyleBackColor = true;
            this.adminGirisButton.Click += new System.EventHandler(this.adminGirisButton_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(69, 86);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(176, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // dtpGiris
            // 
            this.dtpGiris.Location = new System.Drawing.Point(251, 86);
            this.dtpGiris.Name = "dtpGiris";
            this.dtpGiris.Size = new System.Drawing.Size(172, 20);
            this.dtpGiris.TabIndex = 2;
            this.dtpGiris.ValueChanged += new System.EventHandler(this.dtpGiris_ValueChanged);
            // 
            // dtpCikis
            // 
            this.dtpCikis.Location = new System.Drawing.Point(429, 86);
            this.dtpCikis.Name = "dtpCikis";
            this.dtpCikis.Size = new System.Drawing.Size(174, 20);
            this.dtpCikis.TabIndex = 3;
            this.dtpCikis.ValueChanged += new System.EventHandler(this.dtpCikis_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(609, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.OldLace;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.OtelAdi,
            this.Sehir,
            this.minFiyat,
            this.aralikFiyat});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.ForeColor = System.Drawing.Color.Orange;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(178, 123);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(684, 184);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // OtelAdi
            // 
            this.OtelAdi.Text = "Otel Adı";
            this.OtelAdi.Width = 256;
            // 
            // Sehir
            // 
            this.Sehir.Text = "Şehir";
            this.Sehir.Width = 119;
            // 
            // minFiyat
            // 
            this.minFiyat.Text = "Minimum Fiyat";
            this.minFiyat.Width = 158;
            // 
            // aralikFiyat
            // 
            this.aralikFiyat.Text = "secilenGunFiyat";
            this.aralikFiyat.Width = 144;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(783, 84);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "Ara";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // secimOtelBtn
            // 
            this.secimOtelBtn.Location = new System.Drawing.Point(766, 580);
            this.secimOtelBtn.Name = "secimOtelBtn";
            this.secimOtelBtn.Size = new System.Drawing.Size(92, 45);
            this.secimOtelBtn.TabIndex = 9;
            this.secimOtelBtn.Text = "Seç";
            this.secimOtelBtn.UseVisualStyleBackColor = true;
            this.secimOtelBtn.Click += new System.EventHandler(this.secimOtelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(69, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Şehir Arat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(251, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 12;
            this.label2.Text = "Giriş";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(429, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Çıkış";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(609, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Oda Tipi";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.odaNo,
            this.odatipi,
            this.odaFiyat});
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(198, 327);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(180, 144);
            this.listView2.TabIndex = 15;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // odaNo
            // 
            this.odaNo.Text = "Oda No";
            // 
            // odatipi
            // 
            this.odatipi.Text = "Oda Tipi";
            this.odatipi.Width = 67;
            // 
            // odaFiyat
            // 
            this.odaFiyat.Text = "Fiyat";
            this.odaFiyat.Width = 46;
            // 
            // odaOzellik
            // 
            this.odaOzellik.BackColor = System.Drawing.Color.OldLace;
            this.odaOzellik.Location = new System.Drawing.Point(625, 327);
            this.odaOzellik.Name = "odaOzellik";
            this.odaOzellik.Size = new System.Drawing.Size(237, 144);
            this.odaOzellik.TabIndex = 16;
            // 
            // otelOzellik
            // 
            this.otelOzellik.BackColor = System.Drawing.Color.OldLace;
            this.otelOzellik.Location = new System.Drawing.Point(384, 327);
            this.otelOzellik.Name = "otelOzellik";
            this.otelOzellik.Size = new System.Drawing.Size(235, 144);
            this.otelOzellik.TabIndex = 17;
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::OtelRezervasyonPr.Properties.Resources.bb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 637);
            this.Controls.Add(this.otelOzellik);
            this.Controls.Add(this.odaOzellik);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.secimOtelBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dtpCikis);
            this.Controls.Add(this.dtpGiris);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.adminGirisButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NURUVAGO";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminGirisButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DateTimePicker dtpGiris;
        private System.Windows.Forms.DateTimePicker dtpCikis;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader OtelAdi;
        private System.Windows.Forms.ColumnHeader Sehir;
        private System.Windows.Forms.ColumnHeader minFiyat;
        private System.Windows.Forms.ColumnHeader aralikFiyat;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button secimOtelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader odaNo;
        private System.Windows.Forms.ColumnHeader odatipi;
        private System.Windows.Forms.ColumnHeader odaFiyat;
        private System.Windows.Forms.FlowLayoutPanel odaOzellik;
        private System.Windows.Forms.FlowLayoutPanel otelOzellik;
    }
}

