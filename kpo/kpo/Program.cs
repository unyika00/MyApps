using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpo
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            ///program:Kő papir olló játék leprogramozása
            ///Adatt: számítógép - véletlenszerű választ k/p/o
            ///játékosok: billenytűzeten választ
            ///megoldandó feladat 1:
            ///ciklus programfutás,amig a felhasználó szeretne játszani 
            ///
            bool moreGame = true;
            Console.WriteLine("*****Kö/Papir/Olló játék*********");

            do
            {

                Console.Write("Akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    moreGame = false;
                }


            } while (moreGame);

            Console.ReadKey();

            
        }
    }
}
