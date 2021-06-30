using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.判断是否为素数
{
    class Program
    {
        static void Main(string[] args)
        {
            int num =451;
            bool b = IsPrimeNum(num);
            Console.WriteLine(b);
            Console.ReadKey();
        }

        public static bool IsPrimeNum(int num)
        {
            if (num <= 0)
            {
                return false;
            }
            int temp = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    temp++;
                }
            }
            return temp > 0 ? false : true;
        }

    }
}
