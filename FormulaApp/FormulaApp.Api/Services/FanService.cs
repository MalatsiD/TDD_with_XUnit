using FormulaApp.Api.Configuration;
using FormulaApp.Api.Models;
using FormulaApp.Api.Services.Interfaces;
using Microsoft.Extensions.Options;
using System.Net;

namespace FormulaApp.Api.Services
{
    public class FanService : IFanService
    {
        private readonly HttpClient _httpClient;
        private readonly ApiServiceConfig _apiServiceConfig;

        public FanService(HttpClient httpClient, IOptions<ApiServiceConfig> apiServiceConfig)
        {
            _httpClient = httpClient;
            _apiServiceConfig = apiServiceConfig.Value;
        }

        public async Task<List<Fan>> GetAllFans()
        {
            var response = await _httpClient.GetAsync(_apiServiceConfig.Url);

            if (response.StatusCode == HttpStatusCode.NotFound)
                return new List<Fan>();
            if (response.StatusCode == HttpStatusCode.Unauthorized)
                return null!;

            var fans = await response.Content.ReadFromJsonAsync<List<Fan>>();

            return fans!;
        }
    }
}
