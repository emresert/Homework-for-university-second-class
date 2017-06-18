using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {

       
        static void Main(string[] args)
        {
            int[] dizi = new int[5];
            dizi[0] = 43;
            dizi[1] = 12;
            dizi[2] = 36;
            dizi[3] = 2;
            dizi[4] = 56;
            SelectionSort(dizi, dizi.Length);
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
        }

        public static void SelectionSort(int [] dizi, int n)
        {
                    int i, j, min;
                    for (i = 0; i < n; i++)
                    {
                        min = i;
                        for (j = i + 1; j < n; j++)
                        {
                            if (dizi[j] < dizi[min]) min = j;
                        }
                        int temp=dizi[i];
                        dizi[i]=dizi[min];
                        dizi[min]=temp;
                    }
         } 
            }
}
