using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;
using MyAbpDemoProject.DataModels;
using Abp.Application.Services.Dto;
using System;

namespace MyAbpDemoProject.MyMenus.Dto
{
    [AutoMapFrom(typeof(MyMenu))]
    public class MenuListDto: EntityDto<Guid>
    {
        #region Public Property

        /// <summary>
        /// 菜品名称
        /// </summary>
        [Required]
        [MaxLength(MyMenu.MaxNameLength)]
        public string Name { get; set; }

        /// <summary>
        /// 菜品描述
        /// </summary>
        [MaxLength(MyMenu.MaxDescriptionLength)]
        public string Description { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsActive { get; set; }

        #endregion
    }
}
