using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Project
{
    internal abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }
        public abstract void ShowExam();       //يعرض الامتحان للمستخدم
    }
}
