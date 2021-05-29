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
    public partial class nutritionistPage : Form
    {
        public nutritionistPage()
        {
            InitializeComponent();
        }
        private void Btn_addNutritionist_Click(object sender, EventArgs e)
        {
            addNewNutritionistPage addNewNutritionistPage = new addNewNutritionistPage();
            addNewNutritionistPage.ShowDialog();
        }

        private void nutritionistPage_Load(object sender, EventArgs e)
        {
            GetDgwData();
        }

        public void GetDgwData()
        {
            UserInformationManager userInformationManager = new UserInformationManager(new EfUserInformationDal());
            Dgw_DoctorTable.DataSource = userInformationManager.GetNutritionistDetail();
            Dgw_DoctorTable.Columns[0].HeaderText = "Kimlik Numarası";
            Dgw_DoctorTable.Columns[1].HeaderText = "Ad";
            Dgw_DoctorTable.Columns[2].HeaderText = "Soyad";
            Dgw_DoctorTable.Columns[3].HeaderText = "Cinsiyet";
            Dgw_DoctorTable.Columns[4].HeaderText = "Doğum Yeri";
            Dgw_DoctorTable.Columns[5].HeaderText = "Doğum Tarihi";
        }

        private void Btn_UpdateNutritionist_Click(object sender, EventArgs e)
        {
            if (Dgw_DoctorTable.RowCount != 0)
            {
                UserInformationManager userInformationManager = new UserInformationManager(new EfUserInformationDal());
                addNewNutritionistPage addNewNutritionistPage = new addNewNutritionistPage(userInformationManager.Get(Dgw_DoctorTable.SelectedCells[0].Value.ToString()));
                addNewNutritionistPage.ShowDialog();
            }
        }

        private void Btn_DeleteNutritionist_Click_1(object sender, EventArgs e)
        {
            if (Dgw_DoctorTable.Rows.Count != 0)
            {
                UserInformationManager userInformationManager = new UserInformationManager(new EfUserInformationDal());
                userInformationManager.Delete(userInformationManager.Get(Dgw_DoctorTable.SelectedCells[0].Value.ToString()));
                GetDgwData();
                MessageBox.Show("Diyetisyen Silindi!");
            }
        }
    }
}
