using Models.ProfessorModel;
using Models.UniversityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.StudentModel
{
    enum AssessmentType
    {
        Exam,
        Distributed
    };

    class Subject
    {
        private string name;

        private byte creditsNo;

        private AssessmentType assessmentType;

        private double activityProportion;

        private StudyYearValue studyYear;

        public Subject(string name, byte creditsNo, AssessmentType assessmentType, double activityProportion, StudyYearValue studyYear)
        {
            this.name = name;
            this.creditsNo = creditsNo;
            this.assessmentType = assessmentType;
            this.activityProportion = activityProportion;
            this.studyYear = studyYear;
        }

        #region Getters and Setters
        public double ActivityProportion
        {
            get
            {
                return activityProportion;
            }

            set
            {
                activityProportion = value;
            }
        }

        internal AssessmentType AssessmentType
        {
            get
            {
                return assessmentType;
            }

            set
            {
                assessmentType = value;
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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

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
        #endregion
    }
}
