using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string FirstQuestion { get; set; }
        public string SecondQuestion { get; set; }
        public string ThirdQuestion { get; set; }
        public string FourthQuestion { get; set; }
        public string FifthQuestion { get; set; }
        public char CorrectVariant { get; set; }
    }
}
