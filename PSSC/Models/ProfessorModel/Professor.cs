using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.PersonModel;
using Models.UniversityModel;
using Models.StudentModel.Behavior;
using Models.StudentModel;
using Models.ProfessorModel.Behavior;

namespace Models.ProfessorModel
{
    class Professor : Person, IAssign<Subject>, IEstablishStudentSituation
    {
        private Office office;

        private HashSet<Subject> subjects;

        public Professor()
        {
            subjects = new HashSet<Subject>();
        }

        public Professor(string cnp, string firstName, string lastName, Office office) : base(cnp, firstName, lastName)
        {
            this.office = office;
        }


        void IAssign<Subject>.assign(Subject subject)
        {
            subjects.Add(subject);
        }


        void IEstablishStudentSituation.assignGrade(Student student, byte value, GradeType gradeType, Subject subject)
        {
            if (student.AssignedSubjects.Any(subj => subj.Name == subject.Name))
            {
                if (student.Situation.Any(subjectSituation => subjectSituation.Subject.Name == subject.Name))
                {
                    SubjectSituation subjectSituation = student.Situation.First(subjectSit => subjectSit.Subject.Name == subject.Name);

                    // TODO: the constraints of adding grades; see if the evaluation type is distributed or exam, etc.
                    subjectSituation.Grades.Add(new Grade(value, gradeType, subject));
                }
                else
                {
                    SubjectSituation newSubjectSituation = new SubjectSituation(subject, student);

                    newSubjectSituation.Grades.Add(new Grade(value, gradeType, subject));

                    student.Situation.Add(newSubjectSituation);
                }
            }
        }


        void IEstablishStudentSituation.incrementAttendanceCount(Student student, Subject subject)
        {
            if (student.AssignedSubjects.Any(subj => subj.Name == subject.Name))
            {
                if (student.Situation.Any(subjectSituation => subjectSituation.Subject.Name == subject.Name))
                {
                    SubjectSituation subjectSituation = student.Situation.First(subjectSit => subjectSit.Subject.Name == subject.Name);

                    subjectSituation.AttendanceCount += 1;
                }
                else
                {
                    SubjectSituation newSubjectSituation = new SubjectSituation(subject, student);

                    newSubjectSituation.AttendanceCount += 1;

                    student.Situation.Add(newSubjectSituation);
                }
            }
        }


        public void setActivityGradeProportion(double proportion, Subject subject)
        {
            Subject subjectToBeChanged = subjects.First(subj => subj.Name == subject.Name);

            subjectToBeChanged.ActivityProportion = proportion;
        }


        internal HashSet<Subject> Subjects
        {
            get
            {
                return subjects;
            }

            set
            {
                subjects = value;
            }
        }
    }
}
