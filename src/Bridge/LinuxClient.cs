using System;

namespace Bridge
{
    //Linux系统下的功能实现
    public class LinuxClient : IClientImp
    {
        public void MessageBox(string msg)
        {
            Console.WriteLine("\n++你的Linux系统跳出了一个弹窗++");
            Console.WriteLine($"++{msg}++\n");
        }
    }
}