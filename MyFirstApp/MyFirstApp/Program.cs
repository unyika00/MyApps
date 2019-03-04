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
        private static int gyumolcsszam;

        static void Main(string[] args)
        {
            Fruit [] myfruit  = new Fruit[5];

            string Nev;
            string Szarmhely;
            int Menny;
            
            Console.Write("Kérem a gyümölcsök számát:");
            gyumolcsszam  = int.Parse(Console.ReadLine());

            for (int i = 0; i < gyumolcsszam; i++)
            {
                Console.Write("Kérem a(z) {0}. gyümölcsöt: ", i + 1);
                Nev = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. gyümölcs származási helyét : ", i + 1);
                Szarmhely = Console.ReadLine();
                Console.Write("Kérem a(z) {0}. gyümölcs menyisége : ", i + 1);
                Menny = int.Parse(s: Console.ReadLine());





                myfruit[i] = new Fruit();
                myfruit[i].Nev = Nev;
                myfruit[i].Szarmhely = Szarmhely;
                myfruit[i].Menny = Menny;



            }
            Console.WriteLine("A gyümölcs tartalma");
            for (int i = 0; i < gyumolcsszam; i++)
            {

                Console.WriteLine(value: myfruit[i].Nev);


            }
            Console.ReadKey();

        }
    }
}
