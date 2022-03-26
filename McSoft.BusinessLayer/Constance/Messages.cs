using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McSoft.BusinessLayer.Constance
{
    /*
         @}--'--{  McSoft Murat GOKTAS
    */
    public class Messages :MessagesDictionaryBase
    {
      
        public override string addedMessage => "New Record Added!";

        public override string deletedMessage => "This Record Deleted!";

        public override string updatedMessage => "This Record Updated!";

        public override string userNotFound => "User Not Founded!";

        public override string passwordError => "Password Error!";

        public override string successfulLogin => "Successful Login!";

        public override string userAlreadyExists => "User Already Exists!";

        public override string userRegistered => "User Registered With Success!";

        public override string accessTokenCreated => "Access Token Created!";
    }
}
