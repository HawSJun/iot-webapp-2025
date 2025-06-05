using System.ComponentModel.DataAnnotations;

namespace MyPortfolioWebApp.Models
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and confirmation password don't match.")]
        public string ConfirmPassword { get; set; }

        // 추가로 PhoneNumber 받을려면 string?(Nullable)로 작성
        // public string? PhoneNumber { get; set; }
    }
}
