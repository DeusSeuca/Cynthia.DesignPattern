namespace FactoryMethod
{
    public class Test
    {
        private IRunableFactory _factory;
        public Test(IRunableFactory factory)=>_factory=factory;
        public void Go()
        {
            IRunable r = _factory.GetRunable();
            r.Run();
        }
    }
}