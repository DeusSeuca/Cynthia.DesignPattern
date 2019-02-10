using System;

namespace Strategy
{
    //慢速飞行类, 实现飞行接口
    public class SlowFly : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("缓慢的飞行~~");
        }
    }
}