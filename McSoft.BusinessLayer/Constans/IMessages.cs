using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.BusinessLayer.Constans
{
    public interface IMessages
    {
         string AddedMessage { get; }
         string DeletedMessage { get; }
         string UpdatedMessage { get; }
         string UserNotFound { get; }
         string PasswordError { get; }
         string SuccessfulLogin { get; }
         string UserAlreadyExists { get; }
         string UserRegistered { get; }
         string AccessTokenCreated { get; }
    }
}
