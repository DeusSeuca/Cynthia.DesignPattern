using System;

namespace Bridge
{
    //轻量版客户端,继承客户端类
    public class ClientLite : Client
    {
        public ClientLite(IClientImp clientImp) : base(clientImp)
        {
        }

        public override void Login()
        {
            Console.WriteLine("这是轻量版客户端,请登录:.....");

            //逻辑层不用关心具体的系统实现
            _clientImp.MessageBox("登陆成功");
        }
    }
}