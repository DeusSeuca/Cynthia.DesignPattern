using System;

namespace TemplateMethod
{
    public class ShowSystem : LoopSystem
    {
        protected override bool SystemInfo()
        {
            Console.WriteLine("这里是购物系统~,没有具体内容呦");
            Console.WriteLine("请问是否继续~(按y继续)");
            return Console.ReadLine()=="y";
        }
    }
}