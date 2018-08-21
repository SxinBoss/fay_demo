using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpDemoProject.DataModels
{
    public class MyMenu : AuditedEntity<Guid>, IPassivable, ISoftDelete
    {
        #region Default Define

        /// <summary>
        /// Maximum length of the <see cref="Name"/> property.
        /// </summary>
        public const int MaxNameLength = 32;

        /// <summary>
        /// Maximum length of the <see cref="Description"/> property.
        /// </summary>
        public const int MaxDescriptionLength = 512;

        /// <summary>
        /// Maximum length of the <see cref="Price"/> property.
        /// </summary>
        public const int MaxPriceLength = 32;

        #endregion

        #region Public Property

        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [MaxLength(MaxNameLength)]
        public virtual string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [MaxLength(MaxDescriptionLength)]
        public virtual string Description { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public virtual decimal Price { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDeleted { get; set; }

        #endregion
    }
}
