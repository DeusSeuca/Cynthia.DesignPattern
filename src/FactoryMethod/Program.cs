using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //设计模式: 工厂方法模式
            //定义一个用于创建对象的接口,让子类决定实例化那个对象
            //工厂方法模式使得一个类的实例化延迟(目的 解耦,手段 接口抽象)到实现类

            //目前对该模式理解不够深入,事后可能会添加注释或重写代码

            //传入一个具体工厂
            var t = new Test(new Run1Factory());

            //运行
            t.Go();

            Console.ReadLine();
        }
    }
}
