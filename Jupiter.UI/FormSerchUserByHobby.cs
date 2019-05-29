using Jupiter.BLL;
using Jupiter.DTO;
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
    public partial class FormSerchUserByHobby : Form
    {
        HobbyController _hc;
        int? _hobbyID;
        List<HobbiesUsersDTO> _hobbyUsers;
        public FormSerchUserByHobby()
        {
            InitializeComponent();
            _hc = new HobbyController();
            _hobbyUsers = new List<HobbiesUsersDTO>();
        }

        private void btnUserSearch_Click(object sender, EventArgs e)
        {
            if (cmbHobbies.SelectedIndex < 0)
            {
                MessageBox.Show("Hobi seçmediniz!", "Hata");
                return;
            }
            numMaxYas.Value = numMinYas.Value + 1;
            _hobbyUsers = _hc.GetHobbyUsers(_hobbyID);
            dgvUsers.DataSource = _hobbyUsers;
        }

        private void FormSerchUserByHobby_Load(object sender, EventArgs e)
        {
            List<HobbyDTO> hobbies = _hc.GetHobies();
            cmbHobbies.DisplayMember = "HobbyName";
            cmbHobbies.ValueMember = "ID";
            cmbHobbies.DataSource = hobbies;
            cmbHobbies.SelectedIndex = -1;
        }

        private void cmbHobbies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHobbies.SelectedIndex > 0)
            { _hobbyID = (int)cmbHobbies.SelectedValue; }
        }

        private void btnKısıtla_Click(object sender, EventArgs e)
        {
            decimal min_Yas = numMinYas.Value;
            decimal max_Yas = numMaxYas.Value;

            
          

            List<HobbiesUsersDTO> newHobbyUsers = _hc.YasKisit(_hobbyUsers,min_Yas,max_Yas);
            dgvUsers.DataSource = newHobbyUsers;
        }

        private void numMinYas_ValueChanged(object sender, EventArgs e)
        {
            numMaxYas.Value = numMinYas.Value + 1;
        }
    }
}
