
namespace ModiAlgoritmasi
{
    partial class Form1
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
            this.Top = new System.Windows.Forms.Panel();
            this.OptimumlukKontrolu = new System.Windows.Forms.Button();
            this.Cikis = new System.Windows.Forms.Button();
            this.Satir = new System.Windows.Forms.TextBox();
            this.SatirLabeli = new System.Windows.Forms.Label();
            this.SutunLabeli = new System.Windows.Forms.Label();
            this.Sutun = new System.Windows.Forms.TextBox();
            this.MatrisOlustur = new System.Windows.Forms.Button();
            this.Temizle = new System.Windows.Forms.Button();
            this.Hesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ZMinDeger = new System.Windows.Forms.Label();
            this.Cozum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Degerler = new System.Windows.Forms.Label();
            this.OptimumlukEkrani = new System.Windows.Forms.Panel();
            this.MatrisEkrani = new System.Windows.Forms.Panel();
            this.HataMesajiIki = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.HataButonuIki = new System.Windows.Forms.Button();
            this.HataMesaji = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HataTxt = new System.Windows.Forms.Label();
            this.HataButonu = new System.Windows.Forms.Button();
            this.AnaSayfaEkranı = new System.Windows.Forms.Panel();
            this.Top.SuspendLayout();
            this.OptimumlukEkrani.SuspendLayout();
            this.MatrisEkrani.SuspendLayout();
            this.HataMesajiIki.SuspendLayout();
            this.HataMesaji.SuspendLayout();
            this.AnaSayfaEkranı.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top
            // 
            this.Top.AutoSize = true;
            this.Top.BackColor = System.Drawing.Color.CadetBlue;
            this.Top.Controls.Add(this.OptimumlukKontrolu);
            this.Top.Controls.Add(this.Cikis);
            this.Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(1015, 71);
            this.Top.TabIndex = 0;
            // 
            // OptimumlukKontrolu
            // 
            this.OptimumlukKontrolu.FlatAppearance.BorderSize = 0;
            this.OptimumlukKontrolu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptimumlukKontrolu.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OptimumlukKontrolu.ForeColor = System.Drawing.Color.Black;
            this.OptimumlukKontrolu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OptimumlukKontrolu.Location = new System.Drawing.Point(232, 0);
            this.OptimumlukKontrolu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OptimumlukKontrolu.Name = "OptimumlukKontrolu";
            this.OptimumlukKontrolu.Size = new System.Drawing.Size(565, 69);
            this.OptimumlukKontrolu.TabIndex = 3;
            this.OptimumlukKontrolu.Text = "Optimizasyon Kontrolü Yapmak için Tıklayınız";
            this.OptimumlukKontrolu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OptimumlukKontrolu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OptimumlukKontrolu.UseVisualStyleBackColor = true;
            this.OptimumlukKontrolu.Click += new System.EventHandler(this.OptimumlukKontrolu_Click_1);
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.CadetBlue;
            this.Cikis.FlatAppearance.BorderSize = 0;
            this.Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cikis.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cikis.ForeColor = System.Drawing.Color.Black;
            this.Cikis.Image = global::ModiAlgoritmasi.Properties.Resources.logout1;
            this.Cikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cikis.Location = new System.Drawing.Point(849, 5);
            this.Cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(136, 58);
            this.Cikis.TabIndex = 6;
            this.Cikis.Text = "Çıkış";
            this.Cikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // Satir
            // 
            this.Satir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Satir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Satir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Satir.ForeColor = System.Drawing.Color.DarkCyan;
            this.Satir.Location = new System.Drawing.Point(226, 24);
            this.Satir.Margin = new System.Windows.Forms.Padding(4);
            this.Satir.Name = "Satir";
            this.Satir.Size = new System.Drawing.Size(139, 25);
            this.Satir.TabIndex = 0;
            this.Satir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SatirLabeli
            // 
            this.SatirLabeli.AutoSize = true;
            this.SatirLabeli.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SatirLabeli.ForeColor = System.Drawing.Color.Black;
            this.SatirLabeli.Location = new System.Drawing.Point(37, 18);
            this.SatirLabeli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SatirLabeli.Name = "SatirLabeli";
            this.SatirLabeli.Size = new System.Drawing.Size(161, 32);
            this.SatirLabeli.TabIndex = 1;
            this.SatirLabeli.Text = "Satır Sayısı:";
            // 
            // SutunLabeli
            // 
            this.SutunLabeli.AutoSize = true;
            this.SutunLabeli.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SutunLabeli.ForeColor = System.Drawing.Color.Black;
            this.SutunLabeli.Location = new System.Drawing.Point(412, 17);
            this.SutunLabeli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SutunLabeli.Name = "SutunLabeli";
            this.SutunLabeli.Size = new System.Drawing.Size(179, 32);
            this.SutunLabeli.TabIndex = 2;
            this.SutunLabeli.Text = "Sütun Sayısı:";
            // 
            // Sutun
            // 
            this.Sutun.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Sutun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sutun.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sutun.ForeColor = System.Drawing.Color.DarkCyan;
            this.Sutun.Location = new System.Drawing.Point(632, 23);
            this.Sutun.Margin = new System.Windows.Forms.Padding(4);
            this.Sutun.Name = "Sutun";
            this.Sutun.Size = new System.Drawing.Size(139, 25);
            this.Sutun.TabIndex = 3;
            this.Sutun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MatrisOlustur
            // 
            this.MatrisOlustur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.MatrisOlustur.FlatAppearance.BorderSize = 0;
            this.MatrisOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MatrisOlustur.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MatrisOlustur.ForeColor = System.Drawing.Color.White;
            this.MatrisOlustur.Location = new System.Drawing.Point(43, 81);
            this.MatrisOlustur.Margin = new System.Windows.Forms.Padding(4);
            this.MatrisOlustur.Name = "MatrisOlustur";
            this.MatrisOlustur.Size = new System.Drawing.Size(139, 33);
            this.MatrisOlustur.TabIndex = 4;
            this.MatrisOlustur.Text = "Oluştur";
            this.MatrisOlustur.UseVisualStyleBackColor = false;
            this.MatrisOlustur.Click += new System.EventHandler(this.MatrisOlustur_Click);
            // 
            // Temizle
            // 
            this.Temizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.Temizle.Cursor = System.Windows.Forms.Cursors.Default;
            this.Temizle.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.Temizle.FlatAppearance.BorderSize = 0;
            this.Temizle.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Temizle.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Temizle.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temizle.ForeColor = System.Drawing.Color.White;
            this.Temizle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Temizle.Location = new System.Drawing.Point(226, 81);
            this.Temizle.Margin = new System.Windows.Forms.Padding(4);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(139, 33);
            this.Temizle.TabIndex = 5;
            this.Temizle.Text = "Sil";
            this.Temizle.UseVisualStyleBackColor = false;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // Hesapla
            // 
            this.Hesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.Hesapla.FlatAppearance.BorderSize = 0;
            this.Hesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hesapla.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Hesapla.ForeColor = System.Drawing.Color.White;
            this.Hesapla.Location = new System.Drawing.Point(418, 81);
            this.Hesapla.Margin = new System.Windows.Forms.Padding(4);
            this.Hesapla.Name = "Hesapla";
            this.Hesapla.Size = new System.Drawing.Size(139, 33);
            this.Hesapla.TabIndex = 7;
            this.Hesapla.Text = "Hesapla";
            this.Hesapla.UseVisualStyleBackColor = false;
            this.Hesapla.Click += new System.EventHandler(this.Hesapla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(786, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Z Min:";
            // 
            // ZMinDeger
            // 
            this.ZMinDeger.AutoSize = true;
            this.ZMinDeger.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZMinDeger.ForeColor = System.Drawing.Color.Black;
            this.ZMinDeger.Location = new System.Drawing.Point(902, 47);
            this.ZMinDeger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ZMinDeger.Name = "ZMinDeger";
            this.ZMinDeger.Size = new System.Drawing.Size(0, 21);
            this.ZMinDeger.TabIndex = 9;
            // 
            // Cozum
            // 
            this.Cozum.AutoSize = true;
            this.Cozum.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cozum.ForeColor = System.Drawing.Color.Black;
            this.Cozum.Location = new System.Drawing.Point(12, 153);
            this.Cozum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cozum.Name = "Cozum";
            this.Cozum.Size = new System.Drawing.Size(0, 21);
            this.Cozum.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(708, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(740, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 13;
            // 
            // Degerler
            // 
            this.Degerler.AutoSize = true;
            this.Degerler.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Degerler.ForeColor = System.Drawing.Color.Black;
            this.Degerler.Location = new System.Drawing.Point(12, 129);
            this.Degerler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Degerler.Name = "Degerler";
            this.Degerler.Size = new System.Drawing.Size(0, 21);
            this.Degerler.TabIndex = 15;
            // 
            // OptimumlukEkrani
            // 
            this.OptimumlukEkrani.AutoScroll = true;
            this.OptimumlukEkrani.AutoSize = true;
            this.OptimumlukEkrani.BackColor = System.Drawing.Color.CadetBlue;
            this.OptimumlukEkrani.Controls.Add(this.Degerler);
            this.OptimumlukEkrani.Controls.Add(this.label5);
            this.OptimumlukEkrani.Controls.Add(this.label4);
            this.OptimumlukEkrani.Controls.Add(this.Cozum);
            this.OptimumlukEkrani.Controls.Add(this.ZMinDeger);
            this.OptimumlukEkrani.Controls.Add(this.label2);
            this.OptimumlukEkrani.Controls.Add(this.Hesapla);
            this.OptimumlukEkrani.Controls.Add(this.MatrisEkrani);
            this.OptimumlukEkrani.Controls.Add(this.Temizle);
            this.OptimumlukEkrani.Controls.Add(this.MatrisOlustur);
            this.OptimumlukEkrani.Controls.Add(this.Sutun);
            this.OptimumlukEkrani.Controls.Add(this.SutunLabeli);
            this.OptimumlukEkrani.Controls.Add(this.SatirLabeli);
            this.OptimumlukEkrani.Controls.Add(this.Satir);
            this.OptimumlukEkrani.Location = new System.Drawing.Point(31, 20);
            this.OptimumlukEkrani.Margin = new System.Windows.Forms.Padding(4);
            this.OptimumlukEkrani.Name = "OptimumlukEkrani";
            this.OptimumlukEkrani.Size = new System.Drawing.Size(971, 674);
            this.OptimumlukEkrani.TabIndex = 5;
            // 
            // MatrisEkrani
            // 
            this.MatrisEkrani.AutoScroll = true;
            this.MatrisEkrani.AutoSize = true;
            this.MatrisEkrani.Controls.Add(this.HataMesajiIki);
            this.MatrisEkrani.Controls.Add(this.HataMesaji);
            this.MatrisEkrani.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MatrisEkrani.Location = new System.Drawing.Point(0, 360);
            this.MatrisEkrani.Name = "MatrisEkrani";
            this.MatrisEkrani.Size = new System.Drawing.Size(971, 314);
            this.MatrisEkrani.TabIndex = 6;
            // 
            // HataMesajiIki
            // 
            this.HataMesajiIki.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HataMesajiIki.Controls.Add(this.panel3);
            this.HataMesajiIki.Controls.Add(this.label1);
            this.HataMesajiIki.Controls.Add(this.HataButonuIki);
            this.HataMesajiIki.Location = new System.Drawing.Point(303, 77);
            this.HataMesajiIki.Name = "HataMesajiIki";
            this.HataMesajiIki.Size = new System.Drawing.Size(325, 168);
            this.HataMesajiIki.TabIndex = 8;
            this.HataMesajiIki.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 43);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Arz ve talep eşit değil!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HataButonuIki
            // 
            this.HataButonuIki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HataButonuIki.FlatAppearance.BorderSize = 0;
            this.HataButonuIki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HataButonuIki.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HataButonuIki.ForeColor = System.Drawing.Color.White;
            this.HataButonuIki.Location = new System.Drawing.Point(87, 109);
            this.HataButonuIki.Margin = new System.Windows.Forms.Padding(4);
            this.HataButonuIki.Name = "HataButonuIki";
            this.HataButonuIki.Size = new System.Drawing.Size(148, 33);
            this.HataButonuIki.TabIndex = 7;
            this.HataButonuIki.Text = "Tamam";
            this.HataButonuIki.UseVisualStyleBackColor = false;
            this.HataButonuIki.Click += new System.EventHandler(this.HataButonuIki_Click);
            // 
            // HataMesaji
            // 
            this.HataMesaji.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HataMesaji.Controls.Add(this.panel1);
            this.HataMesaji.Controls.Add(this.HataTxt);
            this.HataMesaji.Controls.Add(this.HataButonu);
            this.HataMesaji.Location = new System.Drawing.Point(268, 143);
            this.HataMesaji.Name = "HataMesaji";
            this.HataMesaji.Size = new System.Drawing.Size(378, 168);
            this.HataMesaji.TabIndex = 0;
            this.HataMesaji.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 43);
            this.panel1.TabIndex = 1;
            // 
            // HataTxt
            // 
            this.HataTxt.AutoSize = true;
            this.HataTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HataTxt.ForeColor = System.Drawing.Color.White;
            this.HataTxt.Location = new System.Drawing.Point(16, 67);
            this.HataTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HataTxt.Name = "HataTxt";
            this.HataTxt.Size = new System.Drawing.Size(362, 23);
            this.HataTxt.TabIndex = 7;
            this.HataTxt.Text = "Satır ya da sütunu boş bırakmayınız!";
            // 
            // HataButonu
            // 
            this.HataButonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HataButonu.FlatAppearance.BorderSize = 0;
            this.HataButonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HataButonu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HataButonu.ForeColor = System.Drawing.Color.White;
            this.HataButonu.Location = new System.Drawing.Point(109, 109);
            this.HataButonu.Margin = new System.Windows.Forms.Padding(4);
            this.HataButonu.Name = "HataButonu";
            this.HataButonu.Size = new System.Drawing.Size(148, 33);
            this.HataButonu.TabIndex = 7;
            this.HataButonu.Text = "Tamam";
            this.HataButonu.UseVisualStyleBackColor = false;
            this.HataButonu.Click += new System.EventHandler(this.HataButonu_Click);
            // 
            // AnaSayfaEkranı
            // 
            this.AnaSayfaEkranı.AutoSize = true;
            this.AnaSayfaEkranı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(60)))));
            this.AnaSayfaEkranı.Controls.Add(this.OptimumlukEkrani);
            this.AnaSayfaEkranı.Location = new System.Drawing.Point(0, 77);
            this.AnaSayfaEkranı.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AnaSayfaEkranı.Name = "AnaSayfaEkranı";
            this.AnaSayfaEkranı.Size = new System.Drawing.Size(1030, 727);
            this.AnaSayfaEkranı.TabIndex = 2;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 759);
            this.Controls.Add(this.AnaSayfaEkranı);
            this.Controls.Add(this.Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Top.ResumeLayout(false);
            this.OptimumlukEkrani.ResumeLayout(false);
            this.OptimumlukEkrani.PerformLayout();
            this.MatrisEkrani.ResumeLayout(false);
            this.HataMesajiIki.ResumeLayout(false);
            this.HataMesajiIki.PerformLayout();
            this.HataMesaji.ResumeLayout(false);
            this.HataMesaji.PerformLayout();
            this.AnaSayfaEkranı.ResumeLayout(false);
            this.AnaSayfaEkranı.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Button OptimumlukKontrolu;
        private System.Windows.Forms.Button Cikis;
        private System.Windows.Forms.TextBox Satir;
        private System.Windows.Forms.Label SatirLabeli;
        private System.Windows.Forms.Label SutunLabeli;
        private System.Windows.Forms.TextBox Sutun;
        private System.Windows.Forms.Button MatrisOlustur;
        private System.Windows.Forms.Button Hesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ZMinDeger;
        private System.Windows.Forms.Label Cozum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Degerler;
        private System.Windows.Forms.Panel OptimumlukEkrani;
        private System.Windows.Forms.Panel MatrisEkrani;
        private System.Windows.Forms.Panel HataMesaji;
        private System.Windows.Forms.Panel HataMesajiIki;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HataButonuIki;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HataTxt;
        private System.Windows.Forms.Button HataButonu;
        private System.Windows.Forms.Panel AnaSayfaEkranı;
        private System.Windows.Forms.Button Temizle;
    }
}

