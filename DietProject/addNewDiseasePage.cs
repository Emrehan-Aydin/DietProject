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
    public partial class addNewDiseasePage : Form
    {
        Disease disease = new Disease();
        public addNewDiseasePage()
        {
            InitializeComponent();
        }
        public addNewDiseasePage(Disease Disease)
        {
            InitializeComponent();
            disease = Disease;
            Tx_DiseaseName.Text = disease.DiseaseName;
            Tx_DiseaseDescription.Text = disease.DiseaseDescription;
        }

        private void addNewDiseasePage_Load(object sender, EventArgs e)
        {

        }

        private void Btn_addNewDisease_Click(object sender, EventArgs e)
        {
            saveDisease();
        }

        private void saveDisease()
        {
            DiseaseManager diseaseManager = new DiseaseManager(new EfDiseaseDal());
            disease.DiseaseName = Tx_DiseaseName.Text;
            disease.DiseaseDescription = Tx_DiseaseDescription.Text;
            diseaseManager.Add(disease);

            var mfrm = (diseasePage)Application.OpenForms["diseasePage"];
            mfrm.getDgwData();
            MessageBox.Show("Kayıt Tamamlandı!");
        }
    }
}
