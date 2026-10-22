using System;
using System.Collections.Generic;
using System.Text;

namespace C49_G_106_OOP_Exam
{
    internal class Question : ICloneable, IComparable<Question>
    {

        //Attributes
        public string header { get; set; }
        public string body { get; set; }
        public int mark { get; set; }
        public Answers[] answersList { get; set; }
        public Answers? rightAnswer { get; set; }


        
        public Question(string header, string body, int mark, Answers[] answersList, int rightAnswerId)
        {
            this.header = header;
            this.body = body;
            this.mark = mark;
            this.answersList = answersList;

            
            foreach (Answers answer in answersList)
            {
                if (answer.answerId == rightAnswerId)
                    rightAnswer = answer;
            }
        }

        public void GetAnswers(Answers[] answers)
        {
            foreach (var answer in answers)
            {
                Console.WriteLine($"   {answer.answerId}. {answer.answerText}");
            }
        }

        public void ShowQuestion()
        {
            Console.WriteLine($"{header} {body}  [{mark} marks]");
            GetAnswers(answersList);
        }

        
        public int CompareTo(Question? other)
        {
            return other == null ? 1 : mark.CompareTo(other.mark);
        }

        public object Clone()
        {
            Question copy = (Question)MemberwiseClone();
            copy.answersList = new Answers[answersList.Length];
            for (int i = 0; i < answersList.Length; i++)
                copy.answersList[i] = (Answers)answersList[i].Clone();

            int index = rightAnswer == null ? -1 : Array.IndexOf(answersList, rightAnswer);
            copy.rightAnswer = index >= 0 ? copy.answersList[index] : null;
            return copy;
        }

        public override string ToString()
        {
            return $"header : {header} , body: {body} , mark:{mark}";
        }
    }
}