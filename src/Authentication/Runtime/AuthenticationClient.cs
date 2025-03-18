using AltSKUF.Back.RestClient.Authentication.Controller;
using Refit;

namespace AltSKUF.Back.RestClient.Authentication.Runtime
{
    internal class AuthenticationClient(
        HttpClient httpClient) : IAuthenticationClient
    {
        public Uri? Uri => httpClient.BaseAddress;
        public HttpClient HttpClient => httpClient;

        public IAuthenticationController AuthenticationController { get; } = RestService.For<IAuthenticationController>(httpClient);

    }
}
