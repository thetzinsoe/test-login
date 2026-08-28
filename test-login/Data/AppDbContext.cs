using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using test_login.Models;

namespace test_login.Data;

class AppDbContext : IdentityDbContext<ApplicatonUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}