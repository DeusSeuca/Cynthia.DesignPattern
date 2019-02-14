using System;

namespace AbstractFactory
{
    //windows下UI实现
    public class WindowsUI : IUI
    {
        public void Message()
        {
            Console.WriteLine("跳出了windows的弹窗");
        }
    }
}