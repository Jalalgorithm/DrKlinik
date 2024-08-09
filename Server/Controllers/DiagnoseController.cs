using DrKlinik.Server.Repositories.DiagnoseRepository;
using DrKlinik.Shared.DTO.Base;
using DrKlinik.Shared.DTO.Diagnose;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace DrKlinik.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiagnoseController : ControllerBase
    {
        private readonly IDiagnoseRepo diagnoseRepo;
        private readonly HttpClient httpClient;

        public DiagnoseController(IDiagnoseRepo diagnoseRepo , HttpClient httpClient)
        {
            this.diagnoseRepo = diagnoseRepo;
            this.httpClient = httpClient;
        }

        [HttpPost("Checkillness")]
        public async Task<Response> PredictIllness(DiagnoseDTO diagnose)
        {
            if(diagnose == null)
            {
                return new Response
                {
                    Success = false,
                    Message = "no symptoms sent"
                };
            }

            var result = await diagnoseRepo.GeneralDiagnose(diagnose);

            if(result==null)
            {
                return new Response
                {
                    Success = false,
                    Message = "No result found for symptoms"
                };
            }
            return result;
        }

        [HttpPost("DetectHeart")]

        public async Task<Response> HeartDisease(HeartDiseaseDTO heartDisease)
        {
            if (heartDisease == null)
            {
                return new Response
                {
                    Success = false,
                    Message = "Input valid details for diagnosis"
                };
            }

            var jsonRequest = JsonConvert.SerializeObject(heartDisease);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://127.0.0.1:5000/predict", content);
            response.EnsureSuccessStatusCode();

            var predictionResponse = await response.Content.ReadFromJsonAsync<PredictionRequest>();

            string message;

            if (predictionResponse.Prediction == 1)
            {
                message = "Heart Disease";

            }
            else
            {
                message = "No Heart Disease";
            }

            return new Response
            {
                Message = $"The Prediction is {message} with the accuracy {predictionResponse.Accuracy}",
                Success = true
            };
        }
    }


}

