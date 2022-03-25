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
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        public DataResult(T data,bool success) : base(success)
        {
            Data = data;
        }
        public T Data { get; }

    }
}
