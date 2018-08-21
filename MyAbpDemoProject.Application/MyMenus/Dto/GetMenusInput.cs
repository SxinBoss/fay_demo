using Abp.Application.Services.Dto;
using Abp.Extensions;
using Abp.Runtime.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpDemoProject.MyMenus.Dto
{
    public class GetMenusInput : PagedAndSortedResultRequestDto, IShouldNormalize
    {
        public string Name { get; set; }

        public void Normalize()
        {
            if (Sorting.IsNullOrEmpty())
                Sorting = "Name Asc";
        }
    }
}
