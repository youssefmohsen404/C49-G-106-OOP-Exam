namespace C49_G_106_OOP_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1, "oop");

            int choice;
            do
            {
                Console.Write("Choose exam type (1 = Final, 2 = Practical): ");
            } while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2));

            Console.WriteLine();
            subject.CreateExam(choice);

            if (subject.examOfSubject == null) return;

            subject.examOfSubject.TakeExam();     
            subject.examOfSubject.ShowExam();    
        }
    }
}