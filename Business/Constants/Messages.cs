using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersizdir";
        public static string MaintenanceTime= "Sistem bakımda";
        public static string ProductsListed= "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "İki ürün adı aynı olamaz";

        public static string CategoryLimitExceded = "Kategori Limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="Bu alana giriş yetkiniz yok";

        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı bir şekilde giriş yapıldı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token Oluşturuldu";

        public static string ProductUpdated = "Ürün güncellendi";
    }

    //Rıdvan Üçdağ
    //github.com/ridvanucdag
    //linkedin.com/ridvanucdag
}
