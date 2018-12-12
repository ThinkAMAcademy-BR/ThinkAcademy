using System.Threading.Tasks;
using Abp.Application.Services;
using ThinkAM.ThinkAcademy.Sessions.Dto;

namespace ThinkAM.ThinkAcademy.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
