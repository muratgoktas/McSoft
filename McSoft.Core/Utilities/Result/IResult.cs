using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.Core.Utilities.Result
{
    public interface IResult
    {
        // işlemin başarı durumu. Readonly (sadece get; var).
        bool Success { get; }
        string Message { get; }
    }
}
