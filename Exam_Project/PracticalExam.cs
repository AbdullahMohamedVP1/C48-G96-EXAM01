using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Project
{
    internal class PracticalExam : Exam
    {
        public override void ShowExam(){
            Console.WriteLine("Practical Exam");

            //يعتبر نفس كود الفاينال 

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}: {Questions[i].Body}");

                foreach (Answer answer in Questions[i].Answers)
                {
                    Console.WriteLine($"{answer.AnswerId}: {answer.AnswerText}");
                }
            }
        }
    }
}
