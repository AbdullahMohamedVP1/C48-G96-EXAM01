using System;

namespace Exam_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of exam (1 for Practical, 2 for Final):");
            int Etype = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the time for the exam (30 to 180 minutes):");
            int time = int.Parse(Console.ReadLine());
            while (time < 30 || time > 180)
            {
                Console.WriteLine("Invalid time. Please enter the time for the exam (30 to 180 minutes):");
                time = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please enter the number of questions:");
            int NumofObj = int.Parse(Console.ReadLine());

            Exam exam;
            if (Etype == 1)
            {
                exam = new PracticalExam(time, NumofObj);
            }
            else
            {
                exam = new FinalExam(time, NumofObj);
            }

            Question[] questions = new Question[NumofObj];

            for (int i = 0; i < NumofObj; i++)
            {
                Console.WriteLine($"\n--- Question {i + 1} ---");

                if (Etype == 1)
                {
                    //pract
                    questions[i] = CreateMCQQuestion();
                }
                else
                {
                    // الفاينال
                    Console.WriteLine("Enter the type of question (1 for True/False, 2 for MCQ):");
                    int questionType = int.Parse(Console.ReadLine());

                    if (questionType == 1)
                    {
                        questions[i] = CreateTrueFalseQuestion();
                    }
                    else
                    {
                        questions[i] = CreateMCQQuestion();
                    }
                }
            }

            exam.Questions = questions;

            Subject subject = new Subject(1, "OOP");
            subject.CreateExam(exam);

            Console.WriteLine("\nDo You Want To Start Exam (Y | N)");
            string startAnswer = Console.ReadLine();

            if (startAnswer == "Y" || startAnswer == "y")
            {
                subject.Exam.ShowExam();
            }

            Console.WriteLine("\nExam system finished.");
        }

        static MCQQuestion CreateMCQQuestion()
        {
            Console.WriteLine("Please enter the question body:");
            string body = Console.ReadLine();

            Console.WriteLine("Please enter the question mark:");
            int mark = int.Parse(Console.ReadLine());

            Console.WriteLine("Choices of Question:");
            Answer[] answers = new Answer[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Please enter choice number {i + 1}:");
                string choiceText = Console.ReadLine();
                answers[i] = new Answer(i + 1, choiceText);
            }

            Console.WriteLine("Please enter the ID of the correct answer (1 to 4):");
            int correctId = int.Parse(Console.ReadLine());

            MCQQuestion question = new MCQQuestion(body, mark);
            question.Answers = answers;

            //كنت مستخد لمدا ولكن قولت اغيرها علشان ميبقاش ادفانسد
            for (int i = 0; i < question.Answers.Length; i++){
                if (question.Answers[i].AnswerId == correctId)
                {
                    question.RightAnswer = question.Answers[i];
                }
            }

            return question;
        }

        static TrueFalseQuestion CreateTrueFalseQuestion()
        {
            Console.WriteLine("Please enter the question body:");
            string body = Console.ReadLine();

            Console.WriteLine("Please enter the question mark:");
            int mark = int.Parse(Console.ReadLine());

            TrueFalseQuestion question = new TrueFalseQuestion(body, mark);

            Console.WriteLine("Please enter the ID of the correct answer (1 for True, 2 for False):");
            int correctId = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < question.Answers.Length; i++)
            {
                if (question.Answers[i].AnswerId == correctId)
                {
                    question.RightAnswer = question.Answers[i];
                }
            }

            return question;
        }
    }
}