using System.Text;

namespace SignInOrUp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            UserManager manager = new UserManager(new List<User>());
            while (true)
            {
                int value;
                bool isConvert;
                ConsoleChoose(out value, out isConvert);
                if (isConvert)
                {
                    switch (value)
                    {
                        case 1:
                            Console.Clear();

                            User loginUser = new User();

                            Console.WriteLine("UserName: ");
                            loginUser.UserName = Console.ReadLine();
                            Console.WriteLine("Password: ");
                            loginUser.Password = Console.ReadLine();

                            bool isUser = manager.SignIn(loginUser);
                            if (isUser)
                            {
                                Console.Clear();
                                Console.WriteLine("Daxil oldunuz!!");
                                Console.WriteLine("---------------------------------------");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Belə isdifadəçi tapılmadı!!");
                                Console.WriteLine("---------------------------------------");

                            }
                            break;
                        case 2:
                            User regUser = new User();
                            UserConsoleInput(regUser);
                            string repeatPassword = Console.ReadLine();
                            bool isReg = manager.SignUp(regUser, repeatPassword);
                            if (isReg)
                            {
                                Console.Clear();
                                Console.WriteLine("Qeydiyyatdan kecdiniz!!!");
                                Console.WriteLine("---------------------------------------");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Kecmedi!");
                            }
                            break;

                        case 3:
                            Console.Clear();
                            var users = manager.GetAll();
                            int count = 1;
                            if (users != null)
                                foreach (var user in users)
                                {
                                    Console.WriteLine("--------------------------------------");
                                    Console.WriteLine($"                      User: {count}");
                                    Console.WriteLine($"UserName: {user.UserName}");
                                    Console.WriteLine($"UserName: {user.Email}");
                                    Console.WriteLine($"UserName: {user.Password}");
                                }
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Doğru seçim etməmisiniz!!");
                            Console.WriteLine("---------------------------------------");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Düzgün simvol daxil edilməyim!!");
                    Console.WriteLine("---------------------------------------");

                }
            }
        }

        private static void UserConsoleInput(User regUser)
        {
            Console.WriteLine("UserName: ");
            regUser.UserName = Console.ReadLine();
            Console.WriteLine("Email: ");
            regUser.Email = Console.ReadLine();
            Console.WriteLine("Password: ");
            regUser.Password = Console.ReadLine();
            Console.WriteLine("Repeat Password: ");
        }

        private static void ConsoleChoose(out int value, out bool isConvert)
        {
            Console.WriteLine("1--Profilə daxil ol");
            Console.WriteLine("2--Qeydiyyatdan keç");
            Console.WriteLine("3--Qeydiyyatdan keç");

            Console.Write("Seçim edin:");
            string choose = Console.ReadLine();
            isConvert = int.TryParse(choose, out value);
        }
    }
}
