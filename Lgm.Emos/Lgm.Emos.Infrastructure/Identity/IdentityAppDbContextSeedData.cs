using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace Lgm.Emos.Infrastructure.Identity
{
    public class IdentityAppDbContextSeedData
    {
        public static async Task SeedAsync(UserManager<IdentityAppUser> userManager, IdentityAppDbContext appDbContext, ILogger logger)
        {
            if (!appDbContext.EmosUsers.Any(u => u.Identity.Email == "admin@lgm.fr"))
            {
                logger.LogInformation("Seeding data - Adding default user");
                try
                {
                    var userIdentity = new IdentityAppUser { UserName = "admin@lgm.fr", Email = "admin@lgm.fr", FirstName = "Admin", LastName = "Admin" };
                    await userManager.CreateAsync(userIdentity, "password");

                    await appDbContext.EmosUsers.AddAsync(new EmosUser { IdentityId = userIdentity.Id });
                    await appDbContext.SaveChangesAsync();

                    logger.LogInformation("Seeded data - default user added");
                }
                catch (System.Exception ex)
                {
                    logger.LogError(ex, "Seeding database - Error creating default user");
                }
            }
        }
    }
}