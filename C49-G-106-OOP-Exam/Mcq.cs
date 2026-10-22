using System;
using System.Collections.Generic;
using System.Text;

namespace C49_G_106_OOP_Exam
{
    internal class Mcq : Question
    {
        public Mcq(string header, string body, int mark, Answers[] answersList, int rightAnswerId)
            : base(header, body, mark, answersList, rightAnswerId)
        {

        }
    }
}