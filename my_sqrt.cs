using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ceshigit
{
    class my_sqrt
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.WriteLine("Enter a number:");
                double num_sqrt = Convert.ToDouble(Console.ReadLine());
                double num_ori = 9;
                for (int i = 1; i <= 100; i++)
                {
                    num_ori = (num_ori + num_sqrt / num_ori) / 2;
                }
                Console.WriteLine("{0}", num_ori);
            }
        }
    }
}