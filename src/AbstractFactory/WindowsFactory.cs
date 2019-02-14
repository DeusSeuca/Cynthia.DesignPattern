namespace AbstractFactory
{
    //Windows工厂, 提供windows下的一些列组件
    public class WindowsFactory : ISystemFactory
    {
        public ISound CreateSound() => new WindowsSound();

        public IUI CreateUI() => new WindowsUI();
    }
}