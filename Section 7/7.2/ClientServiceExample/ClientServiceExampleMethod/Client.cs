namespace ClientServiceExample
{
    public class Client
    {
        public void InitiateServiceMethod(IService service)
        {
            service.ServiceMethod();
        }
    }
}
