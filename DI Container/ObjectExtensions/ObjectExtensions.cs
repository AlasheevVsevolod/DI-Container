using System;

namespace DI_Container.ObjectExtensions
{
    public static class ObjectExtensions
    {
        public static void MyCW(this object instance)
        {
            Console.WriteLine($"Method called from class {instance.GetType()}");
        }
    }
}