using Xunit;
using Moq;
using DIHelloWorld;

namespace DIHelloWorldTests
{
    public class ClientTest
    {
        [Fact]
        public void SayHello_NoConditions_ProperFunctionCalled()
        {
            var writterMock = new Mock<IWritter>();
            var client = new Client(writterMock.Object);
            client.SayHello();

            writterMock.Verify(x => x.WriteHelloWorld());
        }
    }
}
