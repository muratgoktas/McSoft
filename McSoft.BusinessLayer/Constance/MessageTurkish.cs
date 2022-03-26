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
    public class MessageTurkish : MessagesDictionaryBase
    {
        public override string addedMessage => "Yeni Kayıt Eklendi!";

        public override string deletedMessage => "Bu Kayıt Silindi!";

        public override string updatedMessage => "Bu Kayıt Güncellendi!";

        public override string userNotFound => "Kullanıcı bulunamadı!";

        public override string passwordError => "Şifre Hatası!";

        public override string successfulLogin => "Başarılı Giriş!";

        public override string userAlreadyExists => "Kullanıcı Zaten Var!";

        public override string userRegistered => "Kullanıcı Başarıyla Kaydedildi!";

        public override string accessTokenCreated => "AccessToken Oluşturuldu!";
    }
}
