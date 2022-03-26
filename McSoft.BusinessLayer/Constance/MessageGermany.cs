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

        public override string userNotFound => "Benutzer nicht gefunden!";

        public override string passwordError => "Passwort-Fehler!";

        public override string successfulLogin => "Anmeldung erfolgreich!";

        public override string userAlreadyExists => "Benutzer existiert bereits!";

        public override string userRegistered => "Benutzer erfolgreich registriert!";

        public override string accessTokenCreated => "Zugriffstoken erstellt!";
    }
}
