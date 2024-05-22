using FileManagerAPI.Models;
using FileManagerAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace FileManagerAPI.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class FileManagerController : ControllerBase
    {
        private readonly IFileManagerService _fileManager;
        public FileManagerController(IFileManagerService fileManagerService)
        {
            _fileManager = fileManagerService;
        }

        [Authorize]
        [HttpPost("delete-file")]
        public IActionResult DeleteFile([FromBody] FileInformationsModel fileInfo)
        {
            var response = _fileManager.DeleteFile(fileInfo.FilePath);
            return StatusCode((int)response);
        }

        [Authorize]
        [HttpPost("move-file")]
        public IActionResult MoveFile([FromBody] FileInformationsModel fileInfo)
        {
            var response = _fileManager.MoveFile(fileInfo.FilePath, fileInfo.DestinationPath);
            return StatusCode((int)response);
        }

        [Authorize]
        [HttpPost("copy-file")]
        public IActionResult CopyFile([FromBody] FileInformationsModel fileInfo)
        {
            var response = _fileManager.CopyFile(fileInfo.FilePath, fileInfo.DestinationPath);
            return StatusCode((int) response);
        }
    }
}
