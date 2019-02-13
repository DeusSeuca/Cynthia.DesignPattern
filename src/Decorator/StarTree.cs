using System;

namespace Decorator
{
    //星星修饰类, 将树上挂上星星
    public class StarTree : TreeDecorator
    {
        public StarTree(ITree tree) : base(tree)
        {
        }

        public override void Show()
        {
            _tree.Show();
            Console.WriteLine("这颗树上挂满了星星~");
        }
    }
}