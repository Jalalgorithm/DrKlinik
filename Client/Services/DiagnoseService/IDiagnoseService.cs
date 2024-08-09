using DrKlinik.Shared.DTO.Base;
using DrKlinik.Shared.DTO.Diagnose;
using DrKlinik.Shared.DTO.ExtApi;

namespace DrKlinik.Client.Services.DiagnoseService
{
    public interface IDiagnoseService
    {
        Task<Response> DiagnoseDisease(DiagnoseDTO diagnoseDTO);
        Task<Response> HeartCheckDisease(HeartDiseaseDTO diseaseDTO);
    }
}
