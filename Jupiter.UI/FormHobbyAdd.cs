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
    public partial class FormHobbyAdd : Form
    {
        HobbyController _hc;
        int _upperID;
        List<HobbyDTO> mainHobbies;

        public FormHobbyAdd()
        {
            InitializeComponent();
            _hc = new HobbyController();
        }
        private void FormHobbyAdd_Load(object sender, EventArgs e)
        {
            ComboBoxHobbyFill();
        }

        private void ComboBoxHobbyFill()
        {
            mainHobbies = _hc.GetHobies();
            HobbyDTO item = new HobbyDTO();
            item.HobbyName = "Ana hobi ekle";
            mainHobbies.Insert(0, item);

            cmbAnaHobiler.DisplayMember = "HobbyName";
            cmbAnaHobiler.ValueMember = "ID";
            cmbAnaHobiler.DataSource = mainHobbies;
            cmbAnaHobiler.SelectedIndex = -1;            
        }

        private void btnHobiEkle_Click(object sender, EventArgs e)
        {
            if (cmbAnaHobiler.SelectedIndex < 0)
            {
                MessageBox.Show("Hobi kategorisi boş geçilemez!", "Hata");
                return;
            }
            if (txtHobiAdi.Text == "")
            {
                MessageBox.Show("Hobi adı boş geçilemez!", "Hata");
                return;
            }            
            
            HobbyDTO hobbyDTO = new HobbyDTO();
            hobbyDTO = _hc.GetHobbyName(txtHobiAdi.Text);
            if (hobbyDTO.IsNew == false)
            {
                MessageBox.Show("Bu hobi zaten kayıtlı!","Hata");
                return;
            }


            HobbyDTO dto = new HobbyDTO();
            dto.HobbyName = txtHobiAdi.Text;

            if (cmbAnaHobiler.SelectedIndex>0)
            {
                dto.UpperID = _upperID;
            }

            if (_hc.AddHobby(dto))
            {
                MessageBox.Show("Kayıt başarılı");
                ComboBoxHobbyFill();
                txtHobiAdi.Text = "";
            }
            else
            {
                MessageBox.Show("Bir hata nedeniyle kayıt yapılamadı");
            }
        }

        private void txtHobiAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        
        private void cmbAnaHobiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbAnaHobiler.SelectedIndex>0)
            {
                _upperID = (int)cmbAnaHobiler.SelectedValue;
            }
            
        }
    }
}
