using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.值类型引用类型默认值
{
    class Program
    {
        //引用类型
        static string location;
        //引用类型
        static DateTime? time;
        static int? num;
        //值类型
        static DateTime time1;

        static int num1;

        static void Main(string[] args)
        {
            //值类型默认为null
            Console.WriteLine(location == null ? "location is null" : location);
            Console.WriteLine(time == null ? "time is null" : time.ToString());
            //Console.WriteLine(num == null ? "time is null" : num);
            Console.WriteLine(time1 == null ? "time1 is null" : time1.ToString());
            Console.ReadKey();
        }
    }
}
