using Abp.AutoMapper;
using MyAbpDemoProject.Sessions.Dto;

namespace MyAbpDemoProject.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}