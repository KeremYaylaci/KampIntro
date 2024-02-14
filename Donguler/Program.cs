internal class Program
{
   

    private static void Main(string[] args)
    {
        string[] kurslar = new string[] {"yazılım geliştirici kampı", "programlamaya başlangıç kampı",
        "java","Phyton"};
        

        for (int i = 0; i < kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }
        Console.WriteLine("for bitti");

        foreach (string kurs in kurslar)
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("--------------");
        }

        Console.WriteLine("Sayfa sonu - footer");
    }
}