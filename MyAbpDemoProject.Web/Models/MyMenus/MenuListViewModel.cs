using MyAbpDemoProject.MyMenus.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAbpDemoProject.Web.Models.MyMenus
{
    public class MenuListViewModel
    {
        public IReadOnlyList<MenuListDto> MyMenus { get; set; }

    }
}