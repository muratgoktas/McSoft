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
    public class MessageGermany : IMessages
    {
        public  string AddedMessage => "Neuer Rekord hinzugefügt!";

        public  string DeletedMessage => "Dieser Datensatz wurde gelöscht!";

        public  string UpdatedMessage => "Dieser Datensatz wurde aktualisiert!";

        public  string UserNotFound => "Benutzer nicht gefunden!";

        public  string PasswordError => "Passwort-Fehler!";

        public  string SuccessfulLogin => "Anmeldung erfolgreich!";

        public  string UserAlreadyExists => "Benutzer existiert bereits!";

        public  string UserRegistered => "Benutzer erfolgreich registriert!";

        public  string AccessTokenCreated => "Zugriffstoken erstellt!";
    }
}
