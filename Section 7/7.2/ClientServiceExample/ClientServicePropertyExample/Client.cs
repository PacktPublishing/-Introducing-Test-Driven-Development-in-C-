namespace ClientServicePropertyExample
{
    public class Client
    {
        public IService Service { get; set; }

        public Client()
        {
            Service = new Service1();
        }

        public void InitiateServiceMethod()
        {
            Service.ServiceMethod();
        }
    }
}
