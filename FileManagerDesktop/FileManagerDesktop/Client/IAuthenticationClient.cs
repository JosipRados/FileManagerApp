using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerDesktop.Client
{
    public interface IAuthenticationClient
    {
        string Authenticate(string username, string password);
    }
}
