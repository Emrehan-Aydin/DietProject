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
    public partial class addNewPatientPage_ : Form
    {
        Account Account;
        public addNewPatientPage_()
        {
            InitializeComponent();
        }
        public addNewPatientPage_(Account account)
        {
            InitializeComponent();
            Account = account;
        }
        public addNewPatientPage_(UserInformation patient, Account account)
        {
            InitializeComponent();
            Account = account;
            Tx_tcnumber.Text = patient.Tc_No;
            Tx_patientName.Text = patient.Name;
            Tx_patientSurname.Text = patient.Surname;

            if (patient.Gender == Rb_male.Text)
            {
                Rb_male.Checked = true;
            }
            else
            {
                Rb_male.Checked = true;
            }

            Dtp_DateOfBirth.Value = patient.DateOfBirth;
            PatientReportManager patientReportmanager = new PatientReportManager(new EfPatientReportDal());
            SelectCbItem(patientReportmanager.Get(patient.Id), Convert.ToInt32(patient.City));
        }
        private void SelectCbItem(PatientReport patientReport, int city)
        {
            DietManager dietManager = new DietManager(new EfDietDal());
            DiseaseManager diseasManager = new DiseaseManager(new EfDiseaseDal());
            GetDiets();
            GetCitys();
            GetDiseas();
            Cb_citys.SelectedIndex = city;
            Cb_diet.SelectedItem = dietManager.GetById(patientReport.DietsId).DietName;
            Cb_Diseas.SelectedItem = diseasManager.Get(patientReport.DiseaseId).DiseaseName;
            Tb_Symptom.Text = patientReport.Symptom;
        }
        private void addNewPatientPage__Load(object sender, EventArgs e)
        {
            if (Cb_citys.Items.Count == 0)
            {
                GetDiets();
                GetCitys();
                GetDiseas();
            }
        }
        private void GetDiseas()
        {
            Cb_Diseas.Items.Clear();
            DiseaseManager diseaseManager = new DiseaseManager(new EfDiseaseDal());
            foreach (var diseas in diseaseManager.GetAll())
            {
                Cb_Diseas.Items.Add(diseas.DiseaseName);
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

        private void GetDiets()
        {
            Cb_diet.Items.Clear();
            DietManager dietManager = new DietManager(new EfDietDal());
            foreach (var diet in dietManager.GetAll())
            {
                Cb_diet.Items.Add(diet.DietName);
            }
        }

        private void Cb_citys_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cb_diet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DietManager dietManager = new DietManager(new EfDietDal());
            DietPlanManager dietPlanManager = new DietPlanManager(new EfDietPlanDal());
            Dgw_DietPlan.DataSource = dietPlanManager.Get(dietManager.Get(Cb_diet.SelectedItem.ToString()).DietId);
            Dgw_DietPlan.Columns[0].Visible = false;
            Dgw_DietPlan.Columns[1].Visible = false;
            Dgw_DietPlan.Columns[2].HeaderText = "Günler";
            Dgw_DietPlan.Columns[3].HeaderText = "Kahvaltı";
            Dgw_DietPlan.Columns[4].HeaderText = "Öğle";
            Dgw_DietPlan.Columns[5].HeaderText = "Akşam";

        }

        private void Btn_addNewPatient_Click(object sender, EventArgs e)
        {
            AddPatientUser();

            var mfrm = (patientsPage)Application.OpenForms["patientsPage"];
            mfrm.GetDgwData();

            MessageBox.Show("Kayıt Tamamlandı!");

        }

        private void AddPatientUser()
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
                Name = Tx_patientName.Text,
                Surname = Tx_patientSurname.Text,
                Gender = Rb_Gender,
                DateOfBirth = Dtp_DateOfBirth.Value.Date,
                City = Cb_citys.SelectedIndex,
            };
            userInformationManager.Add(patient);
            PatientReport patientReport = new PatientReport()
            {
                DietsId = Cb_diet.SelectedIndex + 1,
                DiseaseId = Cb_Diseas.SelectedIndex + 1,
                PatientId = userInformationManager.Get(patient.Tc_No).Id,
                Symptom = Tb_Symptom.Text,
                NutritionistId = Account.Id
            };
            PatientReportManager patientReportManager = new PatientReportManager(new EfPatientReportDal());
            patientReportManager.Add(patientReport);
        }
    }
}
