using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TSS.QBuilder.Entities.Models
{
    [Table("ControlType")]
    public class ControlType
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Control Type Name is required")]
        [MaxLength(50, ErrorMessage = "Control Type Name cannot be more then 50 characters")]
        public string? ControlName { get; set; }
    }
}
