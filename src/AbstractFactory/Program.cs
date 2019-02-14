using System;
using System.Linq;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //设计模式: 抽象工厂模式
            //提供一个接口,让该接口负责创建一系列"相关或者互相依赖的对象",无需指定他们的具体类

            //windows系列组件的工厂
            ISystemFactory windowsFactory = new WindowsFactory();

            //获取的ui和sound对象,都是windows系列的
            IUI ui = windowsFactory.CreateUI();
            ISound sound = windowsFactory.CreateSound();

            //调用方法
            ui.Message();
            sound.Sound();

            Console.ReadLine();
        }
    }
}
