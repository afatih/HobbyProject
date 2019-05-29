namespace Jupiter.UI
{
    partial class FormHobbyAdd
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
            this.grbHobi = new System.Windows.Forms.GroupBox();
            this.cmbAnaHobiler = new System.Windows.Forms.ComboBox();
            this.btnHobiEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHobiAdi = new System.Windows.Forms.TextBox();
            this.grbHobi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHobi
            // 
            this.grbHobi.Controls.Add(this.cmbAnaHobiler);
            this.grbHobi.Controls.Add(this.btnHobiEkle);
            this.grbHobi.Controls.Add(this.label1);
            this.grbHobi.Controls.Add(this.label8);
            this.grbHobi.Controls.Add(this.txtHobiAdi);
            this.grbHobi.Location = new System.Drawing.Point(12, 12);
            this.grbHobi.Name = "grbHobi";
            this.grbHobi.Size = new System.Drawing.Size(276, 180);
            this.grbHobi.TabIndex = 12;
            this.grbHobi.TabStop = false;
            this.grbHobi.Text = "Hobi";
            // 
            // cmbAnaHobiler
            // 
            this.cmbAnaHobiler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnaHobiler.FormattingEnabled = true;
            this.cmbAnaHobiler.Location = new System.Drawing.Point(108, 37);
            this.cmbAnaHobiler.Name = "cmbAnaHobiler";
            this.cmbAnaHobiler.Size = new System.Drawing.Size(121, 21);
            this.cmbAnaHobiler.TabIndex = 13;
            this.cmbAnaHobiler.SelectedIndexChanged += new System.EventHandler(this.cmbAnaHobiler_SelectedIndexChanged);
            // 
            // btnHobiEkle
            // 
            this.btnHobiEkle.Location = new System.Drawing.Point(159, 106);
            this.btnHobiEkle.Name = "btnHobiEkle";
            this.btnHobiEkle.Size = new System.Drawing.Size(70, 38);
            this.btnHobiEkle.TabIndex = 10;
            this.btnHobiEkle.Text = "Ekle";
            this.btnHobiEkle.UseVisualStyleBackColor = true;
            this.btnHobiEkle.Click += new System.EventHandler(this.btnHobiEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hobi Kategorisi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hobi Adı :";
            // 
            // txtHobiAdi
            // 
            this.txtHobiAdi.Location = new System.Drawing.Point(108, 70);
            this.txtHobiAdi.MaxLength = 20;
            this.txtHobiAdi.Name = "txtHobiAdi";
            this.txtHobiAdi.Size = new System.Drawing.Size(121, 20);
            this.txtHobiAdi.TabIndex = 9;
            this.txtHobiAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHobiAdi_KeyPress);
            // 
            // FormHobbyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbHobi);
            this.Name = "FormHobbyAdd";
            this.Text = "Hobi Ekle";
            this.Load += new System.EventHandler(this.FormHobbyAdd_Load);
            this.grbHobi.ResumeLayout(false);
            this.grbHobi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHobi;
        private System.Windows.Forms.Button btnHobiEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHobiAdi;
        private System.Windows.Forms.ComboBox cmbAnaHobiler;
        private System.Windows.Forms.Label label1;
    }
}