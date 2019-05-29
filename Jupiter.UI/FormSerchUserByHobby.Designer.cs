namespace Jupiter.UI
{
    partial class FormSerchUserByHobby
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnUserSearch = new System.Windows.Forms.Button();
            this.cmbHobbies = new System.Windows.Forms.ComboBox();
            this.numMinYas = new System.Windows.Forms.NumericUpDown();
            this.numMaxYas = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKısıtla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinYas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxYas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(22, 57);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(580, 323);
            this.dgvUsers.TabIndex = 17;
            // 
            // btnUserSearch
            // 
            this.btnUserSearch.Location = new System.Drawing.Point(213, 28);
            this.btnUserSearch.Name = "btnUserSearch";
            this.btnUserSearch.Size = new System.Drawing.Size(75, 23);
            this.btnUserSearch.TabIndex = 15;
            this.btnUserSearch.Text = "Kisileri getir";
            this.btnUserSearch.UseVisualStyleBackColor = true;
            this.btnUserSearch.Click += new System.EventHandler(this.btnUserSearch_Click);
            // 
            // cmbHobbies
            // 
            this.cmbHobbies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHobbies.FormattingEnabled = true;
            this.cmbHobbies.Location = new System.Drawing.Point(86, 28);
            this.cmbHobbies.Name = "cmbHobbies";
            this.cmbHobbies.Size = new System.Drawing.Size(121, 21);
            this.cmbHobbies.TabIndex = 18;
            this.cmbHobbies.SelectedIndexChanged += new System.EventHandler(this.cmbHobbies_SelectedIndexChanged);
            // 
            // numMinYas
            // 
            this.numMinYas.Location = new System.Drawing.Point(65, 12);
            this.numMinYas.Name = "numMinYas";
            this.numMinYas.Size = new System.Drawing.Size(34, 20);
            this.numMinYas.TabIndex = 19;
            this.numMinYas.ValueChanged += new System.EventHandler(this.numMinYas_ValueChanged);
            // 
            // numMaxYas
            // 
            this.numMaxYas.Location = new System.Drawing.Point(120, 12);
            this.numMaxYas.Name = "numMaxYas";
            this.numMaxYas.Size = new System.Drawing.Size(34, 20);
            this.numMaxYas.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Yaş Aralığı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Hobi İsmi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "-";
            // 
            // btnKısıtla
            // 
            this.btnKısıtla.Location = new System.Drawing.Point(160, 11);
            this.btnKısıtla.Name = "btnKısıtla";
            this.btnKısıtla.Size = new System.Drawing.Size(75, 23);
            this.btnKısıtla.TabIndex = 15;
            this.btnKısıtla.Text = "Kısıtla";
            this.btnKısıtla.UseVisualStyleBackColor = true;
            this.btnKısıtla.Click += new System.EventHandler(this.btnKısıtla_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnKısıtla);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numMinYas);
            this.panel1.Controls.Add(this.numMaxYas);
            this.panel1.Location = new System.Drawing.Point(303, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 39);
            this.panel1.TabIndex = 21;
            // 
            // FormSerchUserByHobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHobbies);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnUserSearch);
            this.Name = "FormSerchUserByHobby";
            this.Text = "Serch User By Hobby";
            this.Load += new System.EventHandler(this.FormSerchUserByHobby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinYas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxYas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnUserSearch;
        private System.Windows.Forms.ComboBox cmbHobbies;
        private System.Windows.Forms.NumericUpDown numMinYas;
        private System.Windows.Forms.NumericUpDown numMaxYas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKısıtla;
        private System.Windows.Forms.Panel panel1;
    }
}