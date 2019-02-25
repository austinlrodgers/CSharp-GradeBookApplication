

namespace GradeBook.GradeBooks
{
    public class StandardGradebook : BaseGradeBook
    {
        public StandardGradebook(string name) :base(name)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
