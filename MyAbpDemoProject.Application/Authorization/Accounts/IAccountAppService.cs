using System.Threading.Tasks;
using Abp.Application.Services;
using MyAbpDemoProject.Authorization.Accounts.Dto;

namespace MyAbpDemoProject.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
