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
    public class MessageGermany : MessagesDictionaryBase
    {
        public override string addedMessage => "Neuer Rekord hinzugefügt!";

        public override string deletedMessage => "Dieser Datensatz wurde gelöscht!";

        public override string updatedMessage => "Dieser Datensatz wurde aktualisiert!";
    }
}
