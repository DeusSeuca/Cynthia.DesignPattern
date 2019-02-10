using System;

namespace Strategy
{
    //策略的抽象类,鸭子
    public abstract class Duck
    {
        //将会改变的行为,提取为接口
        protected IQuackable _quack;
        protected IFlyable _fly;

        //调用行为
        public void Fly() => _fly.Fly();
        public void Quack() => _quack.Quack();

        //可更改行为
        public void SetFlyBehavoir(IFlyable fly)=>_fly=fly;
        public void SetQuackBehavoir(IQuackable quack)=>_quack=quack;


        //将永远不变的行为,直接实现 (这里假定swim永远不变)
        public void Swim() => Console.WriteLine("鸭子游泳~");

    }
}