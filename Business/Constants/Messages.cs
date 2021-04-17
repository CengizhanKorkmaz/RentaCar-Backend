using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string NoCar = "Sistemde hiç araba yok.";
        public static string NoCarId = "Bu id ' de araba yok.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarListed = "Arabalar listelendi.";
        public static string NoBrandCar = "Bu markada araba yok.";
        public static string NoCarOfColor = "Bu renkte araba yok.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted="Renk silindi.";
        public static string NoColor = "Sistemde renk yok.";
        public static string ColorListed = "Renkler listelendi.";
        public static string NoColorId = "Bu id sahip renk yok.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandListed = "Markalar listelendi.";
        public static string NoBrandId = "Bu id marka yok.";
        public static string NoBrand = "Sistemde marka yok.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandAdded = "Marka eklendi.";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserListed = "Kullanıcılar listelendi.";
        public static string NoUser = "Sistemde kullanıcı yok.";
        public static string NoUserId = "Sistemde bu id de bir kullanıcı yok.";
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerListed = "Müşteriler listelendi.";
        public static string NoCustomer = "Sistemde müşteri yok.";
        public static string NoCustomerId = "Sistemde bu id de müşteri yok.";
        public static string CarLeaseSuccessful = "Araç kiralandı.";
        public static string RentalUpdated = "Araç durumu düzenlendi.";
        public static string RentalDeleted = "Araç kiralamayı sil.";
        public static string RentedCars = "Kiralanan araçlar listelendi.";
        public static string ImageAdded = "Resim eklendi.";
        public static string ImageUpdated = "Resim güncellendi.";
        public static string ImageDeleted = "Resim silindi.";
        public static string ImageListed = "Resimler listelendi.";
        public static string GetOperations = "Operasyonlar çağrıldı.";
        public static string GetEmail = "Kullanıcı getirildi.";
        public static string CarImageLimit = "En fazla 5 resim ekleyebilirsiniz.";
        public static string PasswordError = "Parola hatası.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string AccessTokenCreated = "Token oluşturuldu.";

        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}
