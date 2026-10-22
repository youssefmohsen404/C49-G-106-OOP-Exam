using System;
using System.Collections.Generic;
using System.Text;

namespace C49_G_106_OOP_Exam
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(string examTime, int numbersOfQeustion, Question[] question)
            : base(examTime, numbersOfQeustion, question)
        {
        }

       
        public override void ShowExam()
        {
            Console.WriteLine("===== PRACTICAL EXAM - RIGHT ANSWERS =====");

            for (int i = 0; i < question.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{question[i].header} {question[i].body}");
                Console.WriteLine($"Right answer: {question[i].rightAnswer?.answerText}");
            }
        }
    }
}