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
    public partial class adminIndex : Form
    {
        public adminIndex()
        {
            InitializeComponent();
        }
        public adminIndex(Account account)
        {
            InitializeComponent();

        }

        private void adminIndex_Load(object sender, EventArgs e)
        {

        }
        private void GetForm(Form form)
        {
            panel2.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(form);
            form.Show();
        }
        private void Btn_nutritionistPage_Click_1(object sender, EventArgs e)
        {
            nutritionistPage nutritionistPage = new nutritionistPage();
            GetForm(nutritionistPage);
        }
        private void Btn_dietPage_Click(object sender, EventArgs e)
        {
            dietPage dietPage = new dietPage();
            GetForm(dietPage);
        }

        private void Btn_diseasePage_Click(object sender, EventArgs e)
        {
            diseasePage diseasePage = new diseasePage();
            GetForm(diseasePage);
        }
    }
}
