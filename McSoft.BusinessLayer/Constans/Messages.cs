using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.BusinessLayer.Constans
{
    /*
         @}--'--{  McSoft Murat GOKTAS
    */
    public class Messages : IMessages
    {

        public string AddedMessage => "New Record Added!";
        public string DeletedMessage => "This Record Deleted!";

        public string UpdatedMessage => "This Record Updated!";

        public string UserNotFound => "User Not Founded!";

        public string PasswordError => "Password Error!";

        public string SuccessfulLogin => "Successful Login!";

        public string UserAlreadyExists => "User Already Exists!";

        public string UserRegistered => "User Registered With Success!";

        public string AccessTokenCreated => "Access Token Created!";
    }
}
