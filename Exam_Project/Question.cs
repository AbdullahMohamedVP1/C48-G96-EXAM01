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
    }
}
