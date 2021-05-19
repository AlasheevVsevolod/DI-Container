using DI_Container.Interface;
using DI_Container.ObjectExtensions;

namespace DI_Container.Concrete
{
    public class B1 : IB1
    {
        private readonly IB2 _b2Instance;

        public B1(IB2 b2Instance)
        {
            _b2Instance = b2Instance;
        }

        public void MethodB1()
        {
            this.MyCW();
            _b2Instance.MethodB2();
        }
    }
}