using System;
using System.Threading.Tasks;
using AutoMapper;
using Lgm.Emos.Infrastructure.Identity;
using Lgm.Emos.Web.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lgm.Emos.Web.Controllers
{
    [Route("api/[controller]")]
    public class AccountsController : Controller
    {
        private readonly IdentityAppDbContext _appDbContext;
        private readonly UserManager<IdentityAppUser> _userManager;
        private readonly IMapper _mapper;

        public AccountsController(UserManager<IdentityAppUser> userManager, IMapper mapper, IdentityAppDbContext appDbContext)
        {
            _userManager = userManager;
            _mapper = mapper;
            _appDbContext = appDbContext;
        }

        // POST api/accounts
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RegistrationApiModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userIdentity = _mapper.Map<IdentityAppUser>(model);

            var result = await _userManager.CreateAsync(userIdentity, model.Password);

            if (!result.Succeeded) return new BadRequestObjectResult(Errors.AddErrorsToModelState(result, ModelState));

            await _appDbContext.EmosUsers.AddAsync(new EmosUser { IdentityId = userIdentity.Id });
            await _appDbContext.SaveChangesAsync();

            return new OkObjectResult("Account created");
        }
    }
}
