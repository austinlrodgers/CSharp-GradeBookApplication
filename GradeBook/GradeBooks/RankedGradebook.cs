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
            if (base.Students.Count < 5) throw new InvalidOperationException("Ranked Grading needs at least 5 students");

            char letterGrade = 'F';
            var threshold = (int)Math.Ceiling(base.Students.Count * 0.2);
            var grades = base.Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();

            if (grades[threshold - 1] <= averageGrade)
            {
                letterGrade = 'A';
            }

            return letterGrade;
        }
    }
}
