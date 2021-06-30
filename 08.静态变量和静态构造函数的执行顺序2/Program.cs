using System;

namespace _08.静态变量和静态构造函数的执行顺序2
{
    class Program
    {
        static void Main(string[] args)
        {
            //B b = new B();
            //执行顺序
            //子类的静态变量
            //子类的静态构造函数
            //子类的变量初始化
            //父类的静态变量
            //父类的静态构造函数
            //父类的变量初始化
            //父类的构造函数
            //子类的构造函数   

            B b = new B();
            //Console.WriteLine(D.x);
            Console.ReadKey();
        }
    }

    class A
    {
        public static string staticBaseStr = "我是父类的静态变量_" + C.index++;
        public string commonBaseStr = "我是父类的普通变量_" + C.index++;

        static A()
        {
            Console.WriteLine("我是父类的静态构造函数_" + C.index++);
        }

        public A()
        {
            Console.WriteLine(staticBaseStr);
            Console.WriteLine(commonBaseStr);
            Console.WriteLine("我是父类的普通构造函数_" + C.index++);
        }
    }

    class B : A
    {
        public static string staticSubStr = "我是子类的静态变量_" + C.index++;

        public string commonSubStr = "我是子类的普通变量_" + C.index++;

        static B()
        {
            Console.WriteLine("我是子类的静态构造函数_" + C.index++);
        }

        public B()
        {
            Console.WriteLine(staticSubStr);
            Console.WriteLine(commonSubStr);
            Console.WriteLine("我是子类的普通构造函数_" + C.index++);
        }
    }

    class C
    {
        public static int index { get; set; }
    }

    class D
    {
        public static int x;
        static D()
        {
            x += 1;
        }
    }
}
