using Busienss.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DietProject
{
    public partial class addNewNutritionistPage : Form
    {
        public addNewNutritionistPage()
        {
            InitializeComponent();
        }
        public addNewNutritionistPage(UserInformation userInformation)
        {
            AccountManager accountManager = new AccountManager(new EfAccountDal());
            accountManager.Get(userInformation.Id);
            InitializeComponent();

            Tx_tcnumber.Text = userInformation.Tc_No;
            Tx_tcnumber.Enabled = false;
            Tb_accountName.Enabled = false;
            Tx_Name.Text = userInformation.Name;
            Tx_Surname.Text = userInformation.Surname;
            if (userInformation.Gender == Rb_male.Text)
            {
                Rb_male.Checked = true;
            }
            else
            {
                Rb_male.Checked = true;
            }
            Dtp_DateOfBirth.Value = userInformation.DateOfBirth;
            selectCity(Convert.ToInt32(userInformation.City));
            Tb_accountName.Text = accountManager.Get(userInformation.Id).AccountName;
            Tb_accountPass.Text = accountManager.Get(userInformation.Id).AccountPassword;
           
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        { 
            AddNutritionsitInformation();
            
        }

        private void AddAccount(int Id)
        {
            Account account = new Account()
            {
                Id = Id,
                AccountName = Tb_accountName.Text,
                AccountPassword = Tb_accountPass.Text,
                AccountType = 2
            };
            AccountManager accountManager = new AccountManager(new EfAccountDal());
            accountManager.Add(account);
            
            MessageBox.Show("Kayıt Tamamlandı!");
        }

        private void AddNutritionsitInformation()
        {
            UserInformationManager userInformationManager = new UserInformationManager(new EfUserInformationDal());
            string Rb_Gender;
            if (Rb_male.Checked == true)
            {
                Rb_Gender = Rb_male.Text;
            }
            else
            {
                Rb_Gender = Rb_fermale.Text;
            }
            UserInformation patient = new UserInformation()
            {

                Tc_No = Tx_tcnumber.Text,
                Name = Tx_Name.Text,
                Surname = Tx_Surname.Text,
                Gender = Rb_Gender,
                DateOfBirth = Dtp_DateOfBirth.Value.Date,
                City = Cb_citys.SelectedIndex,
            };
            userInformationManager.Add(patient);
            AddAccount(userInformationManager.Get(patient.Tc_No).Id);

            var mfrm = (nutritionistPage)Application.OpenForms["nutritionistPage"];
            mfrm.GetDgwData();
        }

        private void Cb_citys_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addNewNutritionistPage_Load(object sender, EventArgs e)
        {
            if (Cb_citys.Items.Count == 0)
            {
                GetCitys();
            }
        }
        private void GetCitys()
        {
            Cb_citys.Items.Clear();
            CityManager cityManager = new CityManager(new EfCityDal());
            foreach (var city in cityManager.GetAll())
            {
                Cb_citys.Items.Add(city.CityName);
            }
        }
        private void selectCity(int selectItem)
        {
            GetCitys();
            Cb_citys.SelectedIndex = selectItem;
        }
        private void UserInformation_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
