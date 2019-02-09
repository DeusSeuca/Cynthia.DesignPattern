namespace SimpleFactory
{
    //Fruit的工厂类
    public static class FruitFactory
    {
        public static IFruit CreateFruit(string fruitType)
        {
            var fruit = default(IFruit);
            if(fruitType=="Apple")
            {   //如果是Apple,创建Apple实例
                fruit = new Apple();
            }
            else if(fruitType=="Banana")
            {   //如果是Banana,创建Banana实例
                fruit = new Banana();
            }
            else
            {
                throw new System.Exception("Type Undefine(类型没有被定义)");
            }
            //这里可以写一些自动化处理
            return fruit;
        }
    }
}