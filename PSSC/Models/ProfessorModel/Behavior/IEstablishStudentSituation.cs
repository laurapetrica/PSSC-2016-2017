using Models.StudentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ProfessorModel.Behavior
{
    interface IEstablishStudentSituation
    {
        void assignGrade(Student student, byte value, GradeType grade, Subject subject);

        void incrementAttendanceCount(Student student, Subject subject);
    }
}
