using System;

namespace AbstractFactory
{
    //windos下Sound实现
    public class WindowsSound : ISound
    {
        public void Sound()
        {
            Console.WriteLine("发出了windows的声音");
        }
    }
}