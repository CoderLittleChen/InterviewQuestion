using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.静态变量和静态构造函数的执行顺序
{
    class Program
    {
        static void Main(string[] args)
        {
            //静态变量初始化  
            //静态构造函数
            //普通变量初始化
            //普通构造函数


            TestClass testClass = new TestClass();
            testClass.Print();
            Console.ReadKey();
        }
    }

    public class TestClass
    {
        public int NoStaticValue = TestValue + 1;

        public static int TestValue { get; set; }
        public TestClass()
        {
            Console.WriteLine("普通构造函数");
            if (TestValue == 0)
            {
                TestValue = 5;
            }
        }

        static TestClass()
        {
            Console.WriteLine("静态构造函数");
            if (TestValue == 0)
            {
                TestValue = 10;
            }
        }

        public void Print()
        {
            if (TestValue == 5)
            {
                TestValue = 6;
            }
            Console.WriteLine($"TestValue:{TestValue}");
            Console.WriteLine($"NoStaticValue:{NoStaticValue}");
        }


    }

}
