using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Dugum
    {
        public int Anahtar;
        public Dugum pSonraki;
        public Dugum(int Anahta)
        {
            this.Anahtar = Anahtar;
            pSonraki= null;
        
        
        }
        public override string ToString()
        {
            return Anahtar.ToString();
        }


      
    }

    class HashTable
    {
        public const int MAX = 10;
        public Dugum[] Veri = new Dugum[MAX];
        public HashTable();
            public void Ekle(int Anahtar);
public Dugum Getir (int Anahtar);
    public bool Cikar (int Anahtar);

    static void Main(string[] args)
    {
      } 
        
        
        public void Ekle (int Anahtar)
        {
        Dugum pYeni = new Dugum(Anahtar);
            int mod =  Anahtar % MAX;
            if (Veri[mod]== null)
            {
            Veri[mod]=pYeni;
                return;
            
            
            
            }

            Dugum pTemp = Veri[mod];
            while (pTemp.pSonraki != null)
                pTemp = pTemp.pSonraki;
            pTemp.pSonraki = pYeni;
        
        
        
        
        }
        
        
             





    }
    
    


}
