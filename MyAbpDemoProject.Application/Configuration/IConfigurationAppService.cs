using System.Threading.Tasks;
using Abp.Application.Services;
using MyAbpDemoProject.Configuration.Dto;

namespace MyAbpDemoProject.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}