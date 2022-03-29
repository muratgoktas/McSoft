using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.BusinessLayer.Constans
{
    public interface IMessages
    {
        static string AddedMessage { get; }
        static string DeletedMessage { get; }
        static string UpdatedMessage { get; }
        static string UserNotFound { get; }
        static string PasswordError { get; }
        static string SuccessfulLogin { get; }
        static string UserAlreadyExists { get; }
        static string UserRegistered { get; }
        static string AccessTokenCreated { get; }
    }
}
