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
            
            Console.Write("K�rem a gy�m�lcs�k sz�m�t:");
            gyumolcsszam  = int.Parse(Console.ReadLine());

            for (int i = 0; i < gyumolcsszam; i++)
            {
                Console.Write("K�rem a(z) {0}. gy�m�lcs�t: ", i + 1);
                Nev = Console.ReadLine();
                Console.Write("K�rem a(z) {0}. gy�m�lcs sz�rmaz�si hely�t : ", i + 1);
                Szarmhely = Console.ReadLine();
                Console.Write("K�rem a(z) {0}. gy�m�lcs menyis�ge : ", i + 1);
                Menny = int.Parse(s: Console.ReadLine());





                myfruit[i] = new Fruit();
                myfruit[i].Nev = Nev;
                myfruit[i].Szarmhely = Szarmhely;
                myfruit[i].Menny = Menny;



            }
            Console.WriteLine("A gy�m�lcs tartalma");
            for (int i = 0; i < gyumolcsszam; i++)
            {

                Console.WriteLine(value: myfruit[i].Nev);


            }
            Console.ReadKey();

        }
    }
}
