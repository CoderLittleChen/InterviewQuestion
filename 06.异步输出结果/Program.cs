using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.异步输出结果
{
    class Program
    {
        private static string result;

        //static async Task Main(string[] args)
        static void Main(string[] args)
        {
            //不加await 程序不会等待SaySomething中的代码执行完毕  而是会继续向下执行
            //所以输出为null
            SaySomething();
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static async Task<string> SaySomething()
        {
            await Task.Delay(1);
            result = "Hello World";
            return "Something";
        }


    }
}
