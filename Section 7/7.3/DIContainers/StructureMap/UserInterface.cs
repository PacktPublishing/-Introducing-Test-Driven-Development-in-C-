

namespace StructureMap
{
    public class UserInterface
    {
        public void ButtonClicked()
        {
            var container = new StructureMap.Container(x =>
            {
                x.For<IService1>().Use<Service1>().Transient();
                x.For<IService2>().Use<Service2>().Singleton();
                x.For<Client>().Use<Client>();
            });

            var client = container.GetInstance<Client>();

            client.InitiateServiceMethods();

            container.Release(client);
        }
    }
}
