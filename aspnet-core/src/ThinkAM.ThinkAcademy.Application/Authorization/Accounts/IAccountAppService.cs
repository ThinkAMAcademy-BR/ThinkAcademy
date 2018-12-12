using System.Threading.Tasks;
using Abp.Application.Services;
using ThinkAM.ThinkAcademy.Authorization.Accounts.Dto;

namespace ThinkAM.ThinkAcademy.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
