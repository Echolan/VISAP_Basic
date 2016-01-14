using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huigui
{
    class program
    {
        static void Main(string[] args)
        {
            float[] x = { 0, 1, 2, 3, 4 };
            float[] y = { 2, 3, 5, 7, 9 };
            double beta0, beta1, sumx, sumy, xbar, ybar, lxy, lxx;
            sumx = 0;
            sumy = 0;
            lxx = 0;
            lxy = 0;
            for (int i = 0; i <= 4; i++)
            {
                sumx += x[i];
            }
            xbar = sumx / x.Length;
            for (int a = 0; a <= 4; a++) 
            {
                lxx = lxx + Math.Pow((x[a] - xbar), 2);
            }
            for (int i = 0; i <= 4; i++)
            {
                sumy += y[i];
            }
            ybar = sumy / y.Length;
            for (int i = 0; i <= 4;i++ )
            {
                lxy = lxy + (x[i] - xbar) * (y[i] - ybar);
            }
            beta1 = lxy / lxx;
            beta0 = ybar - beta1 * xbar;
            Console.WriteLine("常数项为{0}",beta0);
            Console.WriteLine("x的系数为{0}",beta1);
            Console.ReadKey();

        }
    }
}
