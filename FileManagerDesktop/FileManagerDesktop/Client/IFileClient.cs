using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerDesktop.Client
{
    public interface IFileClient
    {
        string DeleteFile(string filePath);
        string CopyFile(string filePath, string copyPath);
        string MoveFile(string filePath, string movePath);
    }
}
