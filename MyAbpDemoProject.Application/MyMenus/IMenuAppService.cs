using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyAbpDemoProject.MyMenus.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpDemoProject.MyMenus
{
    public interface IMenuAppService:IApplicationService
    {
        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<MenuListDto>> GetMyMenusAsync(GetMenusInput input);

        /// <summary>
        /// 单条数据
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<MenuListDto> GetMyMenuAsync(NullableIdDto<Guid> input);

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<DeleteMenuResult> DeleteMyMenuAsync(EntityDto<Guid> input);

        /// 新增数据
        /// <summary>
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<SaveMenuResult> InsertMyMenuAsync(MenuEditDto dto);

        /// <summary>
        /// 编辑数据
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<SaveMenuResult> UpdateMyMenuAsync(MenuEditDto dto);
    }
}
