namespace Jupiter.UI
{
    partial class FormAddUserHobby
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
            this.grpHobiAta = new System.Windows.Forms.GroupBox();
            this.bthnDeleteHobby = new System.Windows.Forms.Button();
            this.btnAnaHobiAta = new System.Windows.Forms.Button();
            this.btnHobiAta = new System.Windows.Forms.Button();
            this.lstUserHobbies = new System.Windows.Forms.ListBox();
            this.lstCocukHobiler = new System.Windows.Forms.ListBox();
            this.lstAnaHobiler = new System.Windows.Forms.ListBox();
            this.grpHobiAta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHobiAta
            // 
            this.grpHobiAta.Controls.Add(this.bthnDeleteHobby);
            this.grpHobiAta.Controls.Add(this.btnAnaHobiAta);
            this.grpHobiAta.Controls.Add(this.btnHobiAta);
            this.grpHobiAta.Controls.Add(this.lstUserHobbies);
            this.grpHobiAta.Controls.Add(this.lstCocukHobiler);
            this.grpHobiAta.Controls.Add(this.lstAnaHobiler);
            this.grpHobiAta.Location = new System.Drawing.Point(48, 26);
            this.grpHobiAta.Name = "grpHobiAta";
            this.grpHobiAta.Size = new System.Drawing.Size(449, 268);
            this.grpHobiAta.TabIndex = 13;
            this.grpHobiAta.TabStop = false;
            this.grpHobiAta.Text = "Hobi Ata";
            // 
            // bthnDeleteHobby
            // 
            this.bthnDeleteHobby.Location = new System.Drawing.Point(360, 162);
            this.bthnDeleteHobby.Name = "bthnDeleteHobby";
            this.bthnDeleteHobby.Size = new System.Drawing.Size(75, 23);
            this.bthnDeleteHobby.TabIndex = 1;
            this.bthnDeleteHobby.Text = "Hobi Sil";
            this.bthnDeleteHobby.UseVisualStyleBackColor = true;
            this.bthnDeleteHobby.Click += new System.EventHandler(this.bthnDeleteHobby_Click);
            // 
            // btnAnaHobiAta
            // 
            this.btnAnaHobiAta.Location = new System.Drawing.Point(51, 164);
            this.btnAnaHobiAta.Name = "btnAnaHobiAta";
            this.btnAnaHobiAta.Size = new System.Drawing.Size(75, 23);
            this.btnAnaHobiAta.TabIndex = 1;
            this.btnAnaHobiAta.Text = "Hobi Ata";
            this.btnAnaHobiAta.UseVisualStyleBackColor = true;
            this.btnAnaHobiAta.Click += new System.EventHandler(this.btnAnaHobiAta_Click);
            // 
            // btnHobiAta
            // 
            this.btnHobiAta.Location = new System.Drawing.Point(177, 162);
            this.btnHobiAta.Name = "btnHobiAta";
            this.btnHobiAta.Size = new System.Drawing.Size(75, 23);
            this.btnHobiAta.TabIndex = 1;
            this.btnHobiAta.Text = "Hobi Ata";
            this.btnHobiAta.UseVisualStyleBackColor = true;
            this.btnHobiAta.Click += new System.EventHandler(this.btnHobiAta_Click);
            // 
            // lstUserHobbies
            // 
            this.lstUserHobbies.FormattingEnabled = true;
            this.lstUserHobbies.Location = new System.Drawing.Point(315, 22);
            this.lstUserHobbies.Name = "lstUserHobbies";
            this.lstUserHobbies.Size = new System.Drawing.Size(120, 134);
            this.lstUserHobbies.TabIndex = 0;
            // 
            // lstCocukHobiler
            // 
            this.lstCocukHobiler.FormattingEnabled = true;
            this.lstCocukHobiler.Location = new System.Drawing.Point(132, 22);
            this.lstCocukHobiler.Name = "lstCocukHobiler";
            this.lstCocukHobiler.Size = new System.Drawing.Size(120, 134);
            this.lstCocukHobiler.TabIndex = 0;
            // 
            // lstAnaHobiler
            // 
            this.lstAnaHobiler.FormattingEnabled = true;
            this.lstAnaHobiler.Location = new System.Drawing.Point(6, 22);
            this.lstAnaHobiler.Name = "lstAnaHobiler";
            this.lstAnaHobiler.Size = new System.Drawing.Size(120, 134);
            this.lstAnaHobiler.TabIndex = 0;
            this.lstAnaHobiler.SelectedIndexChanged += new System.EventHandler(this.lstAnaHobiler_SelectedIndexChanged);
            // 
            // FormAddUserHobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpHobiAta);
            this.Name = "FormAddUserHobby";
            this.Text = "FormAddUserHobby";
            this.Load += new System.EventHandler(this.FormAddUserHobby_Load);
            this.grpHobiAta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHobiAta;
        private System.Windows.Forms.Button bthnDeleteHobby;
        private System.Windows.Forms.Button btnAnaHobiAta;
        private System.Windows.Forms.Button btnHobiAta;
        private System.Windows.Forms.ListBox lstUserHobbies;
        private System.Windows.Forms.ListBox lstCocukHobiler;
        private System.Windows.Forms.ListBox lstAnaHobiler;
    }
}