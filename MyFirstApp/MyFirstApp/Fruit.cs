using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Fruit
    {
        public string Nev;
        public string Szarmhely;
        public int Menny;

        public Fruit(string aNev, string aSzhely, int aMenny)
        {
            Nev = aNev;
            Szarmhely = aSzhely;
            Menny = aMenny;
            Console.WriteLine("DEBUG: Fruit() konstruktor meghivás");
        }
    }
}
