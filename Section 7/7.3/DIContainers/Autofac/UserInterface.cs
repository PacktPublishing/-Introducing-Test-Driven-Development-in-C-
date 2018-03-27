namespace Autofac
{
    public class UserInterface
    {
        public void ButtonClicked()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Client>();
            builder.RegisterInstance(new Service1())
                .As<IService1>();
            builder.RegisterInstance(new Service2())
                .As<IService2>().SingleInstance();

            var container = builder.Build();
            var client = container.Resolve<Client>();

            client.InitiateServiceMethods();
        }
    }
}
