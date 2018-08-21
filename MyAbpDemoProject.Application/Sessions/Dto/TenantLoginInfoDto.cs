using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyAbpDemoProject.MultiTenancy;

namespace MyAbpDemoProject.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}