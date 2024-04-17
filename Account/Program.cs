
using Models;
using Accountt = Models.Account;
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
            admin.UserName = "admin";
            admin.Email = "admin@gmail.com";
            admin.Password = "admin";
            DB.DataBase.users.Add(admin);
            Application.Run(new Login());
        }
    }
}