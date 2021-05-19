using DI_Container.Interface;
using DI_Container.ObjectExtensions;

namespace DI_Container.Concrete
{
    public class A1 : IA1
    {
        private readonly IA2 _a2Instance;

        public A1(IA2 a2Instance)
        {
            _a2Instance = a2Instance;
        }

        public void MethodA1()
        {
            this.MyCW();
            _a2Instance.MethodA2();
        }
    }
}