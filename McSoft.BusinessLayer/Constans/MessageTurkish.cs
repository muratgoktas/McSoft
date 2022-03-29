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
    public class MessageTurkish : IMessages
    {
        public static string AddedMessage => "Yeni Kayıt Eklendi!";

        public static string DeletedMessage => "Bu Kayıt Silindi!";

        public static string UpdatedMessage => "Bu Kayıt Güncellendi!";

        public static string UserNotFound => "Kullanıcı bulunamadı!";

        public static string PasswordError => "Şifre Hatası!";

        public static string SuccessfulLogin => "Başarılı Giriş!";

        public static string UserAlreadyExists => "Kullanıcı Zaten Var!";

        public static string UserRegistered => "Kullanıcı Başarıyla Kaydedildi!";

        public static string AccessTokenCreated => "AccessToken Oluşturuldu!";
    }
}
