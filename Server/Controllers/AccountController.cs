using DrKlinik.Server.Data;
using DrKlinik.Server.Repositories.AccountRepository;
using DrKlinik.Shared.DTO.Account;
using DrKlinik.Shared.DTO.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrKlinik.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepo accountRepo;

        public AccountController(IAccountRepo accountRepo)
        {
            this.accountRepo = accountRepo;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<Response>> Register(CreateAccountDTO createAccount)
        {
            var newUser = await accountRepo.Register(createAccount);

            if(newUser==null)
            {
                return new Response
                {
                    Success = false,
                    Message = "User not found"
                };
            }

            return Ok(newUser);
        }

        [HttpPost("Login")]
        public async Task<ActionResult<Response>> LogIn (AccountLoginDTO accountLogin)
        {
            var accessUser = await accountRepo.Login(accountLogin);

            if (accessUser is null)
            {
                return new Response
                {
                    Success = false,
                    Message = "User not found"
                };


            }

            return Ok(accessUser);
        }

        [HttpGet("GetProfile")]
        public async Task<ActionResult<GetProfileDTO>> GetProfile ()
        {
            var identity = JwtReader.GetUserId(User);

            var presentUser = await accountRepo.GetProfile(identity);

            if(presentUser is null)
            {
                return NotFound("User not found");
            }


            return Ok(presentUser);
        }
    }
}
