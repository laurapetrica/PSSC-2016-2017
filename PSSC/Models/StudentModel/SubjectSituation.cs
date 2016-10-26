using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.StudentModel
{
    enum EvaluationResult
    {
        Passed,
        Not_passed
    }

    class SubjectSituation
    {
        private Subject subject;

        private List<Grade> grades;

        private byte attendanceCount;

        private EvaluationResult evaluationResult;

        private Student student;

        public SubjectSituation(Subject subject, Student student)
        {
            this.subject = subject;

            grades = new List<Grade>();

            attendanceCount = 0;

            this.student = student;
        }

        internal List<Grade> Grades
        {
            get
            {
                return grades;
            }

            set
            {
                grades = value;
            }
        }

        internal Subject Subject
        {
            get
            {
                return subject;
            }

            set
            {
                subject = value;
            }
        }

        public byte AttendanceCount
        {
            get
            {
                return attendanceCount;
            }

            set
            {
                attendanceCount = value;
            }
        }

        internal Student Student
        {
            get
            {
                return student;
            }

            set
            {
                student = value;
            }
        }

        internal EvaluationResult EvaluationResult
        {
            get
            {
                return evaluationResult;
            }

            set
            {
                evaluationResult = value;
            }
        }
    }
}
