using MyAbpDemoProject.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpDemoProject.MyMenus.Dto
{
    public class SaveMenuResult: SaveResult
    {
        public Guid Id { get; set; }

        public SaveMenuResult() : base()
        {
        }

        public SaveMenuResult(Guid id)
        {
            Id = id;
            Success = true;
            Message = null;
        }

        public SaveMenuResult(string message) : base(message)
        {
        }
    }
}
