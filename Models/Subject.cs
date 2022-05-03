using System.ComponentModel.DataAnnotations;

namespace CourseAPI.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        public int? Number { get; set; }
    }
}
