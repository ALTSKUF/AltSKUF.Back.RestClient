using AltSKUF.Back.RestClient.Authentication.Controller;

namespace AltSKUF.Back.RestClient.Authentication
{
    public interface IAuthenticationClient
    {
        public Uri? Uri { get; }
        public HttpClient HttpClient { get; }

        public IAuthenticationController AuthenticationController { get; }
    }
}
