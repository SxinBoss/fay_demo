using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using MyAbpDemoProject.DataModels;
using MyAbpDemoProject.MyMenus.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;

namespace MyAbpDemoProject.MyMenus
{
    public class MenuAppService : MyAbpDemoProjectAppServiceBase, IMenuAppService
    {
        private readonly IRepository<MyMenu, Guid> _menuRepository;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="menuRepository"></param>
        public MenuAppService(IRepository<MyMenu, Guid> menuRepository)
        {
            _menuRepository = menuRepository;
        }

        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<PagedResultDto<MenuListDto>> GetMyMenusAsync(GetMenusInput input)
        {
            var query = _menuRepository.GetAll();
            query = query.WhereIf(!input.Name.IsNullOrEmpty(), c => c.Name.Contains(input.Name));

            int totalCount = await query.CountAsync();
            List<MyMenu> menus = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

            return new PagedResultDto<MenuListDto>(totalCount, menus.MapTo<List<MenuListDto>>());
        }

        /// <summary>
        /// 单条数据
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<MenuListDto> GetMyMenuAsync(NullableIdDto<Guid> input)
        {
            if (input.Id.HasValue)
            {
                MyMenu menu = await _menuRepository.FirstOrDefaultAsync(input.Id.Value);
                return menu.MapTo<MenuListDto>();
            }
            return new MenuListDto();
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<DeleteMenuResult> DeleteMyMenuAsync(EntityDto<Guid> input)
        {
            MyMenu myMenu = await _menuRepository.FirstOrDefaultAsync(input.Id);
            if (myMenu.IsNullOrDeleted())
                return new DeleteMenuResult("删除的数据不存在");

            myMenu.IsDeleted = true;
            return new DeleteMenuResult();
        }

        /// <summary>
        /// 新增数据
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task<SaveMenuResult> InsertMyMenuAsync(MenuEditDto dto)
        {
            MyMenu dbMenu = await _menuRepository.FirstOrDefaultAsync(c => c.Name == dto.Name);
            if (!dbMenu.IsNullOrDeleted())
                return new SaveMenuResult("已存在相同名称的企业");

            MyMenu menu = dto.MapTo<MyMenu>();
            //menu.IsActive = true;

            Guid id = await _menuRepository.InsertAndGetIdAsync(menu);
            return new SaveMenuResult(id);
        }

        /// <summary>
        /// 编辑数据
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task<SaveMenuResult> UpdateMyMenuAsync(MenuEditDto dto)
        {
            MyMenu dbMenu = await _menuRepository.FirstOrDefaultAsync(c => c.Name == dto.Name && c.Id != dto.Id);
            if (!dbMenu.IsNullOrDeleted())
                return new SaveMenuResult("已存在相同名称的企业");

            MyMenu menu = await _menuRepository.FirstOrDefaultAsync(dto.Id);
            if (menu.IsNullOrDeleted())
                return new SaveMenuResult("修改的企业不存在");

            menu.Name = dto.Name;
            menu.Description = dto.Description;
            menu.Price = dto.Price;
            menu.IsActive = dto.IsActive;

            return new SaveMenuResult(dto.Id);
        }
    }
}
