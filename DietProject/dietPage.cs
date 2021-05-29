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
    public partial class dietPage : Form
    {
        public dietPage()
        {
            InitializeComponent();
        }

        private void dietPage_Load(object sender, EventArgs e)
        {
            GetDgwData();

        }

        public void GetDgwData()
        {
            DietManager dietManager = new DietManager(new EfDietDal());
            Dgw_DietTable.DataSource = dietManager.GetAll();
            Dgw_DietTable.Columns[0].Width = 40;
            Dgw_DietTable.Columns[1].Width = 75;
            Dgw_DietTable.Columns[0].HeaderText = "Id";
            Dgw_DietTable.Columns[1].HeaderText = "Diyet Adı";
            Dgw_DietTable.Columns[2].HeaderText = "Açıklama";
        }

        private void Btn_addDiet_Click(object sender, EventArgs e)
        {
            addNewDiet addNewDiet = new addNewDiet();
            addNewDiet.ShowDialog();
        }

        private void Btn_UpdateDiet_Click(object sender, EventArgs e)
        {
            Dgw_DietTable.SelectedCells[0].Value.ToString();
            addNewDiet addNewDiet = new addNewDiet(Convert.ToInt32((Dgw_DietTable.SelectedCells[0].Value)));
            addNewDiet.ShowDialog();
        }

        private void Btn_DeleteDiet_Click(object sender, EventArgs e)
        {
            DietManager dietManager = new DietManager(new EfDietDal());
            dietManager.Delete(new Diet()
            {
                DietId = Convert.ToInt32(Dgw_DietTable.SelectedCells[0].Value),
                DietName = Dgw_DietTable.SelectedCells[1].Value.ToString(),
                DietDescription = Dgw_DietTable.SelectedCells[0].Value.ToString()
            });
            MessageBox.Show("Kayıt Silindi!");
            GetDgwData();

        }
    }
}
