using FileManagerDesktop.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerDesktop.Services.Implementation
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IAuthenticationClient _loginClient;
        public AuthenticationService(IAuthenticationClient loginClient)
        {
            _loginClient = loginClient;
        } 

        public string AuthenticateUser(string username, string password)
        {
            var bearer = _loginClient.Authenticate(username, password);
            if(string.IsNullOrEmpty(bearer))
                return "Unauthorized username and password!";
            return "OK";
        }
    }
}
