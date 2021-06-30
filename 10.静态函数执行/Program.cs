using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.静态函数执行
{
    class Program
    {
        static void Main(string[] args)
        {
            //静态构造函数只执行一次
            Test test = new Test();
            Console.WriteLine(Test.count);
            Test test1 = new Test();
            Console.WriteLine(Test.count);
            Console.ReadKey();
        }
    }

    class Test
    {
        public static int count = 0;

        static Test()
        {
            Console.WriteLine($"静态构造函数执行，count={count}");
            count++;
        }
    }


}
