using Jupiter.BLL;
using Jupiter.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jupiter.UI
{
    public partial class FormAddUserHobby : Form
    {
        UserController _uc;
        HobbyController _hc;
        UserDTO _userDTO;


        public FormAddUserHobby(UserDTO userdto)
        {
            InitializeComponent();
            _uc = new UserController();
            _hc = new HobbyController();
            _userDTO = userdto;
        }


        private void btnHobiAta_Click(object sender, EventArgs e)
        {
            HobbyDTO hobbyDTO = new HobbyDTO();
            
            hobbyDTO.HobbyName = lstCocukHobiler.GetItemText(lstCocukHobiler.SelectedItem);

            int hobbyID = (int)lstCocukHobiler.SelectedValue;
            int haveHobby = _hc.HaveUserHobby(hobbyID);

            if (haveHobby > 0)
            {
                KisininHobileriniGuncelle();
                MessageBox.Show("Kayıt başarılı");
                return;
            }

            ArrayList arraylist = _uc.AddHobbytoUser(hobbyDTO, _userDTO);

            if ((bool)arraylist[0])
            {
                MessageBox.Show(arraylist[1].ToString());
                KisininHobileriniGuncelle();
            }
            else
            {
                MessageBox.Show(arraylist[1].ToString());
            }
        }

        private void btnAnaHobiAta_Click(object sender, EventArgs e)
        {
            HobbyDTO hobbyDTO = new HobbyDTO();

            hobbyDTO.HobbyName = lstAnaHobiler.GetItemText(lstAnaHobiler.SelectedItem);

            int hobbyID = (int)lstAnaHobiler.SelectedValue;
            int haveHobby = _hc.HaveUserHobby(hobbyID);

            if (haveHobby>0)
            {
                KisininHobileriniGuncelle();
                MessageBox.Show("Kayıt başarılı");
                return;
            }
            
            ArrayList arraylist = _uc.AddMainHobbytoUser(hobbyDTO, _userDTO);
            
            if ((bool)arraylist[0])
            {
                MessageBox.Show(arraylist[1].ToString());
                KisininHobileriniGuncelle();
            }
            else
            {
                MessageBox.Show(arraylist[1].ToString());
            }


        }


        private void FormAddUserHobby_Load(object sender, EventArgs e)
        {
            #region ID si verilen kişinin hobileri
            KisininHobileriniGuncelle();
            #endregion
            
            List<HobbyDTO> mainHobbies = _hc.GetMainHobbies();
            lstAnaHobiler.DisplayMember = "HobbyName";
            lstAnaHobiler.ValueMember = "ID";
            lstAnaHobiler.DataSource = mainHobbies;
        }


        private void lstAnaHobiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            HobbyDTO hobyDTO = new HobbyDTO();
            int secilenAnaHobiID = (int)lstAnaHobiler.SelectedValue;
            hobyDTO.UpperID = secilenAnaHobiID;
            List<HobbyDTO> childHobbies = _hc.GetChildHobbies(hobyDTO);
            lstCocukHobiler.DisplayMember = "HobbyName";
            lstCocukHobiler.ValueMember = "ID";
            lstCocukHobiler.DataSource = childHobbies;
        }

        public void KisininHobileriniGuncelle()
        {
            lstUserHobbies.Items.Clear();
            List<JustUserHobbiesDTO> userHobbies = _hc.GetUserHobbies(_userDTO.UserID);
            foreach (var item in userHobbies)
            {
                lstUserHobbies.Items.Add(item.HobbyName);

            }

        }

        private void bthnDeleteHobby_Click(object sender, EventArgs e)
        {
            #region userID ve silinecekHobiName bulundu
            int userID = _uc.GetUser(_userDTO.UserID);

            if (lstUserHobbies.SelectedIndex <= -1)
            {
                return;
            }

            string deleteHobbyname = lstUserHobbies.SelectedItem.ToString();
            #endregion

            try
            {
                int deleted = _hc.DeleteUsersHobby(userID, deleteHobbyname);
                MessageBox.Show("Hobi silindi", "Bilgilendirme");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir nedenden dolayı hobi silinemedi.", "Hata");
            }
            KisininHobileriniGuncelle();
        }
        
    }
}
