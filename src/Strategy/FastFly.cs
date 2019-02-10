using System;

namespace Strategy
{
    //快速飞行类, 实现飞行接口
    public class FastFly : IFlyable
    {
        //实现功能
        public void Fly() => Console.WriteLine("快速飞行中~");
    }
}