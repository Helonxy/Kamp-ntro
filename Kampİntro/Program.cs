internal partial class Program
{
    private static void Main(string[] args)
    {
        // type safety - tip güvenliği
           // DO NOT REPEAT YOURSELF - KENDİNİ TEKRAR ETME
        string kategoriEtiketi = "Kategori";

        int ogrenciSayisi = 32000;
        double faizorani = 1.45;
        Boolean sitemGirisYapmisMi = false;
        double dolarDun = 7.75;
        double dolarBugun = 7.45;

        if (dolarDun>dolarBugun )
        {
            Console.WriteLine("Azalış Butonu");
        }
        else if (dolarBugun<dolarDun)
        {
            Console.WriteLine("Artış Butonu");
        }
        else 
        {
            Console.WriteLine("Değişmedi butonu");
        }

        bool sistemeGirisYapmisMi = true;

        if (sistemeGirisYapmisMi == true)
        {
            Console.WriteLine("Kullanıcı Ayarları butonu");
        }
        else
        {
            Console.WriteLine("Giriş yap butonu");
        }

        Console.WriteLine(kategoriEtiketi);
    }
}