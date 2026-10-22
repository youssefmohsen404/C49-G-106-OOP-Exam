using System;
using System.Collections.Generic;
using System.Text;

namespace C49_G_106_OOP_Exam
{
    internal class FinalExam : Exam
    {
        public FinalExam(string examTime, int numbersOfQeustion, Question[] question)
            : base(examTime, numbersOfQeustion, question)
        {
        }

        
        public override void ShowExam()
        {
            Console.WriteLine("===== FINAL EXAM RESULT =====");
            int grade = 0, total = 0;

            for (int i = 0; i < question.Length; i++)
            {
                Console.WriteLine();
                question[i].ShowQuestion();
                Console.WriteLine($"Your answer: {studentAnswers[i]?.answerText ?? "(not answered)"}");

                total += question[i].mark;
                if (studentAnswers[i] != null && studentAnswers[i] == question[i].rightAnswer)
                    grade += question[i].mark;
            }

            Console.WriteLine();
            Console.WriteLine($"Grade: {grade} / {total}");
        }
    }
}