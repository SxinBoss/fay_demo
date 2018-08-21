using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAbpDemoProject.Common
{
    public abstract class SaveResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        protected SaveResult()
        {
            Success = true;
            Message = null;
        }

        protected SaveResult(string message)
        {
            Success = false;
            Message = message;
        }
    }
}
