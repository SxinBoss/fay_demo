using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpDemoProject.Common
{
    public abstract class DeleteResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        protected DeleteResult()
        {
            Success = true;
            Message = null;
        }

        protected DeleteResult(string message)
        {
            Success = false;
            Message = message;
        }
    }
}
