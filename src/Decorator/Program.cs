using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //设计模式: 装饰模式
            //*通过组合而非继承的手法, 装饰模式实现了在运行时动态扩展对象功能的能力
            //*可以根据需要扩展多个能力,避免了使用继承带来的'灵活性差'和'多子类衍生'问题
            //*装饰模式应用要掉在于解决'主体类在多个方向上的扩展功能',是为'修饰'的含义
            //☆一般'继承一个接口,内部又封装有该接口的字段'(is-a+has-a)为装饰模式的一个特征(不绝对)

            //建立一个被修饰的对象, 圣诞树
            ITree tree = new ChristmasTree();

            //建立修饰者'给树加星星', 将要修饰的树传递进去
            ITree scTree = new StarTree(tree);

            //展示修饰后的树
            scTree.Show();

            //换行分割下输出结果
            Console.WriteLine();

            //给挂上星星的树再次挂上星星
            ITree sscTree = new StarTree(scTree);

            //展示挂了两次星星的树
            sscTree.Show();

            Console.ReadLine();
        }
    }
}
