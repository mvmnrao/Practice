using System.Threading.Tasks;
using Abp.Application.Services;
using Manik.Practice.Sessions.Dto;

namespace Manik.Practice.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
