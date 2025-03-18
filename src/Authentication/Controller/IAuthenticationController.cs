using AltSKUF.Back.RestClient.Authentication.Entety;
using Refit;

namespace AltSKUF.Back.RestClient.Authentication.Controller
{
    public interface IAuthenticationController
    {
        //[Post("/Authentication/Keys/Create")]
        //Task<UserKeysResponce> CreateKeys(
        //[Query] Guid userId);
        [Get("/Tokens/Get")]
        Task<TokensResponce> GetUserTokensWithService(
            [Query] Guid userId);

        [Get("/Tokens/Refresh")]
        Task<TokensResponce> RefreshUserTokens();
    }
}
