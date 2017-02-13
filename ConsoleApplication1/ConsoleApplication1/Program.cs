using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace happy_ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            int ticket;
            int s = 0, c, first, second, k, sfirst = 0, ssecond = 0;
            ticket = Convert.ToInt32(Console.ReadLine());
            while (ticket != 0)
            {
                c = ticket % 10;
                s++;
                ticket = ticket / 10;
            }
            if (s == 6)
            {
                first = ticket % 1000;
                second = ticket / 1000;
                while (first != 0)
                {
                    k = first % 10;
                    sfirst = sfirst + k;
                    first = first / 10;
                }
                while (second != 0)
                {
                    k = second % 10;
                    ssecond = ssecond + k;
                    second = second / 10;
                }
                if (first == second)
                {
                    Console.WriteLine("happy");
                }
                else
                {
                    Console.WriteLine("not happy");
                }

            }
            Console.ReadKey();
        }
    }
}
