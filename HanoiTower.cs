using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Utility utility = new Utility();
            for (int TotalDiscCount = 3; TotalDiscCount <= 5; TotalDiscCount++)
            {
                Console.WriteLine("Disk sayısı {0}\tToplam Hamle Sayısı {1}", TotalDiscCount, Math.Pow(2, TotalDiscCount) - 1);
                utility.Move(TotalDiscCount, (int)Pole.A, (int)Pole.C, (int)Pole.B);
                Console.WriteLine("");
            }
        }
        class Utility
        {
            public void Move(int n, int from, int to, int via)
            {
                if (n == 1)
                { Console.WriteLine("{0}-->{1}", (Pole)from, (Pole)to); }
                else
                {
                    Move(n - 1, from, via, to);
                    Move(1, from, to, via);
                    Move(n - 1, via, to, from);
                }
            }
        }
        enum Pole
        { A = 1, B = 2, C = 3, }
    }
}