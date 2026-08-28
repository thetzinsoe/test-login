using System.ComponentModel.DataAnnotations;

namespace test_login.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "နာမည်ကို ဖြည့်ရန် လိုအပ်ပါသည်။")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "စကားဝှက်ကို ဖြည့်ရန် လိုအပ်ပါသည်။")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
