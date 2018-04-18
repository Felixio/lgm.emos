using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Lgm.Emos.Infrastructure.Identity
{
    public class IdentityAppDbContextSeedData
    {
        public static async Task SeedAsync(UserManager<IdentityAppUser> userManager, IdentityAppDbContext appDbContext)
        {
            if (!appDbContext.EmosUsers.Any(u => u.Identity.Email == "admin@lgm.fr"))
            {
                var userIdentity = new IdentityAppUser { UserName = "admin@lgm.fr", Email = "admin@lgm.fr", FirstName = "Admin", LastName = "Admin" };
                await userManager.CreateAsync(userIdentity, "password");

                await appDbContext.EmosUsers.AddAsync(new EmosUser { IdentityId = userIdentity.Id });
                await appDbContext.SaveChangesAsync();
            }
        }
    }
}