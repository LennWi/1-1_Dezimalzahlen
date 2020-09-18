using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung2_HSP_1
{
    class Program
    {
        static void Main()
        {
            double zahl = 1.0;
            
            for (int i = 0; i < 12; i++)
            {
                zahl = zahl - 0.1;
                
                if (Math.Round(zahl, 1) == 0)
                {
                    Console.WriteLine(Math.Round(zahl, 1) + " <- Da ist die Null!");
                }
                else
                {
                    Console.WriteLine(Math.Round(zahl, 1));
                }
            }

            Console.ReadKey();
        }
    }
}
