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
        bool distributeSubjectsPerStudyYear(StudyYear studyYear, HashSet<Subject> subjects);

        HashSet<Subject> getSubjects(StudyYear studyYear);
    }
}
