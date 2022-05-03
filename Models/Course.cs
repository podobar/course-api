using System.ComponentModel.DataAnnotations;

namespace CourseAPI.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        public string? Description { get; set; }

        public List<Subject> Subjects { get; set; }
    }
}
