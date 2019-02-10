using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //设计模式: 策略模式
            //思想: 当一个类有特定种行为,并且每种行为有不同模式的时候,可以将行为作为一个接口提出
            //优点: 可以组合不同的行为,避免需要定义'相同行为不同组合'的类型时,需要重新写相同的代码(行为)

            //本例中没有定义拥有相同行为的类型,但可轻松实现这一点

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
