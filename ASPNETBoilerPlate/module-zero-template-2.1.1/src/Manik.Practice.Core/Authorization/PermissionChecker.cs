using Abp.Authorization;
using Manik.Practice.Authorization.Roles;
using Manik.Practice.Authorization.Users;

namespace Manik.Practice.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
