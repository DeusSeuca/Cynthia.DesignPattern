namespace AbstractFactory
{
    //抽象工厂,创建一系列相关的对象
    public interface ISystemFactory
    {
        ISound CreateSound();
        IUI CreateUI();
    }
}