// Models/ContactViewModel.cs
using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a message.")]
        [MinLength(10, ErrorMessage = "Message must be at least 10 characters long.")]
        public string Message { get; set; }
    }
}