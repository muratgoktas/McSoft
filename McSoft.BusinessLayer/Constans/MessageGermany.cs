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
        public static string AddedMessage => "Neuer Rekord hinzugefügt!";

        public static string DeletedMessage => "Dieser Datensatz wurde gelöscht!";

        public static string UpdatedMessage => "Dieser Datensatz wurde aktualisiert!";

        public static string UserNotFound => "Benutzer nicht gefunden!";

        public static string PasswordError => "Passwort-Fehler!";

        public static string SuccessfulLogin => "Anmeldung erfolgreich!";

        public static string UserAlreadyExists => "Benutzer existiert bereits!";

        public static string UserRegistered => "Benutzer erfolgreich registriert!";

        public static string AccessTokenCreated => "Zugriffstoken erstellt!";
    }
}
