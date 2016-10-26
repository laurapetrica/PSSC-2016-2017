using Models.PersonModel;
using Models.UniversityModel.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.StudentModel;
using Models.ProfessorModel;
using Models.StudentModel.Behavior;

namespace Models.UniversityModel
{
    class Deanship : ISubjectsDistribution, ISubjectsAssignment, IReportsGenerator
    {
        private Person[] deans;

        private List<SubjectsPerYear> definedSubjects;

        public Deanship()
        {
            deans = new Person[3];

            definedSubjects = new List<SubjectsPerYear>();
        }

        internal Person[] Deans
        {
            get
            {
                return deans;
            }

            set
            {
                deans = value;
            }
        }


        bool ISubjectsAssignment.assignSubjectToProfessor(string subjectName, Professor professor)
        {
            foreach(SubjectsPerYear subjectsPerYear in definedSubjects)
            {
                Subject subjectToAssign = subjectsPerYear.AllocatedSubjects.First(subject => subject.Name.Equals(subjectName));

                if (subjectToAssign == null)
                {
                    continue;
                }
                else
                {
                    ((IAssign<Subject>)professor).assign(subjectToAssign);
                    return true;
                }
            }

            return false;
        }


        bool ISubjectsAssignment.assignSubjectToStudent(string subjectName, Student student)
        {
            foreach (SubjectsPerYear subjectsPerYear in definedSubjects)
            {
                Subject subjectToAssign = subjectsPerYear.AllocatedSubjects.First(subject => subject.Name.Equals(subjectName));

                if (subjectToAssign == null)
                {
                    continue;
                }
                else
                {
                    ((IAssign<Subject>)student).assign(subjectToAssign);
                    return true;
                }
            }

            return false;
        }


        bool ISubjectsDistribution.distributeSubjectsPerStudyYear(StudyYearValue studyYear, HashSet<Subject> subjects)
        {
            bool subjectsAlreadyDefined = definedSubjects.Any(subjectsPerYear => subjectsPerYear.StudyYear == studyYear);

            if (subjectsAlreadyDefined)
            {
                return false;
            }
            else
            {
                definedSubjects.Add(new SubjectsPerYear(studyYear, subjects));
                return true;
            }
        }


        HashSet<Subject> ISubjectsDistribution.getSubjects(StudyYearValue studyYear)
        {
            bool subjectsDefined = definedSubjects.Any(subjectsPerYear => subjectsPerYear.StudyYear == studyYear);

            if (subjectsDefined)
            {
                SubjectsPerYear subjectsPerYear = definedSubjects.First(subjects => subjects.StudyYear == studyYear);

                return subjectsPerYear.AllocatedSubjects;
            }

            return null;
        }


        public List<SubjectsPerYear> getDefinedSubjects()
        {
            return definedSubjects;
        }


        public double getAverageGrade(Student student, Subject subject)
        {
            return student.calculateAverageGrade(subject);
        }


        StringBuilder IReportsGenerator.generateReport(List<Student> students, ReportType reportType)
        {
            throw new NotImplementedException();
        }
    }
}
