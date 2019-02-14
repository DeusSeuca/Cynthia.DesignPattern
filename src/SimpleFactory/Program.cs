using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //设计模式: 简单工厂
            //功能:根据提供字符串不同,得到某一个接口的特定实例,并进行一些自动化处理
            //*这个模式不属于GoF23中的设计模式
            IFruit fruit = FruitFactory.CreateFruit("Apple");
            IFruit fruit2 = FruitFactory.CreateFruit("Banana");

            Console.WriteLine($"fruit的信息是:{fruit.Info()}");
            Console.WriteLine($"fruit2的信息是:{fruit2.Info()}");

            Console.ReadLine();
        }
    }
}
