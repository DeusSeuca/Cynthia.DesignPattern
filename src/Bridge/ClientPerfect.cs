using System;

namespace Bridge
{
    //豪华版客户端,继承客户端类
    public class ClientPerfect : Client
    {
        public ClientPerfect(IClientImp clientImp) : base(clientImp)
        {
        }

        public override void Login()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("欢迎您来到豪华版客户端~请登录:.....");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("正在登陆中...请稍等片刻....");

            //逻辑层不用关心具体的系统实现
            _clientImp.MessageBox("登陆成功");
        }
    }
}