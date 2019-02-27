using System;

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

            if (base.Students.Count > 5)
            {
                throw new InvalidOperationException();
            }

            return letterGrade;
        }
    }
}
