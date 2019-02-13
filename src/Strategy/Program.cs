using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //设计模式: 策略模式
            //思想: 定义一系列算法,把他们一个个封装起来,并且使他们可以互相替换(变化)
            //优点: 该模式可以使算法独立于使用它的客户端程序(稳定)而变化(扩展,子类化)

            //当看到if else,并且if else会改变(扩展)的时候, 通常需要用到策略模式

            //一只普通的鸭子和一只超级鸭子        
            Duck nDuck = new NormalDuck();
            Duck sDuck = new SuperDuck();

            Console.Write($"普通鸭子叫:");
            nDuck.Quack();
            Console.Write($"普通鸭子飞:");
            nDuck.Fly();
            Console.WriteLine();
            Console.Write($"超级鸭子叫:");
            sDuck.Quack();
            Console.Write($"超级鸭子飞:");
            sDuck.Fly();

            Console.ReadLine();
        }
    }
}
