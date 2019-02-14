using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //设计模式: 桥模式
            //动机:由于某些类型的固有逻辑,使得它们具有多维度的变化
            //优点:将抽象部分(业务功能)与实现部分(平台实现)分离,使他们可以独立的产生变化

            //windows下的平台实现
            IClientImp wClient = new WindowsClient();

            //windows下豪华版客户端
            Client wpClient = new ClientPerfect(wClient);

            wpClient.Login();

            Console.ReadLine();
        }
    }
}
