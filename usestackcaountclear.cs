using System;
using System.Collections; // Stack sınıfı bu isim alanı içinde bulunur.


class YiginSinifi1
{
    public static void Main(string[] args)
    {
        // Stack sınıfından yigin nesnemizi tanımlıyoruz.
        Stack yigin = new Stack();

        // Yığınımıza yeni elemanlar ekliyoruz.
        yigin.Push("Ahmet");
        yigin.Push("Sefer");
        yigin.Push("Cemal");
        yigin.Push("Onur");
        yigin.Push("Aziz");

        // Yığında kaç tane eleman bulunduğunu bulup yazalım.
        int elemanSayisi = yigin.Count;
        Console.WriteLine("\nYığınımızdaki eleman sayısı: {0}", elemanSayisi);

        // Yığındaki elemanlar.
        Console.WriteLine("\nYığındaki elemanlar: ");
        ElemanlariYaz(yigin);

        //Contains() metodunun kullanımı:
        if (yigin.Contains("43"))
           
            
        // Yığını boşaltalım.
        yigin.Clear();

        // Yığını boşalttıktan sonra kaç tane eleman bulunduğunu bulup yazalım.
        elemanSayisi = yigin.Count;
        Console.WriteLine("\nYığınımızdaki eleman sayısı: {0}", elemanSayisi);

        Console.ReadLine();
    }

    public static void ElemanlariYaz(Stack yigin)
    {
        object obj = new Object();
        Stack yeniYigin = (Stack)yigin.Clone();

        if (yigin.Count != 0)
        {
            while (yeniYigin.Count > 0)
            {
                obj = yeniYigin.Pop();
                Console.WriteLine("\t" + obj.ToString());
            }
        }
        else Console.WriteLine("Yığın boş...!");
    }
}