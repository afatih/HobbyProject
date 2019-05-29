namespace Jupiter.UI
{
    partial class FormUserInformation
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.rdbKadin = new System.Windows.Forms.RadioButton();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUyruk = new System.Windows.Forms.Label();
            this.txtTCno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.grbKisiselBilgiler = new System.Windows.Forms.GroupBox();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.pnlBilgiler = new System.Windows.Forms.Panel();
            this.btnDeletePhone = new System.Windows.Forms.Button();
            this.pnlCinsiyet = new System.Windows.Forms.Panel();
            this.rdbDiger = new System.Windows.Forms.RadioButton();
            this.lstTelefon = new System.Windows.Forms.ListBox();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbUyruk = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDevamEt = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.grbKisiselBilgiler.SuspendLayout();
            this.pnlBilgiler.SuspendLayout();
            this.pnlCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(108, 3);
            this.txtAd.MaxLength = 20;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(139, 20);
            this.txtAd.TabIndex = 0;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(108, 29);
            this.txtSoyad.MaxLength = 20;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(139, 20);
            this.txtSoyad.TabIndex = 0;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // rdbKadin
            // 
            this.rdbKadin.AutoSize = true;
            this.rdbKadin.Location = new System.Drawing.Point(3, 12);
            this.rdbKadin.Name = "rdbKadin";
            this.rdbKadin.Size = new System.Drawing.Size(52, 17);
            this.rdbKadin.TabIndex = 1;
            this.rdbKadin.Text = "Kadın";
            this.rdbKadin.UseVisualStyleBackColor = true;
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Location = new System.Drawing.Point(61, 12);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(53, 17);
            this.rdbErkek.TabIndex = 1;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad :";
            // 
            // lblUyruk
            // 
            this.lblUyruk.AutoSize = true;
            this.lblUyruk.Location = new System.Drawing.Point(40, 72);
            this.lblUyruk.Name = "lblUyruk";
            this.lblUyruk.Size = new System.Drawing.Size(44, 13);
            this.lblUyruk.TabIndex = 2;
            this.lblUyruk.Text = "TC No :";
            // 
            // txtTCno
            // 
            this.txtTCno.Location = new System.Drawing.Point(114, 65);
            this.txtTCno.MaxLength = 11;
            this.txtTCno.Name = "txtTCno";
            this.txtTCno.Size = new System.Drawing.Size(139, 20);
            this.txtTCno.TabIndex = 0;
            this.txtTCno.TextChanged += new System.EventHandler(this.txtTCno_TextChanged);
            this.txtTCno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTCno_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cinsiyet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "E-Mail :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Adres :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(109, 230);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(160, 20);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(109, 144);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(139, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(109, 168);
            this.txtAdress.MaxLength = 100;
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(139, 50);
            this.txtAdress.TabIndex = 5;
            // 
            // grbKisiselBilgiler
            // 
            this.grbKisiselBilgiler.Controls.Add(this.btnSorgula);
            this.grbKisiselBilgiler.Controls.Add(this.pnlBilgiler);
            this.grbKisiselBilgiler.Controls.Add(this.cmbUyruk);
            this.grbKisiselBilgiler.Controls.Add(this.txtTCno);
            this.grbKisiselBilgiler.Controls.Add(this.label9);
            this.grbKisiselBilgiler.Controls.Add(this.lblUyruk);
            this.grbKisiselBilgiler.Location = new System.Drawing.Point(12, 31);
            this.grbKisiselBilgiler.Name = "grbKisiselBilgiler";
            this.grbKisiselBilgiler.Size = new System.Drawing.Size(365, 448);
            this.grbKisiselBilgiler.TabIndex = 6;
            this.grbKisiselBilgiler.TabStop = false;
            this.grbKisiselBilgiler.Text = "Kişisel Bilgiler";
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(259, 62);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(75, 23);
            this.btnSorgula.TabIndex = 9;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // pnlBilgiler
            // 
            this.pnlBilgiler.Controls.Add(this.btnDeletePhone);
            this.pnlBilgiler.Controls.Add(this.pnlCinsiyet);
            this.pnlBilgiler.Controls.Add(this.lstTelefon);
            this.pnlBilgiler.Controls.Add(this.btnAddPhone);
            this.pnlBilgiler.Controls.Add(this.txtAd);
            this.pnlBilgiler.Controls.Add(this.label10);
            this.pnlBilgiler.Controls.Add(this.label6);
            this.pnlBilgiler.Controls.Add(this.label7);
            this.pnlBilgiler.Controls.Add(this.label4);
            this.pnlBilgiler.Controls.Add(this.txtEmail);
            this.pnlBilgiler.Controls.Add(this.dtpDogumTarihi);
            this.pnlBilgiler.Controls.Add(this.txtAdress);
            this.pnlBilgiler.Controls.Add(this.label2);
            this.pnlBilgiler.Controls.Add(this.label5);
            this.pnlBilgiler.Controls.Add(this.label1);
            this.pnlBilgiler.Controls.Add(this.txtSoyad);
            this.pnlBilgiler.Controls.Add(this.txtPhone);
            this.pnlBilgiler.Location = new System.Drawing.Point(6, 88);
            this.pnlBilgiler.Name = "pnlBilgiler";
            this.pnlBilgiler.Size = new System.Drawing.Size(353, 327);
            this.pnlBilgiler.TabIndex = 8;
            this.pnlBilgiler.Visible = false;
            // 
            // btnDeletePhone
            // 
            this.btnDeletePhone.Location = new System.Drawing.Point(275, 256);
            this.btnDeletePhone.Name = "btnDeletePhone";
            this.btnDeletePhone.Size = new System.Drawing.Size(24, 19);
            this.btnDeletePhone.TabIndex = 11;
            this.btnDeletePhone.Text = "-";
            this.btnDeletePhone.UseVisualStyleBackColor = true;
            this.btnDeletePhone.Visible = false;
            this.btnDeletePhone.Click += new System.EventHandler(this.btnDeletePhone_Click);
            // 
            // pnlCinsiyet
            // 
            this.pnlCinsiyet.Controls.Add(this.rdbKadin);
            this.pnlCinsiyet.Controls.Add(this.rdbDiger);
            this.pnlCinsiyet.Controls.Add(this.rdbErkek);
            this.pnlCinsiyet.Location = new System.Drawing.Point(108, 97);
            this.pnlCinsiyet.Name = "pnlCinsiyet";
            this.pnlCinsiyet.Size = new System.Drawing.Size(182, 41);
            this.pnlCinsiyet.TabIndex = 10;
            // 
            // rdbDiger
            // 
            this.rdbDiger.AutoSize = true;
            this.rdbDiger.Checked = true;
            this.rdbDiger.Location = new System.Drawing.Point(120, 12);
            this.rdbDiger.Name = "rdbDiger";
            this.rdbDiger.Size = new System.Drawing.Size(50, 17);
            this.rdbDiger.TabIndex = 1;
            this.rdbDiger.TabStop = true;
            this.rdbDiger.Text = "Diğer";
            this.rdbDiger.UseVisualStyleBackColor = true;
            // 
            // lstTelefon
            // 
            this.lstTelefon.FormattingEnabled = true;
            this.lstTelefon.Location = new System.Drawing.Point(109, 256);
            this.lstTelefon.Name = "lstTelefon";
            this.lstTelefon.Size = new System.Drawing.Size(160, 43);
            this.lstTelefon.TabIndex = 8;
            this.lstTelefon.SelectedIndexChanged += new System.EventHandler(this.lstTelefon_SelectedIndexChanged);
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.Location = new System.Drawing.Point(275, 230);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(24, 20);
            this.btnAddPhone.TabIndex = 9;
            this.btnAddPhone.Text = "+";
            this.btnAddPhone.UseVisualStyleBackColor = true;
            this.btnAddPhone.Visible = false;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Doğum Tarihi :";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(108, 65);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(154, 20);
            this.dtpDogumTarihi.TabIndex = 7;
            // 
            // cmbUyruk
            // 
            this.cmbUyruk.FormattingEnabled = true;
            this.cmbUyruk.Location = new System.Drawing.Point(114, 36);
            this.cmbUyruk.Name = "cmbUyruk";
            this.cmbUyruk.Size = new System.Drawing.Size(52, 21);
            this.cmbUyruk.TabIndex = 6;
            this.cmbUyruk.SelectedIndexChanged += new System.EventHandler(this.cmbUyruk_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Uyruk :";
            // 
            // btnDevamEt
            // 
            this.btnDevamEt.Location = new System.Drawing.Point(270, 485);
            this.btnDevamEt.Name = "btnDevamEt";
            this.btnDevamEt.Size = new System.Drawing.Size(107, 38);
            this.btnDevamEt.TabIndex = 7;
            this.btnDevamEt.Text = "Devam Et";
            this.btnDevamEt.UseVisualStyleBackColor = true;
            this.btnDevamEt.Click += new System.EventHandler(this.btnDevamEt_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(18, 485);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(107, 38);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(147, 485);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(107, 38);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FormUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 569);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnDevamEt);
            this.Controls.Add(this.grbKisiselBilgiler);
            this.IsMdiContainer = true;
            this.Name = "FormUserInformation";
            this.Text = "Müşteri Bilgisi";
            this.Load += new System.EventHandler(this.FormUserInformation_Load);
            this.grbKisiselBilgiler.ResumeLayout(false);
            this.grbKisiselBilgiler.PerformLayout();
            this.pnlBilgiler.ResumeLayout(false);
            this.pnlBilgiler.PerformLayout();
            this.pnlCinsiyet.ResumeLayout(false);
            this.pnlCinsiyet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.RadioButton rdbKadin;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUyruk;
        private System.Windows.Forms.TextBox txtTCno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.GroupBox grbKisiselBilgiler;
        private System.Windows.Forms.Button btnDevamEt;
        private System.Windows.Forms.ComboBox cmbUyruk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdbDiger;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Button btnAddPhone;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.Panel pnlBilgiler;
        private System.Windows.Forms.ListBox lstTelefon;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Panel pnlCinsiyet;
        private System.Windows.Forms.Button btnDeletePhone;
    }
}

