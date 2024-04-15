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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void lblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (
                txtUserName.Text != "" &&
                txtEmail.Text != "" &&
                txtPassword.Text != "" &&
                txtRepPassword.Text != ""
                )
            {
                if (txtPassword.Text.Length > 3 && txtRepPassword.Text.Length > 3)
                {
                    if (txtPassword.Text == txtRepPassword.Text)
                    {
                        User newUser = new User();
                        newUser.Login = txtUserName.Text;
                        newUser.Email = txtEmail.Text;
                        newUser.Password = txtPassword.Text;
                        DB.Database.users.Add(newUser);
                        MessageBox.Show("Qeydiyyat tamamlandı");
                        this.Hide();
                        btnLogin_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Təkrar parol əsas parola bərəabər deyil :)");
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
