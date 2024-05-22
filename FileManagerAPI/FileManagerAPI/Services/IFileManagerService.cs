using System.Net;

namespace FileManagerAPI.Services
{
    public interface IFileManagerService
    {
        HttpStatusCode DeleteFile(string filePath);
        HttpStatusCode MoveFile(string filePath, string movePath);
        HttpStatusCode CopyFile(string filePath, string copyPath);
    }
}
