using DrKlinik.Shared.DTO.Base;
using DrKlinik.Shared.DTO.Diagnose;

namespace DrKlinik.Client.Services.DiagnoseService
{
    public interface IDiagnoseService
    {
        Task<Response> DiagnoseDisease(DiagnoseDTO diagnoseDTO);
    }
}
