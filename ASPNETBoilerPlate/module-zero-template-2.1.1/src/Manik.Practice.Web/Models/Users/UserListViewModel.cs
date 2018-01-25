using System.Collections.Generic;
using Manik.Practice.Roles.Dto;
using Manik.Practice.Users.Dto;

namespace Manik.Practice.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}