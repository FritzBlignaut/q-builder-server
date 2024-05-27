using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TSS.QBuilder.Entities.Models
{
    [Table("Question")]
    public class Question
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Question Text is required")]
        [MaxLength(255, ErrorMessage = "Question Text cannot be more then 255 characters")]
        public string? QuestionText { get; set; }

        [MaxLength(255, ErrorMessage = "Question Sub Text cannot be more then 255 characters")]
        public string? QuestionSubText { get; set; }

        [ForeignKey(nameof(ControlType))]
        public Guid ControlTypeId { get; set; }
        public ControlType? ControlType { get; set; }

        [ForeignKey(nameof(QuestionSet))]
        public Guid QuestionSetId { get; set; }
        public QuestionSet? QuestionSet { get; set; }
    }
}
