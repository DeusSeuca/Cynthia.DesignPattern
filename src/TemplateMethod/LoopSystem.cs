using System;

namespace TemplateMethod
{
    //模板类
    public abstract class LoopSystem
    {
        //不变的主流程
        public void Run()
        {
            SystemStart();
            while(SystemInfo());
            SystemEnd();
        }

        //不变的模块: 系统开始
        private void SystemStart()
        {
            Console.WriteLine("*****欢迎来到本系统*****\n");
        }

        //不变的模块: 系统结束
        private void SystemEnd()
        {   //不变的模块
            Console.WriteLine("**系统已退出,欢迎下次访问**\n");
        }

        //变化的模块,单独提出由子类实现
        protected abstract bool SystemInfo();
    }
}