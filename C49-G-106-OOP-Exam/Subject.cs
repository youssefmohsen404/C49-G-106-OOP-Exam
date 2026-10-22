using System;
using System.Collections.Generic;
using System.Text;

namespace C49_G_106_OOP_Exam
{
    internal class Subject
    {
        
        public Subject(int subjectId, string subjectName) : this(subjectId, subjectName, null)
        {
        }

        public Subject(int subjectId, string subjectName, Exam? examOfSubject)
        {
            this.subjectId = subjectId;
            this.subjectName = subjectName;
            this.examOfSubject = examOfSubject;
        }

        public int subjectId { get; set; }
        public string subjectName { get; set; }
        public Exam? examOfSubject { get; set; }

        // 1 = Final , 2 = Practical
        public void CreateExam(int examType)
        {
            Exam exam;

            if (examType == 1)
            {
                Question[] questions =
                {
                    new TrueOrFalse("Q1)", "C# supports multiple class inheritance.", 5, false),
                    new TrueOrFalse("Q2)", "An abstract class can contain implemented methods.", 5, true),
                    new Mcq("Q3)", "Which keyword prevents a class from being inherited?", 10,
                        new Answers[] { new Answers(1, "static"), new Answers(2, "sealed"), new Answers(3, "abstract") }, 2),
                    new Mcq("Q4)", "Which interface defines the natural sort order of a class?", 10,
                        new Answers[] { new Answers(1, "ICloneable"), new Answers(2, "IDisposable"), new Answers(3, "IComparable") }, 3),
                };
                exam = new FinalExam("60 mins", questions.Length, questions);
            }
            else if (examType == 2)
            {
                Question[] questions =
                {
                    new Mcq("Q1)", "Which keyword forces derived classes to implement a method?", 10,
                        new Answers[] { new Answers(1, "virtual"), new Answers(2, "override"), new Answers(3, "abstract") }, 3),
                    new Mcq("Q2)", "Which keyword calls the parent constructor?", 10,
                        new Answers[] { new Answers(1, "this"), new Answers(2, "base"), new Answers(3, "super") }, 2),
                    new Mcq("Q3)", "What does ICloneable.Clone() return?", 10,
                        new Answers[] { new Answers(1, "object"), new Answers(2, "void"), new Answers(3, "string") }, 1),
                };
                exam = new PracticalExam("20 mins", questions.Length, questions);
            }
            else
            {
                throw new ArgumentException("Exam type must be 1 (Final) or 2 (Practical).");
            }

            exam.subject = this;      
            examOfSubject = exam;
        }

        public override string ToString()
        {
            return $" subject id : {subjectId} , subject name {subjectName} , exam of the subject {examOfSubject}";
        }
    }

}