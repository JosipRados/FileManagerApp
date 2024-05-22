using FileManagerDesktop.Client;
using FileManagerDesktop.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagerDesktop.Services.Implementation
{
    public class FileService : IFileService
    {
        private readonly IFileClient _fileClient;
        private readonly ILogService _logger;
        private readonly ReAuthenticationForm _fmrReAuthenticate;

        //private readonly IAuthenticationClient _authService;
        public FileService(IFileClient fileClient, ReAuthenticationForm frmReAuthenticate, ILogService logService)
        {
            _fileClient = fileClient;
            _fmrReAuthenticate = frmReAuthenticate;
            _logger = logService;
        }

        public string DeleteFile(string filePath)
        {
            string response = _fileClient.DeleteFile(filePath);
                
            if (response == "401")
            {
                ReAuthenticateUser();
                response = _fileClient.DeleteFile(filePath);
            }

            return (response == "200") ? "OK" : "Failed Delete File!";
        }

        public string CopyFile(string filePath, string copyPath)
        {
            string response = "";

            try
            {
                response = _fileClient.CopyFile(filePath, copyPath);

                if (response == "401")
                {
                    ReAuthenticateUser();
                    response = _fileClient.CopyFile(filePath, copyPath);
                }

                if (response == "200")
                    return "OK";
                else
                    throw new Exception(response);

            }
            catch (Exception ex)
            {
                _logger.WriteLog("Failed to Copy File, API response code: " + ex.Message);
                return "";
            }
        }

        public string MoveFile(string filePath, string movePath)
        {
            string response = "";

            try
            {
                response = _fileClient.MoveFile(filePath, movePath);

                if (response == "401")
                {
                    ReAuthenticateUser();
                    response = _fileClient.MoveFile(filePath, movePath);
                }

                if (response == "200")
                    return "OK";
                else
                    throw new Exception(response);

            }
            catch (Exception ex)
            {
                _logger.WriteLog("Failed to Move File, API response code: " + ex.Message);
                return "";
            }
        }

        private void ReAuthenticateUser()
        {
            try
            {
                var result = _fmrReAuthenticate.ShowDialog();
            }
            catch(Exception ex)
            {
                _logger.WriteLog("ReAuthenticate form error, ERR: " + ex.Message);
                MessageBox.Show("Unable to initialize reauthentication, please try again!");
            }
        }
    }
}
