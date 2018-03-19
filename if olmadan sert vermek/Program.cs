using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_olmadan_sert_vermek
{
    class Program
    {
        static void Main(string[] args)
        {
            // if else keywordleri istifade etmeden sert yazin (meselen verilen a deyeri
            //>50 dirse ekrana meqbuldur <50 dirse qeyri-meqbuldur yazilsin )
            var a = Convert.ToInt32(Console.ReadLine());
            bool a01 = a < 50 && meqbuldeyil(true);
            bool a02 = a > 50 && meqbul(true);
            bool meqbul(bool b)
            {
                Console.WriteLine("meqbul ");
                return b ;
            }
            bool meqbuldeyil(bool b)
            {
                Console.WriteLine("meqbul deyil ");
                return b;
            }
        }
    }    
}
