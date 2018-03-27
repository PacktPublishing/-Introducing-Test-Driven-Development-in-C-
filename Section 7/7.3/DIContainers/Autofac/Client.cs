namespace Autofac
{
    public class Client
    {
        private readonly IService1 _service1;
        private readonly IService2 _service2;

        public Client(IService1 service, IService2 service2)
        {
            _service1 = service;
            _service2 = service2;
        }

        public void InitiateServiceMethods()
        {
            _service1.Service1Method();
            _service2.Service2Method();
        }
    }
}
