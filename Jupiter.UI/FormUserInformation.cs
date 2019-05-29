using Jupiter.BLL;
using Jupiter.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jupiter.UI
{
    public partial class FormUserInformation : Form
    {
        List<string> phoneNumbers;
        HobbyController _hc;
        UserController _uc;
        public FormUserInformation()
        {
            InitializeComponent();
            _uc = new UserController();
            _hc = new HobbyController();
            phoneNumbers = new List<string>();
        }
        int kayıtlıUserID;

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            if (txtTCno.Text=="")
            {
                MessageBox.Show("Hatalı TC Numarası Girdiniz , Lütfen Kontrol Ediniz..");
                return;
            }

            UserDTO userdto = new UserDTO();

            userdto = _uc.GetUserByTC(txtTCno.Text);
            bool EmailDogruMu = EmailKontrol(txtEmail.Text);

            if (userdto.IsNew == false)
            {
                MessageBox.Show(userdto.TC_No + " TC li kullanıcı hesabıyla devam edıyorusunuz");
                FormAddUserHobby frm = new FormAddUserHobby(userdto);
                frm.MdiParent = this;
                frm.FormClosed += Frm_FormClosed;
                grbKisiselBilgiler.Visible = false;
                btnDevamEt.Visible = false;
                btnGuncelle.Visible = false;
                btnTemizle.Visible = false;
                frm.Show();
                //this.Hide();
            }//kayıtlı ise diğer forma devam et


            else
            {
                if (EmailDogruMu != true)
                {
                    MessageBox.Show("Lütfen E-mail formatını doğru bir şekilde girdiğinize emin olup tekrar deneyiniz");
                    return;

                }
                
                else if (cmbUyruk.SelectedItem.ToString() == "TC")
                {

                    if (txtTCno.TextLength != 11)
                    {
                        MessageBox.Show("Hatalı TC Numarası Girdiniz , Lütfen Kontrol Ediniz..");
                        return;
                    }
                    userdto.TC_No = txtTCno.Text;
                }
                else if (cmbUyruk.SelectedItem.ToString() == "Diğer")
                {

                    if (txtTCno.TextLength != 9)
                    {
                        MessageBox.Show("Hatalı Pasaport Numarası Girdiniz , Lütfen Kontrol Ediniz..");
                        return;
                    }
                    userdto.Passport = txtTCno.Text;
                }
               

                if (txtAd.Text == "" || txtSoyad.Text == "")
                {
                    MessageBox.Show("Ad veya Soyad Kısmı Boş Geçilemez");
                    return;
                }
                if (lstTelefon.Items.Count==0 && txtPhone.TextLength != 10)
                {
                    MessageBox.Show("Eksik veya Hatalı Telefon Numarası Girdiniz , Lütfen Kontrol Ediniz..");
                    return;
                }


                userdto.FirstName = txtAd.Text;
                userdto.LastName = txtSoyad.Text;
                userdto.Adress = txtAdress.Text;
                userdto.Email = txtEmail.Text;
                userdto.Birthdate = dtpDogumTarihi.Value;

                if (lstTelefon.Items.Count==0 && txtPhone.TextLength==10)
                {
                    phoneNumbers.Add(txtPhone.Text);
                }

                foreach (var item in phoneNumbers)
                {

                    PhoneDTO phonedto = new PhoneDTO();
                    phonedto.PhoneNumber = item;
                    userdto.Phones.Add(phonedto);
                }

                #region Cinsiyet Atama
                if (rdbKadin.Checked)
                {
                    userdto.Gender = (int)ClassEnum.Gender.Kadin;
                }
                else if (rdbErkek.Checked)
                {
                    userdto.Gender = (int)ClassEnum.Gender.Erkek;
                }
                else
                {
                    userdto.Gender = (int)ClassEnum.Gender.Diğer;
                }
                #endregion

               


                if (_uc.AddUser(userdto))
                {
                    MessageBox.Show("Kayıt Başarılı");
                    FormAddUserHobby frm = new FormAddUserHobby(userdto);
                    frm.MdiParent = this;
                    frm.FormClosed += Frm_FormClosed;
                    grbKisiselBilgiler.Visible = false;
                    btnDevamEt.Visible = false;
                    btnGuncelle.Visible = false;
                    btnTemizle.Visible = false;
                    frm.Show();
                    //this.Hide();
                }
                else { MessageBox.Show("Hata Kayıt Başarısız!");}
            } // kayıtlı değil ise  userdto içine kullanıcıdan alınan değerleri atama 


        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            grbKisiselBilgiler.Visible = true;
            btnDevamEt.Visible = true;
            btnGuncelle.Visible = true;
            btnTemizle.Visible = true;
            Temizle();
        }

        private void FormUserInformation_Load(object sender, EventArgs e)
        {
            cmbUyruk.Items.Add("TC");
            cmbUyruk.Items.Add("Diğer");
            cmbUyruk.Text = "TC";
            lstTelefon.Visible = false;
            btnGuncelle.Visible = false;
            dtpDogumTarihi.MaxDate = DateTime.Now.AddYears(-18);
        }


        #region Form Ekran Kısıtlamalar

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtTCno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmbUyruk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUyruk.SelectedItem.ToString() == "TC")
            {
                lblUyruk.Text = "TC No :";
                txtTCno.MaxLength = 11;
                txtTCno.Clear();
            }
            else if (cmbUyruk.SelectedItem.ToString() == "Diğer")
            {
                lblUyruk.Text = "Pasaport No :";
                txtTCno.MaxLength = 9;
                txtTCno.Clear();

            }
        }

        private void txtUstHobiID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtHobiName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
        #endregion

        private void txtTCno_TextChanged(object sender, EventArgs e)
        {



        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {

            lstTelefon.Visible = true;
            btnDeletePhone.Visible = true;
        
     


            if (phoneNumbers.Contains(txtPhone.Text))

            {
                MessageBox.Show("Bu Numara Zaten Eklendi");
                return;
            }


            phoneNumbers.Add(txtPhone.Text);

            lstTelefon.Items.Add(txtPhone.Text);
            txtPhone.Text = "";




        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            phoneNumbers.Clear();


            if (txtTCno.TextLength != 11)
            {
                MessageBox.Show("TC No Eksik");
                return;
            }
            if (cmbUyruk.SelectedItem.ToString() == "TC")
            {
                if (txtTCno.TextLength == 11)
                {
                    UserDTO userdto = new UserDTO();
                    userdto = _uc.GetUserByTC(txtTCno.Text);



                    #region Girilen TC Kayıtli ise


                    if (userdto.IsNew == false)
                    {
                        btnDeletePhone.Visible = true;
                        kayıtlıUserID = userdto.UserID;


                        txtAd.Text = userdto.FirstName;
                        txtSoyad.Text = userdto.LastName;
                        txtTCno.Text = userdto.TC_No;
                        txtEmail.Text = userdto.Email;
                        txtAdress.Text = userdto.Adress;
                        if (userdto.Birthdate!=null)
                        {
                        dtpDogumTarihi.Value = userdto.Birthdate.Value;
                        }
                        txtEmail.Text = userdto.Email;

                        if (userdto.Gender == (byte)ClassEnum.Gender.Kadin)
                        {
                            rdbKadin.Checked = true;
                        }
                        else if (userdto.Gender == (byte)ClassEnum.Gender.Erkek)
                        {
                            rdbErkek.Checked = true;
                        }
                        else if (userdto.Gender == (byte)ClassEnum.Gender.Diğer)
                        {
                            rdbDiger.Checked = true;
                        }

                        if (userdto.Phones.Count > 0) { lstTelefon.Visible = true; }
                        lstTelefon.DisplayMember = "PhoneNumber";
                        lstTelefon.ValueMember = "PhoneID";

                        List<PhoneDTO> telListe = userdto.Phones.ToList();

                        foreach (var item in telListe)
                        {
                            lstTelefon.Items.Add(item.PhoneNumber);
                            phoneNumbers.Add(item.PhoneNumber);
                        }
                        cmbUyruk.Enabled = false;
                        dtpDogumTarihi.Enabled = false;

                        foreach (var item in pnlCinsiyet.Controls)
                        {
                            if (item is RadioButton)
                            {
                                ((RadioButton)item).Enabled = false;
                            }
                        }
                        txtTCno.Enabled = false;
                        txtAd.Enabled = false;
                        txtSoyad.Enabled = false;
                        MessageBox.Show(userdto.TC_No + " TC li Kişi Zaten Kayıtlı");
                        btnGuncelle.Visible = true;
                    } 
                    #endregion
                    pnlBilgiler.Visible = true;


                }
            }
            if (cmbUyruk.SelectedItem.ToString() == "Diğer")
            {
                if (txtTCno.TextLength == 9)
                {
                    // SORGU AT AYNI PASAPORT NO VARMI DİYE
                    MessageBox.Show("Pasaport Var");
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            lstTelefon.Items.Clear();
            phoneNumbers.Clear();
            btnDeletePhone.Visible = false;

            lstTelefon.Visible = false;
            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            txtTCno.Enabled = true;
            btnGuncelle.Visible = false;
            foreach (Control item in pnlBilgiler.Controls)
            {

                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
            pnlBilgiler.Visible = false;

            cmbUyruk.Enabled = true;
            dtpDogumTarihi.Enabled = true;
            foreach (RadioButton item in pnlCinsiyet.Controls)
            {
                item.Enabled = true;
            }
            txtTCno.Text = "";
        }

        private void lstTelefon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPhone.Text = lstTelefon.GetItemText(lstTelefon.SelectedItem);
            
         
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            UserDTO guncellenecekUserDTO = new UserDTO();
            guncellenecekUserDTO.UserID = kayıtlıUserID;
            guncellenecekUserDTO.TC_No = txtTCno.Text;
            guncellenecekUserDTO.FirstName = txtAd.Text;
            guncellenecekUserDTO.LastName = txtSoyad.Text;
            guncellenecekUserDTO.Birthdate = dtpDogumTarihi.Value;

            if (rdbErkek.Checked)
            {
                guncellenecekUserDTO.Gender = (byte)ClassEnum.Gender.Erkek;
            }
            else if (rdbKadin.Checked)
            {
                guncellenecekUserDTO.Gender = (byte)ClassEnum.Gender.Kadin;
            }
            else if (rdbDiger.Checked)
            {
                guncellenecekUserDTO.Gender = (byte)ClassEnum.Gender.Diğer;
            }

            guncellenecekUserDTO.Email = txtEmail.Text;
            guncellenecekUserDTO.Adress = txtAdress.Text;

            List<PhoneDTO> guncelTel = new List<PhoneDTO>();

            foreach (var item in phoneNumbers)
            {
                PhoneDTO phoneDTO = new PhoneDTO();
                phoneDTO.PhoneNumber = item;
                guncelTel.Add(phoneDTO);

            }
            guncellenecekUserDTO.Phones = guncelTel;


            if (_uc.UpdateUser(guncellenecekUserDTO))
            {
                MessageBox.Show("Güncelleme İşlemi Başarıyla Tamamlandı");
            }
            else
            {
                MessageBox.Show("Hata Güncelleme Yapılamadı");
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.TextLength == 10)
            {
                btnAddPhone.Visible = true;
            }
            else
            {
                btnAddPhone.Visible = false;
            }

            if (phoneNumbers.Count >= 3)
            {
                txtPhone.Enabled = false;
                btnAddPhone.Enabled = false;
                txtPhone.Text = "Maksimum Telefon sayısı 3'tür";
                return;
            }

            else
            {
                txtPhone.Enabled = true;
                btnAddPhone.Enabled = true;
            }
        }

        private void btnDeletePhone_Click(object sender, EventArgs e)
        {
            txtPhone.Text = "";
            if (lstTelefon.SelectedIndex<0)
            {
                return;
            }
            string silinecekTelefonNo = lstTelefon.SelectedItem.ToString();
            try
            {
                foreach (string item in phoneNumbers)
                {
                    if (item == silinecekTelefonNo)
                    {
                        phoneNumbers.Remove(item);

                    }
                }
            }
            catch (Exception)
            {

               
            }

            btnAddPhone.Enabled = true;
            txtPhone.Enabled = true;


            lstTelefon.Items.Clear();

            foreach (var item in phoneNumbers)
            {
                lstTelefon.Items.Add(item);
            }

            if (lstTelefon.Items.Count > 0)
            {
                btnDeletePhone.Visible = true;
            }
            else
            {
                btnDeletePhone.Visible = false;
            }
        }

        private bool EmailKontrol(string email)
        {

            var regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            bool isValid = Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
            return isValid;

        }
    }
}
