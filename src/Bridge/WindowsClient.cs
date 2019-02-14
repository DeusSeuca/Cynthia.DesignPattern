using System;

namespace Bridge
{
    //windows系统下的功能实现
    public class WindowsClient : IClientImp
    {
        public void MessageBox(string msg)
        {
            Console.WriteLine("\n**你的Windows系统跳出了一个弹窗**");
            Console.WriteLine($"**{msg}**\n");
        }
    }
}