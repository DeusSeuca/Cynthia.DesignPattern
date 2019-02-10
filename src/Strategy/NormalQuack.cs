using System;

namespace Strategy
{
    public class NormalQuack : IQuackable
    {
        //正常叫声类, 实现叫声接口
        public void Quack() => Console.WriteLine("嘎嘎,嘎嘎~");
    }
}