using Profil = Models.Account;

namespace Account
{
    public partial class FrmAccount : Form
    {
        private List<TextBox> boxes = new List<TextBox>();
        private UserManager _manager = new UserManager();
        private Profil _account;
        public FrmAccount(Profil account)
        {
            InitializeComponent();
            _account = account;
        }

        private void FrmAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            boxes.Add(TxtBxUserName);
            boxes.Add(TxtBxEmail);
            boxes.Add(TxtBxPassword);
            TextBoxFill();
        }

        private void TextBoxFill()
        {
            TxtBxUserName.Text = _account.Profile.UserName;
            TxtBxEmail.Text = _account.Profile.Email;
            TxtBxPassword.Text = _account.Profile.Password;
        }

        private void TextBoxClear()
        {
            foreach (var box in boxes)
            {
                box.Text = "";
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            TextBoxClear();
            BoxsEnabled();
        }

        private void BoxsEnabledFalse()
        {
            foreach (var box in boxes)
            {
                box.Enabled = false;
            }
        }

        private void BoxsEnabled()
        {
            foreach (var box in boxes)
            {
                box.Enabled = true;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var oldProfile = _account.Profile;
            oldProfile.UserName = TxtBxUserName.Text;
            oldProfile.Email = TxtBxEmail.Text;
            oldProfile.Password = TxtBxPassword.Text;
            _manager.Update(oldProfile);
            BoxsEnabledFalse();
            TextBoxFill();
        }
    }
}
