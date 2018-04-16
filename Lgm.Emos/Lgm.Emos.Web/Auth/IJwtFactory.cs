using System.Security.Claims;

namespace Lgm.Emos.Web
{
    public interface IJwtFactory
    {
        System.Threading.Tasks.Task<string> GenerateEncodedToken(string userName, ClaimsIdentity identity);
        ClaimsIdentity GenerateClaimsIdentity(string userName, string id);
    }
}