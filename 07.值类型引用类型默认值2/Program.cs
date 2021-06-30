using System;

namespace _07.值类型引用类型默认值2
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

        static float? floatNum;

        static void Main(string[] args)
        {
            //首先通过创建.Net5程序启用C# 9.0  
            //C# 9.0 允许 int? 类型的变量直接判断是否为Null
            //值类型后面加?表示允许为null    int后面加？等同与Nullable<int> 
            //其中特殊的一点是 DateTime？之后可以直接判断是否为null
            time = null;
            Nullable<DateTime> time2;
            num = null;
            Nullable<int> num2 = 10;


            //值类型默认为null
            Console.WriteLine(location == null ? "location is null" : location);
            Console.WriteLine(time == null ? "time is null" : time.ToString());
            Console.WriteLine(num == null ? "num is null" : num);
            Console.WriteLine(time1 == null ? "time1 is null" : time1.ToString());
            Console.ReadKey();
        }
    }
}
