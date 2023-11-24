using metotlarr;

internal class Program
{
    private static void Main(string[] args)
    {
        



        Urun urun1  = new Urun();
        urun1.Adi = "Elma";
        urun1.Fiyati = 15;
        urun1.Aciklama = "Amasya elmasi";
        urun1.StokAdedi = 125;

        Urun urun2 = new Urun();
        urun2.Adi = "Karpuz";
        urun2.Fiyati = 80;
        urun2.Aciklama = "Diyarbakir Karpuzu";
        urun2.StokAdedi = 58;

        Urun urun3 = new Urun();
        urun3.Adi ="Marul";
        urun3.Fiyati =  7;
        urun3.Aciklama = "Göbekk inceltir";
        urun3.StokAdedi = 320;

        //-------------------------------------------//

        Urun[] urunler = new Urun[] { urun1, urun2, urun3};

        //type-safe - - tip güvenli
        foreach (Urun urun in urunler)
        {
              
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("----------->");
    
        }

        Console.WriteLine("----------Metotlar----------");

        //instance - örnek
        //Encapsulation


        SepetManager sepetManager = new SepetManager();
        sepetManager.Ekle(urun1);
        sepetManager.Ekle(urun2);
        sepetManager.Ekle(urun3);

        //----------------------------------------------------------//



     
        sepetManager.Ekle2("Armut","Yeşil",28 ,23);
        sepetManager.Ekle2("Elma", "Kırmızı Elma", 23,54);
        sepetManager.Ekle2("Çilek", "Mardin Çileği", 51,28);
    }
}



// Dont repeat yourself - DRY - Clean Code - Best Practice