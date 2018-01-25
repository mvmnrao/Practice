using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Manik.Practice.MultiTenancy.Dto;

namespace Manik.Practice.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
