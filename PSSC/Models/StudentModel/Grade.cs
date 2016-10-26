using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.StudentModel
{
    enum GradeType
    {
        Exam,
        ExamIncreased,

        Distributed_1,
        Distributed_1_Increased,

        Distributed_2,
        Distributed_2_Increased,

        Activity
    }

    class Grade
    {
        public byte value { get; private set; }
        public GradeType gradeType { get; private set; }
        public Subject subject { get; private set; }

        public Grade(byte value, GradeType gradeType, Subject subject)
        {
            this.value = value;
            this.gradeType = gradeType;
            this.subject = subject;
        }
    }
}
