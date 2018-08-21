using MyAbpDemoProject.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpDemoProject.MyMenus.Dto
{
    public class DeleteMenuResult: DeleteResult
    {
        public DeleteMenuResult() : base()
        {
        }

        public DeleteMenuResult(string message) : base(message)
        {
        }
    }
}
