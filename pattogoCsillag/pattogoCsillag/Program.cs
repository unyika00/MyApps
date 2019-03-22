using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattogoCsillag
{
    class Program
    {
        const int XWIDTH = 30;
        const int YWIDTH = 20;
        const char BALL = '*';
        static void Main(string[] args)
        {

            int x = 15, y = 0;
            int xvect = 1;
            int yvect = 1;


            Console.CursorVisible = false;
            Console.SetCursorPosition(0, YWIDTH + 1);
            Console.Write("Képernyő mérete: [{0}x{1}]", XWIDTH, YWIDTH);
            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("{0}", BALL);
                System.Threading.Thread.Sleep(50);
                Console.SetCursorPosition(x, y);
                Console.Write(" ");
                x += xvect;
                y += yvect;

                if (y == YWIDTH || y == 0)
                {
                    yvect *= -1;
                }
                if (x == XWIDTH || x == 0)
                {
                    xvect *= -1;
                }

            }//endwhile
        }
    }
}
