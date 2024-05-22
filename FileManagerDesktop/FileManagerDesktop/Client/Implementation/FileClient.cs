using FileManagerDesktop.Models;
using FileManagerDesktop.Services;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FileManagerDesktop.Client.Implementation
{
    public class FileClient : IFileClient
    {
        private readonly string url = "https://localhost:44357";
        private readonly IMemoryCache _cache;
        private readonly ILogService _logger;
        public FileClient(IMemoryCache memoryCache, ILogService logService)
        {
            _cache = memoryCache;
            _logger = logService;
        }

        public string DeleteFile(string filePath)
        {
            string? bearerToken = "";
            try
            {
                if (!_cache.TryGetValue<string>("BearerToken", out bearerToken))
                    return "401";

                string requestJson = JsonConvert.SerializeObject(new
                {
                    FilePath = filePath
                });

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

                    var request = new HttpRequestMessage(HttpMethod.Post, "/api/v1/delete-file");
                    request.Content = new StringContent(requestJson, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.Send(request);

                    if (!response.IsSuccessStatusCode)
                        throw new Exception(response.StatusCode.ToString());
                    return "200";
                    
                }
            }
            catch (Exception ex)
            {
                _logger.WriteLog("DeleteFile, ERR: " + ex.Message);
                return ex.Message;
            }
        }

        public string CopyFile(string filePath, string copyPath)
        {
            string? bearerToken = "";
            try
            {
                if (!_cache.TryGetValue<string>("BearerToken", out bearerToken))
                    return "401";

                string requestJson = JsonConvert.SerializeObject(new
                {
                    FilePath = filePath,
                    DestinationPath = copyPath
                });

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

                    var request = new HttpRequestMessage(HttpMethod.Post, "/api/v1/copy-file");
                    request.Content = new StringContent(requestJson, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.Send(request);

                    if (!response.IsSuccessStatusCode)
                        throw new Exception(response.StatusCode.ToString());
                    return "200";

                }
            }
            catch (Exception ex)
            {
                _logger.WriteLog("CopyFile, ERR: " + ex.Message);
                return ex.Message;
            }
        }

        public string MoveFile(string filePath, string movePath)
        {
            string? bearerToken = "";
            try
            {
                if (!_cache.TryGetValue<string>("BearerToken", out bearerToken))
                    return "401";

                string requestJson = JsonConvert.SerializeObject(new
                {
                    FilePath = filePath,
                    DestinationPath = movePath,
                });

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

                    var request = new HttpRequestMessage(HttpMethod.Post, "/api/v1/move-file");
                    request.Content = new StringContent(requestJson, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.Send(request);

                    if (!response.IsSuccessStatusCode)
                        throw new Exception(response.StatusCode.ToString());
                    return "200";

                }
            }
            catch (Exception ex)
            {
                _logger.WriteLog("MoveFile, ERR: " + ex.Message);
                return ex.Message;
            }
        }
    }
}
