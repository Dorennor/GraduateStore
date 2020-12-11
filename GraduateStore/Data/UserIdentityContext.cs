using GraduateStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GraduateStore.Data
{
    public sealed class UserIdentityContext : IdentityDbContext<User>
    {
        public UserIdentityContext(DbContextOptions<UserIdentityContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
