using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Project
{
    internal class FinalExam : Exam
    {
        public override void ShowExam(){
            Console.WriteLine("Final Exam");

            // مسؤول عن عرض كل أسئلة الامتحان واختياراتها الفور هيمر علي كل سؤال واحد واحد
            for (int i = 0; i < Questions.Length; i++){
                Console.WriteLine($"\nQuestion {i + 1}: {Questions[i].Body}");

                foreach (Answer answer in Questions[i].Answers)
                {
                    Console.WriteLine($"{answer.AnswerId}: {answer.AnswerText}");
                }
            }
        }
    }
}
