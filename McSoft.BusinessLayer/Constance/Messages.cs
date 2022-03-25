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
    }
}
