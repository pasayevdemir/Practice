using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Exam
    {
        public List<Question> questions = new List<Question>();
        public string Message { get; set; }
        public bool QuestionAdd(Question question)
        {
            if (question != null)
            {
                Message = "Sual əlavə olundu.";
                questions.Add(question);
                return true;
            }
            Message = "Sual əlavə olunmadı.";
            return false;
        }
        public bool QuestionsShow()
        {
            int count = 0;
            Console.Clear();
            foreach (var question in questions)
            {
                count++;
                Console.WriteLine($"Sual {count}: {question.Text}");
                Console.WriteLine($"Sual ID: {question.Id}");
                Console.WriteLine($"A: {question.FifthQuestion}");
                Console.WriteLine($"B: {question.SecondQuestion}");
                Console.WriteLine($"C: {question.ThirdQuestion}");
                Console.WriteLine($"D: {question.FifthQuestion}");
            }
            if (count == 0)
            {
                Message = "Sual yoxdur!";
                return false;
            }
            return true;
        }
        public bool QuestionRemove(int id)
        {
            var question = questions.FirstOrDefault(x => x.Id == id);
            if (question != null)
            {
                Message = "Sual Silindi!!";
                return questions.Remove(question);
            }
            else
            {
                Message = "Sual tapılmadı!!";
                return false;
            }
        }
        public void StartExam()
        {
            int correctUserAnswer = 0;
            int wrongUserAnswer = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                Console.Clear();
                
            start:
                Console.WriteLine($"Sual {i + 1}: {questions[i].Text}");
                Console.WriteLine($"A: {questions[i].FifthQuestion}");
                Console.WriteLine($"B: {questions[i].SecondQuestion}");
                Console.WriteLine($"C: {questions[i].ThirdQuestion}");
                Console.WriteLine($"D: {questions[i].FifthQuestion}");
                if (
                    char.TryParse(Console.ReadLine().ToUpper(), out char userVarinat) &&
                    userVarinat >= 65 && userVarinat <= 69
                   )
                {
                    if (questions[i].CorrectVariant == userVarinat)
                    {
                        correctUserAnswer++;
                    }
                    else
                    {
                        wrongUserAnswer++;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Simvol düzgün daxil edilməyib!!");
                    goto start;
                }
            }
            Console.WriteLine("Düzgün cavabaların sayı: {0}  Səhv cavabaların sayı: {1}",
                correctUserAnswer, wrongUserAnswer);
        }

    }
}
