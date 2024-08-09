using DrKlinik.Shared.DTO.ExtApi;
using System.Net.Http;
using System.Text.Json;

namespace DrKlinik.Client
{
    public class NewsServices
    {
        private readonly HttpClient httpClient;
        private readonly string _apiKey;

        public NewsServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            _apiKey = "pub_50431854b697975a02dee00e6bd5a4f8802e3";
        }

        public async Task<NewsResponseDTO> GetDataAsync()
        {
            int pageSize = 5;
            string endpoint = $"https://newsdata.io/api/1/latest?apikey={_apiKey}&q=health&language=en&q=YOUR_QUERY&size={pageSize}";
            var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
            var response = await httpClient.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<NewsResponseDTO>(content, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
            }
            else
            {
                // Handle the error response as needed
                throw new Exception("Failed to retrieve data");
            }
        }
    }
}
