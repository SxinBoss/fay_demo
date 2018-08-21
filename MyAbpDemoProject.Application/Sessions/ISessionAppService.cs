using System.Threading.Tasks;
using Abp.Application.Services;
using MyAbpDemoProject.Sessions.Dto;

namespace MyAbpDemoProject.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
