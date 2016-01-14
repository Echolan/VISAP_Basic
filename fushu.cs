using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fushu
{
    class fushu
    {
        static void Main(string[] args)
        {
            double x1 = 0;
            double x2 = 0;
            double shibu = 0;
            double xubu = 0;
            Console.WriteLine("求方程a^2+bx+c=0");
            Console.WriteLine("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("c=");
            double c = Convert.ToDouble(Console.ReadLine());
            double deta = b * b - 4 * a * c;
            if (deta < 0)
            {   
                shi = -b/(2*a);
                xu = Math.Sqrt(-deta)/(2*a);
                Console.WriteLine("复数根x1={0}+{1}i", shi,xu);
                Console.WriteLine("复数根x2={0}-{1}i", shi,xu);
            }
            else if (deta == 0)
            {
                x1 = -b / 2 * a;
                Console.WriteLine("只有一个解x={0}", x1);
            }
            else
            {
                x1 = (-b + Math.Sqrt(deta)) / (2 * a);
                x2 = (-b - Math.Sqrt(deta)) / (2 * a);
                Console.WriteLine("x1={0}", x1);
                Console.WriteLine("x2={0}", x2);

            }
            Console.ReadKey();
        }
    }
}
