using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerDesktop.Services
{
    public interface ILogService
    {
        void WriteLog(string message);
    }
}
