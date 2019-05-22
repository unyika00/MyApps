using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB05200
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hozzunk létre egy 15 elemű int tömböt,aminek a neve iArray
            int[] iArry = new int[15];
            //Hozzunk létre 5 elemű szöveg tárolására alkalmas tömböt 
            string[] sArray = new string[5];
            //Hozzunk létre egy int tömböt,amit feltöltünk 3db elemel(5,8,9)
            int[] iT = new int[] { 5, 8, 9 };
            //Hozzunk létre 2 dimenziós tömböt egész számoknak ((4,5)(2,3)(6,8))
            int[,] iT3 = new int[,] { { 4,5 } ,{ 2,3 } ,{ 6,8 } };
            try
            {
               Console.WriteLine(iT3[2, 1]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Három dim tömb
            int[,,] iT4 = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 {{ 7, 8, 9 },{10, 11, 12} } };
            
            try
            {
                Console.WriteLine(iT4[1, 1, 9]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            for (int i = 0; i < 50; i++)
            {
                if ((i%3)== 0)
                {
                    Console.WriteLine(i);

                }
                
            }

            //Feladat 50 ig a primszámok keresése
            //primszám egyel és önmagán kivül nem lehet osztani 
            for (int i = 0; i < 50; i++)
            {
                if ((i % 3) == 0)
                {
                    int[] szamok = new int[30];
                    Random rnd = new Random();
                    int min = 1, max = 100,  j, k, m, n;
                    bool b = true;
                    for (i = 0; i < 30; i++)
                    {
                        do
                        {
                            j = i - 1;
                            k = rnd.Next(min, max);
                            while (j > -1)
                            {
                                if (k == szamok[j])
                                {
                                    k = 0;
                                    j = 0;
                                }
                                j--;
                            }
                            if (k > 0)
                            {
                                szamok[i] = k;
                                b = true;
                                if (k != 2)
                                {
                                    if (k < 2 || (k % 2) == 0) b = false;
                                    else
                                    {
                                        m = 3;
                                        n = (int)Math.Sqrt(k);
                                        while (m <= n && b)
                                        {
                                            if ((k % m) == 0) b = false;
                                            m += 2;
                                        }
                                    }
                                }
                            }
                        } while (k == 0);
                        Console.WriteLine(k + ":    " + (b ? "Prímszám." : "Nem Prímszám."));
                    }
                    Console.ReadLine();

                }


                Console.ReadKey();

            }
        }
    }
}
