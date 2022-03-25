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
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true, message) 
        { 
        }


    }
}
