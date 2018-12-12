using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ThinkAM.ThinkAcademy.MultiTenancy.Dto;

namespace ThinkAM.ThinkAcademy.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
