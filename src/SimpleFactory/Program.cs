﻿using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();
            IFruit fruit = FruitFactory.CreateFruit("");
        }
    }
}
