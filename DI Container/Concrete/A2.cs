using DI_Container.Interface;
using DI_Container.ObjectExtensions;

namespace DI_Container.Concrete
{
    public class A2 : IA2
    {
        public void MethodA2()
        {
            this.MyCW();
        }
    }
}