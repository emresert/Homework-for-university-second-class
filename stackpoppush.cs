using System;
using System.Collections; // Stack sınıfı bu isim alanı içinde bulunur.


class YiginSinifi1
{
    public static void Main(string[] args)
    {
        // Stack sınıfından yigin nesnemizi tanımlıyoruz.
        Stack yigin = new Stack();

        // Yigini değişik değerlerde dolduruyoruz..
        yigin.Push(12);
        yigin.Push(5);
        yigin.Push(23);
        yigin.Push(34);
        yigin.Push(70);
        yigin.Push("A");

        Console.WriteLine("Yığımızın ilk hali...");
        ElemanlariYaz(yigin);

        // Yigininin tepesinden bir sayı aldık 
        // ve bunu sayi değişkenine atayıp ekrana yazdıralım
       int sayi = (int)yigin.Pop();
        Console.WriteLine("\n Yığından {0} sayısını aldık", sayi);

        // Yigininin tepesinden bir sayı daha aldık 
        // ve bunu sayi değişkenine atayıp ekrana yazdıralım
        sayi = (int)yigin.Pop();
        Console.WriteLine("\n Yığından {0} sayısını aldık", sayi);

        // Şimdi ise Yigininin tepesindeki sayıya bir bakalım
        // bu sayıyı yığından çıkarmıyoruz.. Sadece ne olduğuna bakıyoruz..
        sayi = (int)yigin.Peek();
        Console.WriteLine("\n Yığının tepesindeki sayı şu anda : {0}", sayi);
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