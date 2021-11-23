using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 10; a++)
            {
                if (a == 8)
                {
                    continue;

                }
                Console.WriteLine("a nın değeri : " + a);
            }
            Console.ReadLine();
        }
    }
}
