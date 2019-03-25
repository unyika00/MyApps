using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Köszöntlek a Városomban");
                
            var lista = new List<City>();

            lista.Add(new City() { Name = "Varsány", County = "magyar", Population = 1780 });
            lista.Add(new City() { Name = "Gyarmat", County = "magyar", Population = 16500 });
            lista.Add(new City() { Name = "Budapest", County = "magyar", Population = 1985000 });

            foreach (City item in lista)
            {
                Console.WriteLine(item.Name + " " + item.County + " " + item.Population);
            }
            lista.Remove(lista.Find(x => x.Name.Contains("Varsány")));

            Console.WriteLine("***************************************************");

            foreach (City item in lista)
            {
                Console.WriteLine(item.Name + " " + item.County + " " + item.Population);
            }

            Console.ReadKey();
        }
        
    }
}
