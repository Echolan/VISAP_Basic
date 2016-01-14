using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi
{
    class pi
    {
        static void Main(string[] args)
        {
            int n;
            double pi_c, t2, t1;
            n = 1;
            t1 = 1;
            pi_c = 1;
            t2 = 1;
            for(int i = 1; i <= 10000; i++)
            {   
                n = n + 2;
                t1 = -t1;
                t2 = t1 / n;
                pi_c = pi_c + t2;
            }
            pi_c = 4 * pi_c;
            Console.WriteLine(pi_c);
            Console.ReadKey();
        }
    }
}
