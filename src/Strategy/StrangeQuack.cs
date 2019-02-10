using System;

namespace Strategy
{
    //奇怪叫声类, 实现叫声接口
    public class StrangeQuack : IQuackable
    {
        public void Quack() => Console.WriteLine("**难以形容的奇怪的叫声**");
    }
}