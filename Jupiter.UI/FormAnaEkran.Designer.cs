namespace Jupiter.UI
{
    partial class FormAnaEkran
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.btnAddHobby = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(510, 149);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 62);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Sorgula";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Location = new System.Drawing.Point(318, 149);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(165, 62);
            this.btnUserInfo.TabIndex = 2;
            this.btnUserInfo.Text = "Form Doldur";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // btnAddHobby
            // 
            this.btnAddHobby.Location = new System.Drawing.Point(108, 149);
            this.btnAddHobby.Name = "btnAddHobby";
            this.btnAddHobby.Size = new System.Drawing.Size(165, 62);
            this.btnAddHobby.TabIndex = 3;
            this.btnAddHobby.Text = "Hobby Ekle";
            this.btnAddHobby.UseVisualStyleBackColor = true;
            this.btnAddHobby.Click += new System.EventHandler(this.btnAddHobby_Click);
            // 
            // FormAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUserInfo);
            this.Controls.Add(this.btnAddHobby);
            this.Name = "FormAnaEkran";
            this.Text = "Ana Ekran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnAddHobby;
    }
}