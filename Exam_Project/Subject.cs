using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Project
{
    internal class Subject{
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public void CreateExam(Exam exam){
            Exam = exam;    
        }
    }
}
