using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jupiter.UI
{
    public partial class FormAnaEkran : Form
    {
        public FormAnaEkran()
        {
            InitializeComponent();
        }

        private void btnAddHobby_Click(object sender, EventArgs e)
        {
            FormHobbyAdd frm = new FormHobbyAdd();
            frm.Show();
            frm.FormClosed += Frm_FormClosed;
            this.Hide();
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            FormUserInformation frm = new FormUserInformation();
            frm.Show();
            frm.FormClosed += Frm_FormClosed;
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormSerchUserByHobby frm = new FormSerchUserByHobby();
            frm.Show();
            frm.FormClosed += Frm_FormClosed;
            this.Hide();
        }
    }
}
