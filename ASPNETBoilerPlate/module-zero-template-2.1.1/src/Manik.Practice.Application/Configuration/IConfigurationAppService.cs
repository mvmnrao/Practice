using System.Threading.Tasks;
using Abp.Application.Services;
using Manik.Practice.Configuration.Dto;

namespace Manik.Practice.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}