using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.Core.Utilities.Result
{
    /*
         @}--'--{  McSoft Murat GOKTAS
    */
    public class Result : IResult
    {    
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }
        public string Message { get; }
        public bool Success { get; }
    }
}
