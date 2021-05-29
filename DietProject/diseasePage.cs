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
    public partial class diseasePage : Form
    {
        public diseasePage()
        {
            InitializeComponent();
        }
        private void diseasePage_Load(object sender, EventArgs e)
        {
            getDgwData();
        }
        public void getDgwData()
        {
            DiseaseManager diseaseManager = new DiseaseManager(new EfDiseaseDal());
            Dgw_DiseaseTable.DataSource = diseaseManager.GetAll();
            Dgw_DiseaseTable.Columns[0].Width = 40;
            Dgw_DiseaseTable.Columns[1].Width = 75;
            Dgw_DiseaseTable.Columns[0].HeaderText = "Id";
            Dgw_DiseaseTable.Columns[1].HeaderText = "Hastalık Adı";
            Dgw_DiseaseTable.Columns[2].HeaderText = "Açıklama";
        }

        private void DeleteDisease()
        {
            DiseaseManager diseaseManager = new DiseaseManager(new EfDiseaseDal());
            diseaseManager.Delete(new Disease()
            {
                DiseaseId = Convert.ToInt32(Dgw_DiseaseTable.SelectedCells[0].Value),
                DiseaseName = Dgw_DiseaseTable.SelectedCells[1].Value.ToString(),
                DiseaseDescription = Dgw_DiseaseTable.SelectedCells[2].Value.ToString()
            });
        }

        private void Btn_DeletDeleteDisease_Click(object sender, EventArgs e)
        {
            DeleteDisease();
            MessageBox.Show("Kayıt Silindi!");
            getDgwData();
        }
        private void Btn_addDisease_Click(object sender, EventArgs e)
        {
            addNewDiseasePage addNewDiseasePage = new addNewDiseasePage();
            addNewDiseasePage.ShowDialog();
        }
        private void Btn_UpdateDisease_Click(object sender, EventArgs e)
        {
            addNewDiseasePage addNewDiseasePage = new addNewDiseasePage(new Disease()
            {
                DiseaseId = Convert.ToInt32(Dgw_DiseaseTable.SelectedCells[0].Value),
                DiseaseName = Dgw_DiseaseTable.SelectedCells[1].Value.ToString(),
                DiseaseDescription = Dgw_DiseaseTable.SelectedCells[2].Value.ToString()
            });
            addNewDiseasePage.ShowDialog();
        }
    }
}
