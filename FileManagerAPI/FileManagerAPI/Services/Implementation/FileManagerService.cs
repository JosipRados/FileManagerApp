using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FileManagerAPI.Services.Implementation
{
    public class FileManagerService : IFileManagerService
    {
        private readonly ILogService _logger;
        public FileManagerService(ILogService logService)
        {
            _logger = logService;
        }
        public HttpStatusCode DeleteFile(string filePath)
        {
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError;

            try
            {
                //Checking if file exists and delete if exists
                if (File.Exists(filePath))
                    File.Delete(filePath);
                else
                {
                    statusCode = HttpStatusCode.BadRequest;
                    throw new Exception("File does not exists on provided path!");
                }

                //Checking if file is deleted
                if (!File.Exists(filePath))
                    return HttpStatusCode.OK;
                else
                {
                    statusCode = HttpStatusCode.InternalServerError;
                    throw new Exception("File could not be deleted!");
                }
            }
            catch(Exception ex)
            {
                _logger.WriteLog("Delete File Error: " + ex.Message + ";FilePath: " + filePath);
                return statusCode;
            }
        }

        public HttpStatusCode MoveFile(string filePath, string movePath)
        {
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError;

            try
            {
                //Check if file exists and does not exists on the selected move path
                if (!File.Exists(filePath))
                {
                    statusCode = HttpStatusCode.BadRequest;
                    throw new Exception("File does not exists on provided path!");
                }

                if(File.Exists(movePath))
                {
                    statusCode = HttpStatusCode.BadRequest;
                    throw new Exception("File with the same name already exists on the given move path!");
                }

                File.Move(filePath, movePath);

                //Check if the file is moved from one place to another
                if (File.Exists(filePath))
                {
                    statusCode = HttpStatusCode.InternalServerError;
                    throw new Exception("File still exists on provided path!");
                }

                if (!File.Exists(movePath))
                {
                    statusCode = HttpStatusCode.InternalServerError;
                    throw new Exception("File does not exists on the provided move path!");
                }

                return HttpStatusCode.OK;
            }
            catch(Exception ex)
            {
                _logger.WriteLog("Move File ERR: " + ex.Message + ";FilePath: " + filePath + ";MovePath: " + movePath);
                return statusCode;
            }
        }

        public HttpStatusCode CopyFile(string filePath, string copyPath)
        {
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError;

            try
            {
                //Check if file exists and does not exists on the selected copy path
                if (!File.Exists(filePath))
                {
                    statusCode = HttpStatusCode.BadRequest;
                    throw new Exception("File does not exists on provided path!");
                }

                if (File.Exists(copyPath))
                {
                    statusCode = HttpStatusCode.BadRequest;
                    throw new Exception("File with the same name already exists on the given copy path!");
                }

                File.Copy(filePath, copyPath);

                //Check if there is copy and original file (For simplicity did not include copy with changed name)
                if (!File.Exists(filePath))
                {
                    statusCode = HttpStatusCode.InternalServerError;
                    throw new Exception("File does not exist on provided path after copy!");
                }

                if (!File.Exists(copyPath))
                {
                    statusCode = HttpStatusCode.InternalServerError;
                    throw new Exception("File does not exists on the provided copy path!");
                }

                return HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                _logger.WriteLog("Copy File ERR: " + ex.Message + ";FilePath: " + filePath + ";CopyPath: " + copyPath);
                return statusCode;
            }
        }
    }
}
