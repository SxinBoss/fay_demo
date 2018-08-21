using System.Collections.Generic;
using MyAbpDemoProject.Roles.Dto;
using MyAbpDemoProject.Users.Dto;

namespace MyAbpDemoProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}