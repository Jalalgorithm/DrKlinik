using DrKlinik.Shared.DTO.Base;
using DrKlinik.Shared.DTO.Diagnose;

namespace DrKlinik.Server.Repositories.DiagnoseRepository
{
    public interface IDiagnoseRepo
    {
        Task<Response> GeneralDiagnose(DiagnoseDTO diagnose);
    }
}
