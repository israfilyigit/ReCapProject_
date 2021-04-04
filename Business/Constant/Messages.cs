using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constant
{
    public class Messages
    {
        public static string CarAdded = "Yeni araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string ErrorCarAdded = "Araba ekleme başarısız";
        public static string BrandAdded = "Ekleme Başarılı";
        public static string BrandDeleted = "Silme Başarılı";
        public static string BrandUpdate = "Güncelleme Başarılı";
        public static string ColorAdded = "Ekleme Başarılı";
        public static string ColorDeleted= "Silme Başarılı";
        public static string ColorUpdated = "Güncelleme Başarılı";

        public static string UserAdded { get; internal set; }
        public static string UserDeleted { get; internal set; }
        public static string UserUpdated { get; internal set; }
        public static string CustomerListed { get; internal set; }
        public static string CustomerDeleted { get; internal set; }
        public static string CustomerUpdated { get; internal set; }
        public static string RentalAdded { get; internal set; }
        public static string RentalDeleted { get; internal set; }
        public static string RentalUpdated { get; internal set; }
        public static string RentalNotAvailable { get; internal set; }
    }
}
