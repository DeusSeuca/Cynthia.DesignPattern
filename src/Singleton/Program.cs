using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //设计模式: 单例模式/单件模式
            //*保证一个类仅有一个实例,并提供该实例的全局访问点
            //*保证这点,应当是设计者 而非使用者的责任
            //重点:
            //1.设计上应当杜绝一切可能使该类产生多个实例的情况
            //2.注意使用双检查锁和volatile关键字保证线程安全

            //反复的尝试获取实例(在类型尝试创建和返回时输出内容)
            var s = Singleton.GetInstance();
            s = Singleton.GetInstance();
            s = Singleton.GetInstance();

            Console.ReadLine();
        }
    }
}
