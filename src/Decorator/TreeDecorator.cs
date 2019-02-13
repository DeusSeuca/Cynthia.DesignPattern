namespace Decorator
{
    //树的装饰者父类, 装饰者将继承自该类
    public abstract class TreeDecorator : ITree
    {
        protected ITree _tree;//需要对一个树进行装饰
        protected TreeDecorator(ITree tree)=>_tree=tree;//依赖一棵树(有树才能装饰)
        public abstract void Show();
    }
}