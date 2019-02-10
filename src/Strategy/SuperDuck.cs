namespace Strategy
{
    //超级鸭子
    //特征是: 飞得快, 叫声奇怪
    public class SuperDuck:Duck
    {
        public SuperDuck()
        {
            _fly = new FastFly();//快速飞行
            _quack = new StrangeQuack();//奇怪叫声
        }
    }
}