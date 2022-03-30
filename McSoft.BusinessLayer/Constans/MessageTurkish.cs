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
        public  string AddedMessage => "Yeni Kayıt Eklendi!";

        public  string DeletedMessage => "Bu Kayıt Silindi!";

        public  string UpdatedMessage => "Bu Kayıt Güncellendi!";

        public  string UserNotFound => "Kullanıcı bulunamadı!";

        public  string PasswordError => "Şifre Hatası!";

        public  string SuccessfulLogin => "Başarılı Giriş!";

        public  string UserAlreadyExists => "Kullanıcı Zaten Var!";

        public  string UserRegistered => "Kullanıcı Başarıyla Kaydedildi!";

        public  string AccessTokenCreated => "AccessToken Oluşturuldu!";
    }
}
