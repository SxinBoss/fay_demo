using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyAbpDemoProject.MultiTenancy.Dto;

namespace MyAbpDemoProject.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
