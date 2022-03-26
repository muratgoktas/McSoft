using McSoft.Core.Entities.Concrete;

namespace McSoft.BusinessLayer.Constance
{
    public  abstract class MessagesDictionaryBase
    {
       
        /*
        @}--'--{  McSoft Murat GOKTAS
        */

        public abstract string addedMessage { get; }
        public abstract string deletedMessage { get; }
        public abstract string updatedMessage { get; }
        public abstract string userNotFound { get; }
        public abstract string passwordError { get; }
        public abstract  string successfulLogin { get; }
        public abstract string userAlreadyExists { get; }
        public abstract string userRegistered { get;  }
        public abstract string accessTokenCreated { get;  }
    }
}