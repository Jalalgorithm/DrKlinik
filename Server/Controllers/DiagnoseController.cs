using DrKlinik.Server.Repositories.DiagnoseRepository;
using DrKlinik.Shared.DTO.Base;
using DrKlinik.Shared.DTO.Diagnose;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrKlinik.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiagnoseController : ControllerBase
    {
        private readonly IDiagnoseRepo diagnoseRepo;

        public DiagnoseController(IDiagnoseRepo diagnoseRepo)
        {
            this.diagnoseRepo = diagnoseRepo;
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
            if (heartDisease==null)
            {
                return new Response
                {
                    Success = false,
                    Message = "no symptoms sent"
                };
            }

            var result = await diagnoseRepo.DiagnoseHeartDisease(heartDisease);

            if (result== null)
            {
                return new Response
                {
                    Success = false,
                    Message = "no result"
                };
            }
            return result;
        }
    }


}

