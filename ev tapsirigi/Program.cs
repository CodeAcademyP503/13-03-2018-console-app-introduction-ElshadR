using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev_tapsirigi
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //1. Ekrana girilen ededin nece reqemli oldugunu yazin.
             Console.Write("Ededi daxil edin: ");
             var eded = Convert.ToInt64(Console.ReadLine());
             var b = 1;            
             for(int i = 0; i < b; i++)
             {
                 if (eded / 10 != 0)
                 {
                     b++;                   
                     eded = eded /10;
                 }             
             }
             Console.WriteLine("eded"+" "+ b+" "+"reqemlidir.");
             Console.ReadLine();*/
            //2. daxil elediyimiz ededleri toplasin
           /* List<Int32> ededler = new List<Int32>();
            void dovr()
             {
                 Console.Write("ededi daxil et ve ya \"0\" daxil edib sonlandirin:  ");
                 var eded = Convert.ToInt32(Console.ReadLine()); //Console.ReadLine();
                 if (eded != 0)
                 {
                     dovr();
                     ededler.Add(eded);
                 }
             }
             dovr();
             void yazdir()
             {
                 int b = 0;
                 for(int i = 0; i < ededler.Count; i++)
                 {
                     b = b + ededler[i];
                 }
                 Console.WriteLine(b);
             }
             yazdir();*/
            //3.Ekrana daxil olan ifadenin sait ve samitlerini ayri ayri yazan proqram
            /*char[] sait = new char[] { 'a', 'i', 'e', 'o', 'y', 'A', 'I', 'E', 'O', 'Y' };
            char[] herif1 = new char[] { };
            char[] samit = new char[] { 'q', 'w', 'r', 't', 'p', 'd', 's', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'Q', 'W', 'R', 'T', 'U', 'P', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };
            Console.Write("Ifadeni daxil edin: ");
            string ifade = Console.ReadLine();
            char[] herif;
            herif = ifade.ToCharArray();
            void saityazdir()
            {
                for (int i = 0; i < herif.Length; i++)
                {
                    for (int j = 0; j < sait.Length; j++)
                    {
                        if (herif[i] == sait[j])
                        {
                            Console.Write(herif[i]+",");
                        }
                    }
                }
            }
            saityazdir();
            void samityazdir()
            {
                Console.WriteLine();
                Console.WriteLine("----------------------------");
                for(int i = 0; i < herif.Length; i++)
                {
                    for(int j = 0; j < samit.Length; j++)
                    {
                        if (herif[i] == samit[j])
                        {
                            Console.Write(herif[i]+",");
                        }
                    }
                }
                Console.WriteLine();
            }
            samityazdir();*/
            //4.Ekrandan daxil olunan cumlenin sozlerini tek tek ekrana cixaran program yazin
            /*Console.Write("ifadeni daxil edin: ");

            var ifade = Console.ReadLine();
            string sozler;
            sozler = ifade.ToString();
            void daxil_et()
            { 
                for (int i = 0; i < sozler.Length; i++)
                {
                    
                    if (sozler[i] != ' ')
                    {
                        Console.Write(sozler[i]);        
                    }
                    else if (sozler[i] == ' ')
                    {
                        Console.WriteLine();
                    }
                }
            }
            daxil_et();
            Console.WriteLine();*/


            //5.Menim keywords adinda bir listim var. List<string> keywords = new List<string>()
            //{ "Tenbel", "Kod yazmayan", "Yola Veren", "Esneyen", "Bekar" }
            //Ekrandan daxil olunan ifadede bu sozlerden her hansi biri kecirse
            //ekranda "Siz losersiniz " deye error vermesini isteyirem.
            /* string[] keywords = new string[] { "tenbel", "kod yazmayan", "yola veren", "esneyen", "bekar" };
             void daxil()
             {
                 Console.WriteLine("Ifadeni daxil edin: ");
                 string ifade = Console.ReadLine();               
                 string[] words = ifade.Split(',', ' ');
                 for (int i = 0; i < words.Length; i++)
                 {
                     for (int j = 0; j < keywords.Length; j++)
                     {
                         if (words[i] == keywords[j])
                         {
                             Console.WriteLine("-----------------------");
                             Console.WriteLine("siz losersiniz");
                             Console.WriteLine("-----------------------");
                         }

                     }
                 }
                     for (int k = 0; k < words.Length - 1; k++)
                     {
                         string towords = "kod";
                         string towords1 = "yazmayan";
                         string towords2 = "yola";
                         string towords3 = "veren";
                         if (towords == words[k] && towords1 == words[k + 1] || towords2 == words[k] && towords3 == words[k + 1])
                         {
                             Console.WriteLine("-----------------------");
                             Console.WriteLine("siz losersiniz");
                             Console.WriteLine("-----------------------");
                         }
                     }

                 daxil();
             }
             daxil();*/

            //6.Ekrandan daxil edilen ifade icerisinde "tenbel" sozu varsa eyni ifadeni sadece tenbel sozunun evezine
            // "loser" olaraq deyisdirerek yazdirmasini temin eden program yazin

            /*void yazdir()
            {
                Console.WriteLine("ifadeni yazin.");
                string ifade = Console.ReadLine();
                string ifadesonra = ifade.Replace("tenbel", "loser");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("deyisdirilmis ifade.");
                Console.WriteLine(ifadesonra);
                Console.WriteLine("---------------------------------");
                yazdir();
            }
            yazdir();*/
            //7.Bankomatdan pul cekmeye gedmisem.Ekrandan cekmek istediyim pul migdarini daxil edirem.
            //    Bankomat mene mumkun olan en boyuy eskinazlari vermelidir.meselen: 754 azn pul cekmek 
            //    isteyiremse 7 eded yuzluk 1 eded 50 lik ve 4 eded birlik eskinaz vermelidir.Bunu 
            //    reallasdiracaq proqram yazin.
            /*List<int> eded1 = new List<int> { 100, 50, 20, 10, 5, 1 };
            List<string> sozler = new List<string> { "yuzduk", "ellilik", "iyirmilik", "onluq", "beslik", "birlik" };
            var eded = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < eded1.Count; i++)
            {
                if (eded >= eded1[i])
                {
                    var reqem = eded / eded1[i];
                    eded = eded - reqem * eded1[i];
                    Console.WriteLine(reqem + " - " + sozler[i]);
                }

            }*/
        }

    }
}
