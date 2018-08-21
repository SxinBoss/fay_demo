using Abp.Authorization;
using MyAbpDemoProject.Authorization.Roles;
using MyAbpDemoProject.Authorization.Users;

namespace MyAbpDemoProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
