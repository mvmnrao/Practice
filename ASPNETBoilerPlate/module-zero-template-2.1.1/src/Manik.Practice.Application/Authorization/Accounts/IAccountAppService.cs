using System.Threading.Tasks;
using Abp.Application.Services;
using Manik.Practice.Authorization.Accounts.Dto;

namespace Manik.Practice.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
