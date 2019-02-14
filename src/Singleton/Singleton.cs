using System;

namespace Singleton
{
    //单例模式类
    public class Singleton
    {
        //需要将构造函数设定为私有,因为无法直接创建
        private Singleton(){}
        
        //存储唯一的单例,volatile关键字用于双检查锁
        private static volatile Singleton _instance;
        private static object objlock = new object();

        //获得实例,如果已经有,返回 如果没有,创建
        public static Singleton GetInstance()
        {
            //双检查锁来确保线程安全
            if(_instance==null)
            {
                lock (objlock)
                {
                    if(_instance==null)
                    {
                        _instance = new Singleton();
                        Console.WriteLine("创建了一个新实例~");
                    }
                }
            }
            Console.WriteLine("返回现有实例~");
            return _instance;
        }
    }
}