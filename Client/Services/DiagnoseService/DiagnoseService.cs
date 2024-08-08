using DrKlinik.Shared.DTO.Base;
using DrKlinik.Shared.DTO.Diagnose;
using System.Net.Http.Json;

namespace DrKlinik.Client.Services.DiagnoseService
{
    public class DiagnoseService : IDiagnoseService
    {
        private readonly HttpClient httpClient;

        public DiagnoseService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Response> DiagnoseDisease(DiagnoseDTO diagnoseDTO)
        {
            var result = await httpClient.PostAsJsonAsync("api/Diagnose/CheckIllness", diagnoseDTO);
            var response = await result.Content.ReadFromJsonAsync<Response>();

            return response!;
        }
    }
}
