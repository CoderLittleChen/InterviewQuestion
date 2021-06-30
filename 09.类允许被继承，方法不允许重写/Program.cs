using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.类允许被继承_方法不允许重写
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public abstract class Car
    {
        public static void Run()
        {
            Console.WriteLine("Car is Running");
        }

        public abstract void Didi();
    }

    public class Tesla : Car
    {
        public override void Didi()
        {
            
        }
    }

    public interface IRepository


}
