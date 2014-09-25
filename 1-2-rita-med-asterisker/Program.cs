using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_rita_med_asterisker
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int row = 0; row < 25; row++) // for satsen räknar raderna
            {
                if (row % 2 == 1) 
                {
                  Console.Write(" "); 
                }
                switch (row % 3) //switch satsen sätter färgerna
                {
                    case 0:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                    case 1:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                    case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                }

                for (int col = 0; col < 39; col++) //räknar columnerna
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
            

            
        }
    }
}
