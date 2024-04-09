using System.Reflection;
using System.Text;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Exam exam = new Exam();
            bool isContinue = true;
            while (isContinue)
            {
                Console.WriteLine("*********************************************");
                Console.WriteLine("1-Sual əlavə et");
                Console.WriteLine("2-Sualları ekrana yazdır");
                Console.WriteLine("3-İmtahan ver");
                Console.WriteLine("4-Sual sil");
                Console.WriteLine("5-Proqramdan çıx");
                Console.WriteLine("*********************************************");
                Console.WriteLine();

                Console.Write("1-5 arası bir seçim edin:");
                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            Console.Clear();
                            var question = InputQuestionAdd(exam.questions.Capacity);
                            if (!exam.QuestionAdd(question))
                            {
                                WriteConsoleMessage(exam.Message, ConsoleColor.Red);
                            }
                            else
                            {

                                Console.Clear();
                                WriteConsoleMessage(exam.Message, ConsoleColor.Green);
                            }
                            break;
                        case 2:
                            if (!exam.QuestionsShow())
                            {
                                WriteConsoleMessage(exam.Message, ConsoleColor.Red);
                            }
                            else
                                Console.ReadKey();
                            break;
                        case 3:
                            exam.StartExam();
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.Write("Silinəcək sualın id-i daxil et: ");
                            int.TryParse(Console.ReadLine(), out int id);
                            if (exam.QuestionRemove(id))
                            {
                                WriteConsoleMessage(exam.Message, ConsoleColor.Green);
                            }
                            WriteConsoleMessage(exam.Message, ConsoleColor.Red);
                            break;
                        case 5:
                            isContinue = false;
                            break;
                        default:
                            WriteConsoleMessage("Seçim doğru deyil!!", ConsoleColor.Red);
                            break;
                    }
                }
                else
                {
                    WriteConsoleMessage("Səhv simvol daxil edilib!", ConsoleColor.Red);
                }
            }
        }

        private static void WriteConsoleMessage(string message, ConsoleColor color)
        {
            Console.Clear();
            Console.ForegroundColor = color;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(message);
            Console.WriteLine("---------------------------------------------");
            Console.ResetColor();
        }

        private static Question InputQuestionAdd(int id)
        {
            id++;
            Console.WriteLine("---------------------------------------------");

            Console.Write("Sualı daxil et: ");
            string text = Console.ReadLine();
            Console.Write("Variant A: ");
            string firstQuestion = Console.ReadLine();
            Console.Write("Variant B: ");
            string secondQuestion = Console.ReadLine();
            Console.Write("Variant C: ");
            string thirdQuestion = Console.ReadLine();
            Console.Write("Variant D: ");
            string fourthQuestion = Console.ReadLine();
            Console.Write("Variant E: ");
            string fifthQuestion = Console.ReadLine();

            Console.Write("Doğru cavab: ");

            char.TryParse(Console.ReadLine().ToUpper(), out char correctVariant);

            if (
                id > 0 && correctVariant != '\0' &&
                !string.IsNullOrWhiteSpace(text) &&
                !string.IsNullOrWhiteSpace(firstQuestion) &&
                !string.IsNullOrWhiteSpace(secondQuestion) &&
                !string.IsNullOrWhiteSpace(thirdQuestion) &&
                !string.IsNullOrWhiteSpace(fourthQuestion) &&
                !string.IsNullOrWhiteSpace(fifthQuestion)
                )
            {
                Question question = new Question
                {
                    Id = id,
                    Text = text,
                    FirstQuestion = firstQuestion,
                    SecondQuestion = secondQuestion,
                    ThirdQuestion = thirdQuestion,
                    FourthQuestion = fourthQuestion,
                    FifthQuestion = fifthQuestion,
                    CorrectVariant = correctVariant
                };
                return question;
            }
            else
            {
                return null;
            }
        }
    }
}
