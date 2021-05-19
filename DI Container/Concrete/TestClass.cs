using DI_Container.Interface;

namespace DI_Container.Concrete
{
    public class TestClass
    {
        private readonly IA1 _classA1;
        private readonly IB1 _classB1;

        public TestClass(IA1 classA1, IB1 classB1)
        {
            _classA1 = classA1;
            _classB1 = classB1;
        }

        public void Test()
        {
            _classA1.MethodA1();
            _classB1.MethodB1();
        }
    }
}