using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerDesktop.Models
{
    public class AuthenticationModel
    {
        public string TokenType { get; set; } = "";
        public string AccessToken { get; set; } = "";
        public int ExpiresIn { get; set; }
        public string RefreshToken { get; set; } = "";
    }
}
