using Microsoft.AspNetCore.Identity;

namespace test_login.Models
{
    public class ApplicatonUser : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }
}
