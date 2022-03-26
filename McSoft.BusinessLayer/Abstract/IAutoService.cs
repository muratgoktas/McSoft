using McSoft.Core.Entities.Concrete;
using McSoft.Core.Utilities.Result;
using McSoft.Core.Utilities.Security.Jwt;
using McSoft.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.BusinessLayer.Abstract
{
    public interface IAutoService
    {
        IDataResult<User> Register(UserFroRegisterDto userFroRegisterDto, string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
