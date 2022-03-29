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

        public static string AddedMessage => "New Record Added!";
        public static string DeletedMessage => "This Record Deleted!";

        public static string UpdatedMessage => "This Record Updated!";

        public static string UserNotFound => "User Not Founded!";

        public static string PasswordError => "Password Error!";

        public static string SuccessfulLogin => "Successful Login!";

        public static string UserAlreadyExists => "User Already Exists!";

        public static string UserRegistered => "User Registered With Success!";

        public static string AccessTokenCreated => "Access Token Created!";
    }
}
