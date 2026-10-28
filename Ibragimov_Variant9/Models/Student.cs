namespace Ibragimov_Variant9.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public int GroupId { get; set; }

        public Group Group { get; set; } = null!;

        public bool IsDeleted { get; set; }
    }
}
