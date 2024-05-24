using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TSS.QBuilder.Entities.Models
{
    [Table("QuestionSet")]
    public class QuestionSet
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Question Set Name is required")]
        [MaxLength(100, ErrorMessage = "Question Set Name cannot be more then 100 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Question Set Description is required")]
        [MaxLength(255, ErrorMessage = "Question Set Description cannot be more then 255 characters")]
        public string? Description { get; set; }

        public ICollection<Question>? Questions { get; set; }
    }
}
