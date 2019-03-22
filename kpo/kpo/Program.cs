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
            Random rnd = new Random();

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





                ///Feladat 4:
                ///Számitogép választásának kérdése: Random ()
                ///
                switch (rnd.Next(0, 3))
                {
                    case 0:
                        compChoice = "kő";
                        break;
                    case 1:
                        compChoice = "papir";
                        break;
                    case 2:
                        compChoice = "olló";
                        break;


                }

                if (
                    (playerChoice == "kő" && compChoice == "papir") ||
                    (playerChoice == "papir" && compChoice == "olló") ||
                    (playerChoice == "olló" && compChoice == "kő")
                    )
                {

                    Console.WriteLine("számítógép:" + compChoice + " te:" + playerChoice);
                    Console.WriteLine("veszttettél! Állás: Szg: {0} játékos: {1}", ++compScore, PlayerScore);


                }
                else if (playerChoice == compChoice)

                {
                    Console.WriteLine("számítógép:" + compChoice + " te:" + playerChoice);
                    Console.WriteLine("Döntetlen! Állás: Szg: {0} játékos: {1}", compScore, PlayerScore);
                }
                
                else
                    
                {
                    Console.WriteLine("számítógép:" + compChoice + " te:" + playerChoice);
                    Console.WriteLine("Nyertél! Állás: Szg: {0} játékos: {1}", compScore, ++PlayerScore);
                }

        

                Console.WriteLine("akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    moreGame = false;
                }

            } while (moreGame);
        }
    }
}
    



            
        