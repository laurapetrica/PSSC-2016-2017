using Models.StudentModel.Behavior;
using Models.UniversityModel;
using Models.UniversityModel.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.ProfessorModel;

namespace Models.StudentModel
{

    enum StudyYearValue
    {
        I,
        II,
        III,
        IV
    };

    class SubjectsPerYear
    {
        private StudyYearValue studyYear;

        private HashSet<Subject> allocatedSubjects;

        public SubjectsPerYear()
        {
            allocatedSubjects = new HashSet<Subject>();
        }

        public SubjectsPerYear(StudyYearValue studyYear, HashSet<Subject> allocatedSubjects)
        {
            this.studyYear = studyYear;
            this.allocatedSubjects = allocatedSubjects;
        }

        #region Getters and Setters
        internal StudyYearValue StudyYear
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

        internal HashSet<Subject> AllocatedSubjects
        {
            get
            {
                return allocatedSubjects;
            }

            set
            {
                allocatedSubjects = value;
            }
        }
        #endregion
    }
}
