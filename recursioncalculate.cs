using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
       /* 
        public static int Usthesaplama(int taban, int us)
        {
            int toplam = 1; 
            for (int i = 0; i < us; i++)
            {
                toplam *= taban;
                
            }
            return toplam;


        }
        */
        public static int usthesaplamaf(int tb, int ust)
        {
            if (ust==1)
            return tb;
            return tb* usthesaplamaf(tb,ust - 1);
        
        }



        static void Main(string[] args)
        {
            Console.WriteLine(usthesaplamaf(2,5));

            Console.ReadLine();
        }
    }
}
