namespace GradeBook.GradeBooks
{
    // Represents the definition of a ranked grade book
    public class RankedGradeBook : BaseGradeBook
    {
        // Constructor of the RankedGradeBook
        public RankedGradeBook(string name)
            : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
    }
}
