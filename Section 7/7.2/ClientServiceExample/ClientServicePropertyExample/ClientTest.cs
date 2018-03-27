using Moq;
using Xunit;

namespace ClientServicePropertyExample
{
    public class ClientTest
    {
        [Fact]
        public void InitiateServiceMethod_NoConditions_ProperMethodsCalled()
        {
            var serviceMock = new Mock<IService>();

            var client = new Client
            {
                Service = serviceMock.Object
            };

            client.InitiateServiceMethod();

            serviceMock.Verify(x => x.ServiceMethod());    
        }
    }
}
