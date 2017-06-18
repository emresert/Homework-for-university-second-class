using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public static int Fa(int sayi)
        {
            if (sayi == 1)
                return 1;
            return sayi * Fa(sayi - 1);
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Fa(6));
        
        
        }
    }
}
