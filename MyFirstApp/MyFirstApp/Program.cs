using MyFirstApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program  
{
    class Program
    {
       

        static void Main(string[] args)
        {
           var myfruits = new List<Fruit>(15000);

            string nev;
            string Szarm;
            int Mennyi;
            int gyszam;
            int osszmenny = 0;


            Console.Write("K�rem a gy�m�lcs�k sz�m�t:");
            gyszam = int.Parse(Console.ReadLine());

            for (int i = 0; i < gyszam; i++)
            {
                Console.Write("K�rem a(z) {0}. gy�m�lcs�t: ", i + 1);
                nev = Console.ReadLine();
                Console.Write("K�rem a(z) {0}. gy�m�lcs sz�rmaz�si hely�t : ", i + 1);
                Szarm = Console.ReadLine();
                Console.Write("K�rem a(z) {0}. gy�m�lcs menyis�ge : ", i + 1);
                Mennyi = int.Parse(s: Console.ReadLine());

                osszmenny += Mennyi;



                myfruits.Add(new Fruit(nev, Szarm, Mennyi));
            }

            {




            }
            Console.WriteLine("Gy�m�lcs�k �sszes mennyis�ge:" + osszmenny );
            Console.ReadKey();

        }
    }
}
