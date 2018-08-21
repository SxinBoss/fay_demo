using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.ComponentModel.DataAnnotations;
using MyAbpDemoProject.DataModels;

namespace MyAbpDemoProject.MyMenus.Dto
{
    [AutoMapTo(typeof(MyMenu))]
    public class MenuEditDto:EntityDto<Guid>
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
        public decimal Price { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsActive { get; set; }

        #endregion
    }
}
