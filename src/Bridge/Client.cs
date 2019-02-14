namespace Bridge
{
    //客户端抽象类
    public abstract class Client
    {
        protected IClientImp _clientImp;
        protected Client(IClientImp clientImp)=>_clientImp=clientImp;
        public abstract void Login();
    }
}