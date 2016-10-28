using System.Collections.Generic;

namespace Models.StudentModel
{

    enum StudyYear
    {
        I,
        II,
        III,
        IV
    };

    class SubjectsPerYear
    {
        private StudyYear studyYear;

        private HashSet<Subject> allocatedSubjects;

        public SubjectsPerYear()
        {
            allocatedSubjects = new HashSet<Subject>();
        }

        public SubjectsPerYear(StudyYear studyYear, HashSet<Subject> allocatedSubjects)
        {
            this.studyYear = studyYear;
            this.allocatedSubjects = allocatedSubjects;
        }

        #region Getters and Setters
        internal StudyYear StudyYear
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
