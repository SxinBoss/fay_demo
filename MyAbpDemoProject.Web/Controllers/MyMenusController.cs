using MyAbpDemoProject.MyMenus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MyAbpDemoProject.MyMenus.Dto;
using Guid = System.Guid;
using MyAbpDemoProject.Web.Models.MyMenus;
using Abp.Application.Services.Dto;

namespace MyAbpDemoProject.Web.Controllers
{
    public class MyMenusController : MyAbpDemoProjectControllerBase
    {
        private readonly IMenuAppService _menuAppService;

        public MyMenusController(IMenuAppService menuAppService)
        {
            _menuAppService = menuAppService;
        }

        public async Task<ActionResult> Index()
        {
            IReadOnlyList<MenuListDto> myMenus = (await _menuAppService.GetMyMenusAsync(new GetMenusInput() { MaxResultCount = int.MaxValue })).Items;
            MenuListViewModel model = new MenuListViewModel
            {
                MyMenus = myMenus
            };
            return View(model);
        }

        public async Task<ActionResult> EditMyMenuModal(Guid myMenuId)
        {
            MenuListDto myMenu = await _menuAppService.GetMyMenuAsync(new NullableIdDto<Guid>(myMenuId));
            EditMenuModalViewModel model = new EditMenuModalViewModel
            {
                MyMenu = myMenu,
            };
            return View("_EditMenuModal", model);
        }
    }
}