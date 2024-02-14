using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    { 
        string kategoriEtiketi = "kategoriler";
        int ogrenciSayisi = 12334;
        double faizOrani = 1.45;
        bool sistemeGirişYapmisMi = true;
        double dolarDun = 7.35;
        double dolarBugun = 7.45;

        if (dolarDun>dolarBugun)
        {
            Console.WriteLine("azalış butonu");
        }

        else if (dolarDun<dolarBugun)
                {
            Console.WriteLine("artış butonu");
        }
        else
        {
            Console.WriteLine("değişmedi butonu");
        }

        if (sistemeGirişYapmisMi == true)
        {
            Console.WriteLine("Kullanıcı Ayarları Butonu");

        }
        else
        {
            Console.WriteLine("Giriş Yap Butonu");
        }
       



    }
}