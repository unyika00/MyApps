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

            string compChoice = "";
            string playerChoice = "";

            int compScore = 0;
            int PlayerScore = 0;

            Console.WriteLine("*******Kő/Papir/Olló játék******");


            do
            {

                Console.WriteLine("Mit választasz? k/p/o");

                switch (Console.ReadKey(true).KeyChar)
                {

                    case 'k':
                        playerChoice = "kő";
                        break;
                    case 'p':
                        playerChoice = "papir";
                        break;
                    case 'o':
                        playerChoice = "olló";
                        break;


                }

                Console.Write("akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    moreGame = false;
                }

            } while (moreGame);

           
        }
    }
    
}

            
        