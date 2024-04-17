using Models;
using Accountt = Models.Account;
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
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBxLogin.Text != "" && txtBxPassword.Text != "")
            {
                if (txtBxPassword.Text.Length > 3)
                {
                    if (CheckUser(txtBxLogin.Text, txtBxPassword.Text, out User model))
                    {
                        if (txtBxLogin.Text == "admin")
                        {
                            FrmAdmin frmAdmin = new FrmAdmin();
                            this.Hide();
                            frmAdmin.Show();
                        }
                        else
                        {
                            if (model is not null)
                            {
                                Accountt accountt = new Accountt(model);
                                FrmAccount frmAccount = new FrmAccount(accountt);
                                this.Hide();
                                frmAccount.Show();
                            }
                        }

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

        private bool CheckUser(string login, string password, out User model)
        {
            foreach (User user in DB.DataBase.users)
            {
                if (login == user.UserName && password == user.Password)
                {
                    MessageBox.Show("Giriş uğurla başa çatdırıldı!");
                    model = user;
                    return true;
                }
            }
            model = new User();
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
