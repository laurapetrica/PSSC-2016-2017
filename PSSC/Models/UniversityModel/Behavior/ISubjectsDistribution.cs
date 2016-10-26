using Models.StudentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.UniversityModel.Behavior
{
    interface ISubjectsDistribution
    {
        bool distributeSubjectsPerStudyYear(StudyYearValue studyYear, HashSet<Subject> subjects);

        HashSet<Subject> getSubjects(StudyYearValue studyYear);
    }
}
