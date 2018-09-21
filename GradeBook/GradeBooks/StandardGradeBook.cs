namespace GradeBook.GradeBooks
{
    // Represents the definition of a standard grade book
    public class StandardGradeBook : BaseGradeBook
    {
        // Constructor of the StandardGradeBook
        public StandardGradeBook(string name)
            : base(name)
        {
            Type = Enums.GradeBookType.Standard;
        }
    }
}
