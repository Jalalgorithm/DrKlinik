using DrKlinik.Server.Data;
using DrKlinik.Shared.DTO.Account;
using DrKlinik.Shared.DTO.Base;
using DrKlinik.Shared.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DrKlinik.Server.Repositories.AccountRepository
{
    public class AccountRepo : IAccountRepo
    {
        private readonly ApplicationDbContext applicationDb;
        private readonly IConfiguration _configuration;

        public AccountRepo(ApplicationDbContext applicationDb , IConfiguration configuration)
        {
            this.applicationDb = applicationDb;
            _configuration = configuration;
        }
        public async Task<GetProfileDTO> GetProfile(int id)
        {
            var profile = await applicationDb.Users
                .Select(profileDetail => new GetProfileDTO
                {
                    Email = profileDetail.Email,
                    FirstName = profileDetail.FirstName,
                    LastName = profileDetail.LastName,
                    Phone = profileDetail.Phone
                })
                .FirstOrDefaultAsync(x => x.Id == id);


            return profile!;

        }

        public async Task<Response> Login(AccountLoginDTO login)
        {
            if(login == null)
            {
                return new Response
                {
                    Success = false,
                    Message = "invalid details provided"

                };
            }


            var result = await applicationDb.Users.FirstOrDefaultAsync(x=>x.Email == login.Email);



            if(result ==null)
            {
                return new Response
                {
                    Success = false,
                    Message = "no user found"
                };
            }

            var passwordHasher = new PasswordHasher<User>();
            var getPassword = passwordHasher.VerifyHashedPassword(new User(), result.Password, login.Password);

            if(getPassword == PasswordVerificationResult.Failed)
            {
                return new Response
                {
                    Success = false,
                    Message = "Email or password is incorrect"
                };
            }

            var jwt = CreateJwt(result);

            return new Response
            {
                Success = true,
                Message = jwt
            };

            



        }

        public async Task<Response> Register(CreateAccountDTO createAccount)
        {
            var emailCount = await applicationDb.Users.CountAsync(x => x.Email == createAccount.Email);

            if(createAccount == null)
            {
                return new Response
                {
                    Success = false,
                    Message = "Provide valid details"
                };
            }

            if(emailCount > 0)
            {
                return new Response
                {
                    Success = false,
                    Message = "Email or passsword already exist"
                };
            }

            
            

            var passwordHasher = new PasswordHasher<User>();
            var encryptedPassword = passwordHasher.HashPassword(new User(), createAccount.Password);

            var user = new User()
            {
                FirstName = createAccount.FirstName,
                LastName = createAccount.LastName,
                Email = createAccount.Email,
                Phone = createAccount.Phone,
                Role = "Client",
                Address = createAccount.Address,
                CreatedAt = DateTime.Now,
                Password = encryptedPassword
                
            };

            await applicationDb.Users.AddAsync(user);
            await applicationDb.SaveChangesAsync();

            return new Response
            {
                Success = true,
                Message = "Account created successfully"
            };

        }


        private string CreateJwt(User user)
        {
            List<Claim> claims = new List<Claim>()
            {
                new Claim("id" ,"" + user.Id),
                new Claim("role" , user.Role),

            };

            string strKey = _configuration["JwtSettings:Key"]!;

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(strKey));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

            var token = new JwtSecurityToken(

                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;

        }
    }
}
