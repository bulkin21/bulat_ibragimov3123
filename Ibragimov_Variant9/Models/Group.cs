namespace Ibragimov_Variant9.Models
{
    public class Group
    {
        public int GroupId { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Course { get; set; }

        public int SpecialtyId { get; set; }

        public Specialty Specialty { get; set; } = null!;

        public bool IsDeleted { get; set; }
    }
}
