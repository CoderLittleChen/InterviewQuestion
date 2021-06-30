using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.类继承与方法重写
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            a.Foo();
            b.Foo();
            c.Foo();


            //当用父类去接收子类对象的时候  如果子类未重写  那么和直接接收父类对象是一样的
            //比如 B b = new B();  B b = new D();    这个时候 结果是一样的
            //但是如果D类重写了B类的方法 
            //B b = new B() 这个时候输出的是B的方法、
            //B b = new D() 这个时候输出的是D的方法  应该在D中重写了B的方法


            a = new B();
            a.Foo();
            b = new C();
            b.Foo();
            b = new D();
            b.Foo();


            Console.ReadKey();

        }
    }

    public class A
    {
        public void Foo()
        {
            Console.WriteLine("A::Foo");
        }
    }


    public class B:A
    {
        //这里不加new 
        public virtual void Foo()
        {
            Console.WriteLine("B::Foo");
        }
    }

    public class C:B
    {
        public void Foo()
        {
            Console.WriteLine("C::Foo");
        }
    }

    public class D:B
    {
        public override void Foo()
        {
            Console.WriteLine("D::Foo");
        }
    }




}
