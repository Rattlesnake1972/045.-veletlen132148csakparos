using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _045.veletlen132148csakparos
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 132; i < 149; i++)    // 9 darab páros számot fog generálni véletlen sorrendben, mert a 132 és a 148 között 9 db páros szám van. De van amelyiket kétszer is legenerálja.

                if (i % 2 == 0)

                {
                    Console.WriteLine(random.Next(132, 149));
                }

            Console.ReadKey();
        }
    }
}
