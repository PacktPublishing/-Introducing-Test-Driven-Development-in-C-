using Moq;
using Xunit;

namespace ClientServiceExample
{
    public class ClientTest
    {
        [Fact]
        public void InitiateServiceMethod_NoConditions_ProperMethodsCalled()
        {
            var serviceMock = new Mock<IService>();

            var client = new Client();

            client.InitiateServiceMethod(serviceMock.Object);

            serviceMock.Verify(x => x.ServiceMethod());    
        }
    }
}
