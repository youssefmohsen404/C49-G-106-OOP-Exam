using System;
using System.Collections.Generic;
using System.Text;

namespace C49_G_106_OOP_Exam
{
    internal class TrueOrFalse : Question
    {
        
        public TrueOrFalse(string header, string body, int mark, bool correctValue)
            : base(header, body, mark,
                   new Answers[] { new Answers(1, "True"), new Answers(2, "False") },
                   correctValue ? 1 : 2)
        {

        }
    }
}