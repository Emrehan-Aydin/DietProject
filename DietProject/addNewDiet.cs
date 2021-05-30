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
    public partial class addNewDiet : Form
    {
        int dietId=-1;
        List<DietPlan> dietPlan;
        public addNewDiet()
        {
            InitializeComponent();
        }
        public addNewDiet(int Id)
        {
            dietId = Id;
            InitializeComponent();
            DietPlanManager dietPlanManager = new DietPlanManager(new EfDietPlanDal());
            dietPlan = dietPlanManager.Get(dietId);
            DietManager dietManager = new DietManager(new EfDietDal());
            Tb_DietName.Text=     dietManager.GetById(dietId).DietName;
            Tb_DietDescription.Text=  dietManager.GetById(dietId).DietDescription;
            if (dietPlan != null)
            {
                Tb_Pzt_1.Text = dietPlan[0].DietBreakFastDescription;
                Tb_Pzt_2.Text = dietPlan[0].DietLunchDescription;
                Tb_Pzt_3.Text = dietPlan[0].DietDinnerDescription;
                Tb_Sali_1.Text = dietPlan[1].DietBreakFastDescription;
                Tb_Sali_2.Text = dietPlan[1].DietLunchDescription;
                Tb_Sali_3.Text = dietPlan[1].DietDinnerDescription;
                Tb_Carsamba_1.Text = dietPlan[2].DietBreakFastDescription;
                Tb_Carsamba_2.Text = dietPlan[2].DietLunchDescription;
                Tb_Carsamba_3.Text = dietPlan[2].DietDinnerDescription;
                Tb_Persembe_1.Text = dietPlan[3].DietBreakFastDescription;
                Tb_Persembe_2.Text = dietPlan[3].DietLunchDescription;
                Tb_Persembe_3.Text = dietPlan[3].DietDinnerDescription;
                Tb_Cuma_1.Text = dietPlan[4].DietBreakFastDescription;
                Tb_Cuma_2.Text = dietPlan[4].DietLunchDescription;
                Tb_Cuma_3.Text = dietPlan[4].DietDinnerDescription;
                Tb_Cmt_1.Text = dietPlan[5].DietBreakFastDescription;
                Tb_Cmt_2.Text = dietPlan[5].DietLunchDescription;
                Tb_Cmt_3.Text = dietPlan[5].DietDinnerDescription;
                Tb_Pz_1.Text = dietPlan[6].DietBreakFastDescription;
                Tb_Pz_2.Text = dietPlan[6].DietLunchDescription;
                Tb_Pz_3.Text = dietPlan[6].DietDinnerDescription;
            }
        }
        private void Btn_Register_Click(object sender, EventArgs e)
        {
            Diet diet = new Diet();
            diet.DietName = Tb_DietName.Text;
            diet.DietDescription = Tb_DietDescription.Text;
            DietManager dietManager = new DietManager(new EfDietDal());
            if (dietId == -1)
            {
                dietManager.Add(diet);
                dietId =dietManager.Get(diet.DietName).DietId;
            }
            else
            {
                diet.DietId = dietId;
                dietManager.Update(diet);
            }
            addPztDietPlan(dietId);
            addSaliDietPlan(dietId);
            addCarsambaDietPlan(dietId);
            addPersembeDietPlan(dietId);
            addCumaDietPlan(dietId);
            addCmtDietPlan(dietId);
            addPzDietPlan(dietId);

            var mfrm = (dietPage)Application.OpenForms["dietPage"];
            mfrm.GetDgwData();
        }
        private void addPztDietPlan(int dietId)
        {
            DietPlanManager dietPlanManager = new DietPlanManager(new EfDietPlanDal());
            dietPlanManager.Add(new DietPlan()
            {
                DietPlanId = dietId,
                DietPlansDay = "Pazartesi",
                DietBreakFastDescription = Tb_Pzt_1.Text,
                DietLunchDescription = Tb_Pzt_2.Text,
                DietDinnerDescription = Tb_Pzt_3.Text
            });
        }
        private void addSaliDietPlan(int dietId)
        {
            DietPlanManager dietPlanManager = new DietPlanManager(new EfDietPlanDal());
            dietPlanManager.Add(new DietPlan()
            {
                DietPlanId = dietId,
                DietPlansDay = "Sali",
                DietBreakFastDescription = Tb_Sali_1.Text,
                DietLunchDescription = Tb_Sali_2.Text,
                DietDinnerDescription = Tb_Sali_3.Text

            });
        }
        private void addCarsambaDietPlan(int dietId)
        {
            DietPlanManager dietPlanManager = new DietPlanManager(new EfDietPlanDal());
            dietPlanManager.Add(new DietPlan()
            {
                DietPlanId = dietId,
                DietPlansDay = "Çarsamba",
                DietBreakFastDescription = Tb_Carsamba_1.Text,
                DietLunchDescription = Tb_Carsamba_2.Text,
                DietDinnerDescription = Tb_Carsamba_3.Text
            });
        }
        private void addPersembeDietPlan(int dietId)
        {
            DietPlanManager dietPlanManager = new DietPlanManager(new EfDietPlanDal());
            dietPlanManager.Add(new DietPlan()
            {
                DietPlanId = dietId,
                DietPlansDay = "Persembe",
                DietBreakFastDescription = Tb_Persembe_1.Text,
                DietLunchDescription = Tb_Persembe_2.Text,
                DietDinnerDescription = Tb_Persembe_3.Text
            });
        }
        private void addCumaDietPlan(int dietId)
        {
            DietPlanManager dietPlanManager = new DietPlanManager(new EfDietPlanDal());
            dietPlanManager.Add(new DietPlan()
            {
                DietPlanId = dietId,
                DietPlansDay = "Cuma",
                DietBreakFastDescription = Tb_Cuma_1.Text,
                DietLunchDescription = Tb_Cuma_2.Text,
                DietDinnerDescription = Tb_Cuma_3.Text
            });
        }
        private void addCmtDietPlan(int dietId)
        {
            DietPlanManager dietPlanManager = new DietPlanManager(new EfDietPlanDal());
            dietPlanManager.Add(new DietPlan()
            {
                DietPlanId = dietId,
                DietPlansDay = "Cumartesi",
                DietBreakFastDescription = Tb_Cmt_1.Text,
                DietLunchDescription = Tb_Cmt_2.Text,
                DietDinnerDescription = Tb_Cmt_3.Text
            });
        }
        private void addPzDietPlan(int dietId)
        {
            DietPlanManager dietPlanManager = new DietPlanManager(new EfDietPlanDal());
            dietPlanManager.Add(new DietPlan()
            {
                DietPlanId = dietId,
                DietPlansDay = "Pazar",
                DietBreakFastDescription = Tb_Pz_1.Text,
                DietLunchDescription = Tb_Pz_2.Text,
                DietDinnerDescription = Tb_Pz_3.Text
            });
            MessageBox.Show("Kayıt Tamamlandı!");
        }

        private void addNewDiet_Load(object sender, EventArgs e)
        {

        }
    }
}
