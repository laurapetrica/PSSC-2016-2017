using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.PersonModel;
using Models.UniversityModel;
using Models.StudentModel.Behavior;
using Models.Utils;

namespace Models.StudentModel
{
    class Student : Person, IAssign<Subject>
    {
        private int sid;

        private Faculty faculty;

        private byte groupNo;

        private byte subgroupNo;

        private byte creditsNo;

        private StudyYearValue studyYear;

        private List<SubjectSituation> situation;

        private HashSet<Subject> assignedSubjects;

        public Student(string cnp, string firstName, string lastName, int sid, byte groupNo, byte subgroupNo, StudyYearValue studyYear) : base(cnp, firstName, lastName)
        {
            this.sid = sid;
            this.groupNo = groupNo;
            this.subgroupNo = subgroupNo;
            this.studyYear = studyYear;
            creditsNo = 0;
        }


        void IAssign<Subject>.assign(Subject subject)
        {
            if (creditsNo + subject.CreditsNo > 60)
            {
                return;
            }

            assignedSubjects.Add(subject);

            creditsNo += subject.CreditsNo;
        }


        public double calculateAverageGrade(Subject subject)
        {
            double averageGrade = 0;

            if (assignedSubjects.Any(sub => sub.Name.Equals(subject.Name)))
            {
                SubjectSituation subjectSituation = situation.First(subSituation => subSituation.Subject.Name.Equals(subject.Name));

                averageGrade = StudentUtils.calculateAverageGrade(subjectSituation.Grades, subject.AssessmentType, subject.ActivityProportion);
            }

            return averageGrade;
        }


        public List<Grade> getGradesSituation(Subject subject)
        {
            // not ok => the situations should exist in another class and should be from all the study years and from all the students
            SubjectSituation subjectSituation = situation.Find(subjectSit => subjectSit.Subject.Name.Equals(subject.Name));

            return subjectSituation.Grades;
        }

        #region Getters and Setters
        public int SID
        {
            get
            {
                return sid;
            }

            set
            {
                sid = value;
            }
        }

        internal Faculty Faculty
        {
            get
            {
                return faculty;
            }

            set
            {
                faculty = value;
            }
        }

        public byte GroupNo
        {
            get
            {
                return groupNo;
            }

            set
            {
                groupNo = value;
            }
        }

        public byte SubgroupNo
        {
            get
            {
                return subgroupNo;
            }

            set
            {
                subgroupNo = value;
            }
        }

        public StudyYearValue StudyYear
        {
            get
            {
                return studyYear;
            }

            set
            {
                studyYear = value;
            }
        }

        internal List<SubjectSituation> Situation
        {
            get
            {
                return situation;
            }

            set
            {
                situation = value;
            }
        }

        internal HashSet<Subject> AssignedSubjects
        {
            get
            {
                return assignedSubjects;
            }

            set
            {
                assignedSubjects = value;
            }
        }

        public byte CreditsNo
        {
            get
            {
                return creditsNo;
            }

            set
            {
                creditsNo = value;
            }
        }
        #endregion
    }


}
