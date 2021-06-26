using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Constants
{
    // static verilince new'lemeye gerek kalmaz uygumaya hayati boyunca 1 referansi olur.
    public static class Messages
    {
        // public oldugu icin PascalCasing olarak yazilir
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
    }
}