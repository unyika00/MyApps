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


            Console.Write("Kérem a gyümölcsök számát:");
            gyszam = int.Parse(Console.ReadLine());

            for (int i = 0; i < gyszam; i++)
            {
                Console.Write("Kérem a(z) {0}. gyümölcsöt: ", i + 1);
                nev = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. gyümölcs származási helyét : ", i + 1);
                Szarm = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. gyümölcs menyisége : ", i + 1);
                Mennyi = int.Parse(s: Console.ReadLine());

                osszmenny += Mennyi;



                myfruits.Add(new Fruit(nev, Szarm, Mennyi));
            }

            {




            }
            Console.WriteLine("Gyümölcsök összes mennyisége:" + osszmenny );
            Console.ReadKey();

        }
    }
}
