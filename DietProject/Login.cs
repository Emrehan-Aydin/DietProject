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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            AccountManager accountManager = new AccountManager(new EfAccountDal());
            account = accountManager.Check(Tx_accountName.Text, Tx_accountPass.Text);
            GetPage(account);
        }
        public void GetPage(Account account)
        {
            if (account == null)
            {
                MessageBox.Show("Kullanıcı veya Şifreniz hatalı!");
            }
            else if (account.AccountType == 1)
            {
                adminIndex AdminPage = new adminIndex(account);
                AdminPage.ShowDialog();
            }
            else if (account.AccountType == 2)
            {
                patientsPage NutritionistPage = new patientsPage(account);
                NutritionistPage.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bilinmeyen hesap türü!");
            }

        }
    }
}
