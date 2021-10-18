using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weaponsystem2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Double Nested Loops");
            Console.WriteLine();
            
            for (int i = 0; i <= 9; i++)
            {

                Console.WriteLine("i + " + i);
                Console.WriteLine("We're about to do a loop with j: ");


                for (int j = 0; j <= 9; j++)
                {
                    Console.WriteLine(i + ""  + j);
                }

            }



            for (int i = 0; i <= 9; i++)
            {




                for (int j = 0; j <= 9; j++)
                {
                    Console.WriteLine(i + "" + j);
                }

            }



            Console.ReadKey();
        }
    }
}
