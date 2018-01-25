using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Manik.Practice.Roles.Dto;
using Manik.Practice.Users.Dto;

namespace Manik.Practice.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}