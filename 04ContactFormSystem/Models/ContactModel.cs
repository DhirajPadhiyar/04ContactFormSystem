using System.ComponentModel.DataAnnotations;

namespace _04ContactFormSystem.Models
{
    public class ContactModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
