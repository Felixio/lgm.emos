using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lgm.Emos.Infrastructure.Identity
{
    public class IdentityAppDbContext : IdentityDbContext<IdentityAppUser>
    {
        public IdentityAppDbContext(DbContextOptions<IdentityAppDbContext> options)
              : base(options)
        {
        }

        public DbSet<EmosUser> EmosUsers { get; set; }
    }
}
