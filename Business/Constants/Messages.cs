namespace Business.Constants
{
    // static verilince new'lemeye gerek kalmaz uygumaya hayati boyunca 1 referansi olur.
    public static class Messages
    {
        // public oldugu icin PascalCase olarak yazilir
        // private olsaydi camelCase olarak yazilabilir
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir Kategoride En Fazla 10 urun olabilir";
        public static string ProductNameAlreadyExists= "Bu isimde zaten baska bir urun var.";
        public static string CategoryLimitExceded = "Kategori Limiti Asildigi icin yeni urun eklenemiyor";
    }
}