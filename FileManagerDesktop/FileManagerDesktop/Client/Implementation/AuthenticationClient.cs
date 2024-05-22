using FileManagerDesktop.Models;
using FileManagerDesktop.Services;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FileManagerDesktop.Client.Implementation
{
    public class AuthenticationClient : IAuthenticationClient
    {
        private readonly string url = "https://localhost:44357";
        private readonly IMemoryCache _cache;
        private readonly ILogService _logger;
        public AuthenticationClient(IMemoryCache memoryCache, ILogService logService)
        {
            _cache = memoryCache;
            _logger = logService;
        }

        public string Authenticate(string username, string password)
        {
            string? bearerToken = "";
            AuthenticationModel? auth = new AuthenticationModel();

            try
            {
                //if (_cache.TryGetValue<string>("BearerToken", out bearerToken))
                //    return string.IsNullOrEmpty(bearerToken) ? "" : bearerToken;

                string requestJson = JsonConvert.SerializeObject(new { email = username, password = password, 
                                                                       twoFactorCode = "string", twoFactorRecoveryCode = "string" });

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var request = new HttpRequestMessage(HttpMethod.Post, "/login");
                    request.Content = new StringContent(requestJson, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = client.Send(request);

                    if (!response.IsSuccessStatusCode)
                        throw new Exception(response.StatusCode.ToString());

                    var jsonString = response.Content.ReadAsStringAsync().Result;

                    if (string.IsNullOrEmpty(jsonString))
                        throw new Exception("Deserialization Failed!");

                    auth = JsonConvert.DeserializeObject<AuthenticationModel>(jsonString);

                    if (auth == null || string.IsNullOrEmpty(auth.AccessToken))
                        throw new Exception("Retrived data empty.");

                    _cache.Set("BearerToken", auth.AccessToken, TimeSpan.FromSeconds(auth.ExpiresIn));
                    return auth.AccessToken;
                }
            }
            catch (Exception ex)
            {
                _logger.WriteLog("GetBearerToken, ERR: " + ex.Message);
                return "";
            }
        }
    }
}
