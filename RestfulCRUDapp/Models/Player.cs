using System.ComponentModel.DataAnnotations;

namespace RestfulCRUDapp.Models
{
    public class Player
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Name can not exceed 50 characters long")]
        public string Name { get; set; }

        [Required]
        public string TeamName { get; set; }

        [Required]
        public string Position  { get; set; }
    }
}
