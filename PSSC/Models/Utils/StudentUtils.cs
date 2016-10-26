using Models.StudentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Utils
{
    class StudentUtils
    {
        public static double calculateAverageGrade(List<Grade> grades, AssessmentType assessmentType, double activityProportion)
        {
            double averageGrade = 0.0d;

            Grade activityGrade = grades.First(grade => grade.gradeType == GradeType.Activity);

            switch (assessmentType)
            {
                case AssessmentType.Exam:

                    Grade examGrade = grades.First(grade => grade.gradeType == GradeType.Exam);

                    if (grades.Any(grade => grade.gradeType == GradeType.ExamIncreased))
                    {
                        examGrade = grades.First(grade => grade.gradeType == GradeType.ExamIncreased);
                    }

                    averageGrade = activityGrade.value * activityProportion + examGrade.value * (1 - activityProportion);

                    break;

                case AssessmentType.Distributed:

                    Grade distributed1Grade = grades.First(grade => grade.gradeType == GradeType.Distributed_1);

                    Grade distributed2Grade = grades.First(grade => grade.gradeType == GradeType.Distributed_2);

                    if (grades.Any(grade => grade.gradeType == GradeType.Distributed_1_Increased))
                    {
                        distributed1Grade = grades.First(grade => grade.gradeType == GradeType.Distributed_1_Increased);
                    }

                    if (grades.Any(grade => grade.gradeType == GradeType.Distributed_2_Increased))
                    {
                        distributed2Grade = grades.First(grade => grade.gradeType == GradeType.Distributed_2_Increased);
                    }

                    averageGrade = activityGrade.value * activityProportion + ((distributed1Grade.value + distributed2Grade.value) / 2) * (1 - activityProportion);

                    break;
            }

            return averageGrade;
        }
    }
}
