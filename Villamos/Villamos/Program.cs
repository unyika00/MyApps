using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villamos
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, u, i;
            string sChoice;

            
            Console.Write("kérem irja be mit akkar kiszámolni ");
            sChoice = Console.ReadLine();
            if (sChoice == "ru")
            {
                Console.WriteLine("kérem az r értékét:");
                r = int.Parse(Console.ReadLine());

                Console.WriteLine("kérem az u értékét:");
                u = int.Parse(Console.ReadLine());

                Console.Write("Az i  értéke:");
                Console.WriteLine(Math.Sqrt(i == r / u));

                Console.ReadKey();

               
            }

        }

            
        }
        
    }




           
