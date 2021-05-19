using DI_Container.Interface;
using DI_Container.ObjectExtensions;

namespace DI_Container.Concrete
{
    public class B2 : IB2
    {
        public void MethodB2()
        {
            this.MyCW();
        }
    }
}