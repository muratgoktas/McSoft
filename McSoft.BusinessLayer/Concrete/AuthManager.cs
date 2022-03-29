using McSoft.BusinessLayer.Abstract;
using McSoft.BusinessLayer.Constans;
using McSoft.Core.Entities.Concrete;
using McSoft.Core.Utilities.Result;
using McSoft.Core.Utilities.Security.Hashing;
using McSoft.Core.Utilities.Security.Jwt;
using McSoft.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.BusinessLayer.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private ITokenHelper _tokenHelper;
      
        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
           
           
        }

        public IDataResult<AccessToken> CreateAccessToken(User user)
        {
            var claims=_userService.GetClaims(user);
            var accessToken= _tokenHelper.CreateToken(user,claims );
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
           
        }

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);
            if (userToCheck==null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }
            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password,userToCheck.PasswordHash,userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(Messages.PasswordError);
            }
            return new SuccessDataResult<User>(userToCheck, Messages.SuccessfulLogin );
            
        }

        public IDataResult<User> Register(UserForRegisterDto userFroRegisterDto, string password)
        {
            // biz out ile passwordHash, passwordSalt boş gönderiyoruz orada oluşan değeri alıyor. Çünkü referans tip oluyor.
            // Ayrıntılı bilgi istiyorsan ref ve out bak. out ref farkı out sonradan değer alır. ref baştan değer alır.
            // burada passwordHash, passwordSalt sonradan değer alacaklar.CreatePasswordHash çalığınca değer alacaklar.
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Email = userFroRegisterDto.Email,
                FirstName=userFroRegisterDto.FirstName,
                LastName=userFroRegisterDto.LastName,
                 Status=true,
                 PasswordHash=passwordHash,
                 PasswordSalt=passwordSalt

            };
            _userService.Add(user);
            return new SuccessDataResult<User>(user,Messages.UserRegistered );
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email)!=null)
            {
                return new ErrorResult(Messages.UserAlreadyExists );
            }
            return new SuccessResult(Messages.SuccessfulLogin);
        }
    }
}
