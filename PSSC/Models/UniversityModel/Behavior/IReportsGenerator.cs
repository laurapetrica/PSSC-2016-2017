using Models.StudentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.UniversityModel.Behavior
{
    enum ReportType
    {
        INDIVIDUAL_SUBJECT_AVERAGE_GRADE,
        GENERAL_AVERAGE_GRADE,
        EVALUATION_RESULT
    }

    interface IReportsGenerator
    {
        StringBuilder generateReport(List<Student> students, ReportType reportType);
    }
}
