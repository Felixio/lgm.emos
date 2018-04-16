using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Lgm.Emos.Infrastructure.Identity
{
    public class IdentityAppDbContextSeedData
    {
        public static async Task SeedAsync(UserManager<IdentityAppUser> userManager)
        {
            var defaultUser = new IdentityAppUser { UserName = "admin@lgm.fr", Email = "admin@lgm.fr" };
            await userManager.CreateAsync(defaultUser, "password");
        }
    }
}