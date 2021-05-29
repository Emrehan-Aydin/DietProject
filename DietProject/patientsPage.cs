using Busienss.Concrete;
using Core.Utils.Reporter.Concrete;
using CreateReports.Concrete;
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
    public partial class patientsPage : Form
    {
        Account account;
        public patientsPage()
        {
            InitializeComponent();
        }
        public patientsPage(Account Account)
        {
            InitializeComponent();
            account = Account;
        }

        private void patientsPage_Load(object sender, EventArgs e)
        {
            FirtReporthealth.Checked = true;
            Cb_Fileformat.SelectedIndex = 1;
            GetDgwData();
        }

        public void GetDgwData()
        {
            PatientReportManager userReportManager = new PatientReportManager(new EfPatientReportDal());
            Dgw_PatientTable.DataSource = userReportManager.GetPatientDetail();
            Dgw_PatientTable.Columns[0].HeaderText = "Kimlik Numarası";
            Dgw_PatientTable.Columns[1].HeaderText = "Ad";
            Dgw_PatientTable.Columns[2].HeaderText = "Soyad";
            Dgw_PatientTable.Columns[3].HeaderText = "Cinsiyet";
            Dgw_PatientTable.Columns[4].HeaderText = "Şehir";
            Dgw_PatientTable.Columns[5].HeaderText = "Doğum Tarihi";
            Dgw_PatientTable.Columns[6].HeaderText = "Tanı";
            Dgw_PatientTable.Columns[7].HeaderText = "Diyetisyen";
            Dgw_PatientTable.Columns[8].HeaderText = "Diyet Yöntemi";
            Dgw_PatientTable.Columns[9].HeaderText = "Şikayet";
        }

        private void Btn_addNewPatient_Click(object sender, EventArgs e)
        {
            addNewPatientPage_ addNewPatientPage = new addNewPatientPage_(account);
            addNewPatientPage.ShowDialog();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (Dgw_PatientTable.RowCount != 0)
            {
                UserInformationManager userInformationManager = new UserInformationManager(new EfUserInformationDal());
                addNewPatientPage_ addNewPatientPage_ = new addNewPatientPage_(userInformationManager.Get(Dgw_PatientTable.SelectedCells[0].Value.ToString()), account);
                addNewPatientPage_.ShowDialog();
            }
        }

        private void Btn_DeletePatient_Click(object sender, EventArgs e)
        {
            if (Dgw_PatientTable.RowCount != 0)
            {
                UserInformationManager userInformationManager = new UserInformationManager(new EfUserInformationDal());
                PatientReportManager patientReportManager = new PatientReportManager(new EfPatientReportDal());
                patientReportManager.Delete(patientReportManager.Get(userInformationManager.Get(Dgw_PatientTable.SelectedCells[0].Value.ToString()).Id));
                GetDgwData();
                MessageBox.Show("Hasta Silindi!");
            }
        }

        private void Btn_Report_Click(object sender, EventArgs e)
        {
            UserInformationManager userInformationManager = new UserInformationManager(new EfUserInformationDal());
            PatientReportManager patientReportManager = new PatientReportManager(new EfPatientReportDal());
            DietManager dietManager = new DietManager(new EfDietDal());
            DietPlanManager dietPlanManager = new DietPlanManager(new EfDietPlanDal());
            List<DietPlan> dietPlan = dietPlanManager.Get(dietManager.Get(Dgw_PatientTable.SelectedCells[8].Value.ToString()).DietId);
            if (Cb_Fileformat.SelectedIndex == 0)
            {
                CreateJsonReport create = new CreateJsonReport();
                if (FirtReporthealth.Checked == true)
                    create.createPatientReportJson(patientReportManager.GetByTcPatientDetail(Dgw_PatientTable.SelectedCells[0].Value.ToString()), dietPlan);
                else
                    create.createPatientReportReverseJson(patientReportManager.GetByTcPatientDetail(Dgw_PatientTable.SelectedCells[0].Value.ToString()), dietPlan);
              MessageBox.Show("Json Raporu Oluşturuldu");
            }
            else if (Cb_Fileformat.SelectedIndex == 1)
            {
                bool secim;
                if (FirtReporthealth.Checked == true)
                {
                    secim = true;
                    CreateHtmlReport create = new CreateHtmlReport(patientReportManager.GetByTcPatientDetail(Dgw_PatientTable.SelectedCells[0].Value.ToString()), dietPlan, secim);
                }
                else
                {
                    secim = false;
                    CreateHtmlReport create = new CreateHtmlReport(patientReportManager.GetByTcPatientDetail(Dgw_PatientTable.SelectedCells[0].Value.ToString()), dietPlan, secim);
                }
                MessageBox.Show("HTML Raporu Oluşturuldu");
            }
            else
            {
                MessageBox.Show("Dosya Formatı Seçiniz!");
            }


        }
    }
}
