using Models.StudentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ProfessorModel;

namespace Models.UniversityModel.Behavior
{
    interface ISubjectsAssignment
    {
        bool assignSubjectToStudent(string subjectName, Student student);

        bool assignSubjectToProfessor(string subjectName, Professor professor);
    }
}
