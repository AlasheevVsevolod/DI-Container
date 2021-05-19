using System;
using DI_Container.Concrete;
using DI_Container.Interface;

namespace DI_Container
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DIContainer.Register<IA1, A1>();
            DIContainer.Register<IA2, A2>();
            DIContainer.Register<IB1, B1>();
            DIContainer.Register<IB2, B2>();
            DIContainer.Register<TestClass, TestClass>();

            var instance = DIContainer.GetInstance<TestClass>();
            instance.Test();

            Console.ReadLine();
        }
    }
}