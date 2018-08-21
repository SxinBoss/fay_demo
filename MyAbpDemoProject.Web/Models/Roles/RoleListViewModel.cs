using System.Collections.Generic;
using MyAbpDemoProject.Roles.Dto;

namespace MyAbpDemoProject.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}