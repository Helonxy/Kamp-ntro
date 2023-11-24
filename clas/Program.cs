internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    internal class Program
    {
        private static void Main(string[] args, kurs kurs1, kurs kurs2, kurs kurs3)
        {
            string adi = "Engin";
            int yas = 31;


            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Suleyman sonmez";
            kurs1.IzlenmeOrani = 71;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Mert";
            kurs2.IzlenmeOrani = 68;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Suleyman ";
            kurs3.IzlenmeOrani = 57;




            // Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }



        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }
    }
}