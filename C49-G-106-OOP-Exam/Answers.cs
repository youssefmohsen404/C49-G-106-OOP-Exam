using System;
using System.Collections.Generic;
using System.Text;

namespace C49_G_106_OOP_Exam
{
    internal class Answers : ICloneable
    {
        public Answers(int answerId, string answerText)
        {
            this.answerId = answerId;
            this.answerText = answerText;
        }

        public int answerId { get; set; }
        public string answerText { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"answer id : {answerId} , answer text : {answerText}";
        }

    }
}