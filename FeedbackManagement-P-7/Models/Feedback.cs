
using System.ComponentModel.DataAnnotations;

namespace FeedbackManagement.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Please enter your feedback")]
        [StringLength(500, MinimumLength = 5,
            ErrorMessage = "Feedback must be 5 to 500 characters")]
        public string Message { get; set; } = "";

        [Required(ErrorMessage = "Please select a rating")]
        [Range(1, 4, ErrorMessage = "Rating must be between 1 and 4")]
        public int Rating { get; set; }
    }
}
