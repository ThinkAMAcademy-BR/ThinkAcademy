using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ThinkAM.ThinkAcademy.MultiTenancy;

namespace ThinkAM.ThinkAcademy.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
