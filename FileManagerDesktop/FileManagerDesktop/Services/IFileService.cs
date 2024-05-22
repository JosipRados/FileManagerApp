using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerDesktop.Services
{
    public interface IFileService
    {
        string DeleteFile(string filePath);
        string CopyFile(string filePath, string copyPath);
        string MoveFile(string filePath, string movePath);
    }
}
