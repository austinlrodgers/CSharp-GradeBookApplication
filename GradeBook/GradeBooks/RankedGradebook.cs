using System;
using System.Linq;

namespace GradeBook.GradeBooks
{
    public class RankedGradebook : BaseGradeBook
    {
        public RankedGradebook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            char letterGrade = 'F';
            var threshold = (int)Math.Ceiling(base.Students.Count * 0.2);
            var grades = base.Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();

            if (base.Students.Count < 5) throw new InvalidOperationException("Ranked Grading needs at least 5 students");

            if (grades[threshold - 1] <= averageGrade)
            {
                letterGrade = 'A';
            }
            else if (grades[(threshold * 2) - 1] <= averageGrade)
            {
                letterGrade = 'B';
            }
            else if (grades[(threshold * 3) - 1] <= averageGrade)
            {
                letterGrade = 'C';
            }
            else if (grades[(threshold * 4) - 1] <= averageGrade)
            {
                letterGrade = 'D';
            }

            return letterGrade;
        }
    }
}
