using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        public static void insertion_sort(int[] dizi)
    {
      for (int j = 1; j < dizi.Length; j++)
      {
        int key = dizi[j];
        int i = j - 1;
        while (i >= 0 && dizi[i] > key)
        {
          dizi[i + 1] = dizi[i];
          i = i - 1;
        }
        dizi[i + 1] = key;
      }
    }
 
   

        static void Main(string[] args)
        {
            /*Insertion Sort Kullanımı*/
            int[] dizi = { 12, 3, 8, 5, 15, 12, 45, 31 };
            insertion_sort(dizi);
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            
                
                

        }
    }
}
