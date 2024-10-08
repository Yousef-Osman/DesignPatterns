﻿using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Proxy;

namespace DesignPatterns;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start.......");
        Console.WriteLine("");

        //ProxyClient.Test();
        //DecoratorClient.Test();
        SingletonClient.Test();

        Console.WriteLine("");
        Console.WriteLine("End.......");
    }
}
