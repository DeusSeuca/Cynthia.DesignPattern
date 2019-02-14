namespace FactoryMethod
{
    public class Run2Factory : IRunableFactory
    {
        public IRunable GetRunable() => new Run2();
    }
}