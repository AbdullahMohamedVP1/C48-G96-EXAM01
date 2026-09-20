using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace Exam_Project
{
    internal abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        public Exam() { }

        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
        }

        public abstract void ShowExam();       //يعرض الامتحان للمستخدم

        public object Clone()
        {
            // بنعمل نسخة من الامتحان عشان لو غيرنا في النسخة الجديدة الأصلية متتأثرش// بنعمل نسخة من الامتحان عشان لو غيرنا في النسخة الجديدة الأصلية متتأثرش
            Exam clone = (Exam)this.MemberwiseClone();

            if (this.Questions != null)
            {
                clone.Questions = (Question[])this.Questions.Clone();
            }

            return clone;
        }

        public int CompareTo(Exam other)
        {
            if (other == null)
            {
                return 1;
            }


            // بقارن الوقت بتاع الامتحانين ببعض عشان أرتبهم لو عايز اعمل سورت
            if (this.Time > other.Time)
            {
                return 1;
            }
            else if (this.Time < other.Time)
            {
                return -1;
            }
            else
            {
                return 0;
            } 
        }

        public override string ToString()
        {
            return "Exam - Time: " + Time + " mins, Questions: " + NumberOfQuestions;
        }
    }
}

