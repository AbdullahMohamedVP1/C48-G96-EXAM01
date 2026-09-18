using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Project
{
    internal class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public override string ToString()
        {
            return $"{AnswerId}- {AnswerText}";
        }
    }
}
