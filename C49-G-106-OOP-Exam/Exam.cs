using System;
using System.Collections.Generic;
using System.Text;

namespace C49_G_106_OOP_Exam
{
    internal abstract class Exam
    {
        protected Exam(string examTime, int numbersOfQeustion, Question[] question)
        {
            this.examTime = examTime;
            this.numbersOfQeustion = numbersOfQeustion;
            this.question = question;
            studentAnswers = new Answers?[question.Length];
        }

        public string examTime { get; set; }
        public int numbersOfQeustion { get; set; }
        public Question[] question { get; set; }
        public Answers?[] studentAnswers { get; set; }   
        public Subject? subject { get; set; }           

        
        public void TakeExam()
        {
            Console.WriteLine($"Subject: {subject?.subjectName} | Time: {examTime} | Questions: {numbersOfQeustion}");
            Console.WriteLine();

            for (int i = 0; i < question.Length; i++)
            {
                question[i].ShowQuestion();
                studentAnswers[i] = ReadAnswer(question[i]);
                Console.WriteLine();
            }
        }

        private static Answers ReadAnswer(Question q)
        {
            while (true)
            {
                Console.Write("Your answer (id): ");
                if (int.TryParse(Console.ReadLine(), out int id))
                {
                    foreach (Answers a in q.answersList)
                        if (a.answerId == id) return a;
                }
                Console.WriteLine("Invalid answer, try again.");
            }
        }

        public abstract void ShowExam();

        public override string ToString()
        {
            return $"{GetType().Name} , time : {examTime} , questions : {numbersOfQeustion}";
        }
    }

}