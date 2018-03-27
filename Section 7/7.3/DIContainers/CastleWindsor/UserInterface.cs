using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace CastleWindsor
{
    public class UserInterface
    {
        public void ButtonClicked()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<Client>());
            container.Register(Component.For<IService1>()
                .ImplementedBy<Service1>());
            container.Register(Component.For<IService2>()
                .ImplementedBy<Service2>().LifestyleSingleton());

            var client = container.Resolve<Client>();
            client.InitiateServiceMethods();

            container.Release(client);
        }
    }
}
