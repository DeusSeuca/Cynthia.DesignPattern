namespace FactoryMethod
{
    public class Run1Factory : IRunableFactory
    {
        public IRunable GetRunable() => new Run2();
    }
}