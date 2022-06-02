namespace OtelRezervasyonPr
{
    partial class OtelInceleme
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
            this.otelNameShow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picPrev = new System.Windows.Forms.Button();
            this.picNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.OdaFiyat = new System.Windows.Forms.Label();
            this.ozetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // otelNameShow
            // 
            this.otelNameShow.BackColor = System.Drawing.Color.DarkCyan;
            this.otelNameShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otelNameShow.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otelNameShow.ForeColor = System.Drawing.Color.DarkOrange;
            this.otelNameShow.Location = new System.Drawing.Point(95, 25);
            this.otelNameShow.Name = "otelNameShow";
            this.otelNameShow.Size = new System.Drawing.Size(349, 37);
            this.otelNameShow.TabIndex = 0;
            this.otelNameShow.Text = "Otel Adı Buraya";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OtelRezervasyonPr.Properties.Resources.salon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // picPrev
            // 
            this.picPrev.BackColor = System.Drawing.Color.DarkKhaki;
            this.picPrev.Location = new System.Drawing.Point(393, 483);
            this.picPrev.Name = "picPrev";
            this.picPrev.Size = new System.Drawing.Size(42, 23);
            this.picPrev.TabIndex = 2;
            this.picPrev.Text = "<";
            this.picPrev.UseVisualStyleBackColor = false;
            this.picPrev.Click += new System.EventHandler(this.picPrev_Click);
            // 
            // picNext
            // 
            this.picNext.BackColor = System.Drawing.Color.DarkKhaki;
            this.picNext.Location = new System.Drawing.Point(441, 483);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(44, 23);
            this.picNext.TabIndex = 3;
            this.picNext.Text = ">";
            this.picNext.UseVisualStyleBackColor = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ödemeye Geç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Aramaya Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OdaFiyat
            // 
            this.OdaFiyat.BackColor = System.Drawing.Color.Orange;
            this.OdaFiyat.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OdaFiyat.Location = new System.Drawing.Point(667, 509);
            this.OdaFiyat.Name = "OdaFiyat";
            this.OdaFiyat.Size = new System.Drawing.Size(100, 67);
            this.OdaFiyat.TabIndex = 9;
            this.OdaFiyat.Text = "Fiyat";
            this.OdaFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ozetLabel
            // 
            this.ozetLabel.BackColor = System.Drawing.Color.Orange;
            this.ozetLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ozetLabel.Location = new System.Drawing.Point(153, 509);
            this.ozetLabel.Name = "ozetLabel";
            this.ozetLabel.Size = new System.Drawing.Size(508, 67);
            this.ozetLabel.TabIndex = 11;
            this.ozetLabel.Text = "özet";
            this.ozetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OtelInceleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 637);
            this.Controls.Add(this.ozetLabel);
            this.Controls.Add(this.OdaFiyat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.picPrev);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.otelNameShow);
            this.Name = "OtelInceleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OtelInceleme";
            this.Load += new System.EventHandler(this.OtelInceleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label otelNameShow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button picPrev;
        private System.Windows.Forms.Button picNext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label OdaFiyat;
        private System.Windows.Forms.Label ozetLabel;
    }
}