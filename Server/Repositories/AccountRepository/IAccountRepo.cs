using DrKlinik.Shared.DTO.Account;
using DrKlinik.Shared.DTO.Base;

namespace DrKlinik.Server.Repositories.AccountRepository
{
    public interface IAccountRepo
    {
        Task<Response> Login(AccountLoginDTO login);
        Task<Response> Register(CreateAccountDTO createAccount);
        Task<GetProfileDTO> GetProfile(int id);

    }
}
