using Models;

namespace Account
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private void FillTable()
        {

            var data = DB.DataBase.users;
            int i = 0;
            dtTable.Rows.Clear();
            if (dtTable.Rows.Count < data.Count)
                dtTable.Rows.Add(data.Count - dtTable.Rows.Count);
            foreach (var item in data)
            {
                dtTable.Rows[i].Cells[0].Value = item.ID;
                dtTable.Rows[i].Cells[1].Value = item.UserName ;
                dtTable.Rows[i].Cells[2].Value = item.Email;
                dtTable.Rows[i].Cells[3].Value = item.Password;
                i++;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
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
                        newUser.UserName = txtUserName.Text;
                        newUser.Email = txtEmail.Text;
                        newUser.Password = txtPassword.Text;
                        DB.DataBase.users.Add(newUser);
                        MessageBox.Show("İstifadəçi əlavə olundu");
                        FillTable();
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

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            var data = DB.DataBase.users.Find(x => x.UserName == txtBxDeletedUser.Text);
            if (data != null)
            {
                DB.DataBase.users.Remove(data);
                FillTable();
                MessageBox.Show("Silindi");
                return;
            }
            MessageBox.Show("İstifadəçi tapılmadı!!");
        }
    }
}
