using Account.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account
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

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBxLogin.Text != "" && txtBxPassword.Text != "")
            {
                if (txtBxPassword.Text.Length > 3)
                {
                    if (CheckUser(txtBxLogin.Text, txtBxPassword.Text))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Səhv Profil adı və ya Parol daxil etmisiniz!!");
                    }
                }
                else
                {
                    MessageBox.Show("Parol 3 simvoldan az olmamalıdır");
                }
            }
            else
            {
                MessageBox.Show("Xanalar doldurulmalıdır!!");

            }

        }

        private bool CheckUser(string login, string password)
        {
            foreach (User user in DB.Database.users)
            {
                if (login == user.Login && password == user.Password)
                {
                    MessageBox.Show("Giriş uğurla başa çatdırıldı!");
                    return true;
                }
            }
            return false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

    }
}
