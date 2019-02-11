using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //设计模式: 模板方法
            //当一个操作中,流程骨架是不变, 而模块是变化时(相对)
            //可以将模块提出,让子类去实现具体行为
            
            //子类实现了父类中的某个模块,这个模块混入了父类的总体流程中,实现了先来者(父类)调用后来者(子类)
            LoopSystem shopSystem = new ShowSystem();
            
            //执行
            shopSystem.Run();

            Console.ReadLine();
        }
    }
}
