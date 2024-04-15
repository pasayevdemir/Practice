using Account.Models;

namespace Account
{
    internal static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            User admin = new User();
            admin.Login = "admin";
            admin.Email = "admin@gmail.com";
            admin.Password = "admin";
            DB.Database.users.Add(admin);
            Application.Run(new FrmAdmin());
        }
    }
}