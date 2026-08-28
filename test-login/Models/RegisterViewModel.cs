using System.ComponentModel.DataAnnotations;

namespace test_login.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Confirm Password ဖြည့်ရန် လိုအပ်ပါသည်။")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Compare(nameof(Password), ErrorMessage = "Password နှစ်ခု ထပ်တူညီမှု မရှိပါ။")]
        public string ConfirmPassword { get; set; }
    }
}
