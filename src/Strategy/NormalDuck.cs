namespace Strategy
{
    //一只普通的鸭子
    //特征是: 飞得慢, 叫的正常
    public class NormalDuck : Duck
    {
        public NormalDuck()
        {
            _fly = new SlowFly();//缓慢飞行
            _quack = new NormalQuack();//正常叫声
        }
    }
}