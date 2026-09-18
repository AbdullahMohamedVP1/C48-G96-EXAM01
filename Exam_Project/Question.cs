using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Project
{
    internal class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Answer[] Answers { get; set; }
        public Answer RightAnswer { get; set; } // علشان عرف انهي الاجابه الصح

        public override string ToString()
        {
            return $"{Header}: {Body}";
        }
    }
}
