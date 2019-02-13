using System;

namespace Decorator
{
    //一棵圣诞树,继承树
    public class ChristmasTree : ITree//变化
    {
        public void Show()
        {
            Console.WriteLine("这是一颗圣诞树~");
        }
    }
}