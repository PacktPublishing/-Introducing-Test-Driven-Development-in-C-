using System.Data.SqlClient;
using Moq;
using SRP;
using Xunit;

namespace SRPTests
{
    public class CommandFactoryTest
    {
        [Fact]
        public void RetriveSelectMethod_NoConditions_ReturnsValues()
        {
            var sqlConnectionMock = new Mock<ISqlConnectionWrapper>();
            var selectCommandFactory = new CommandFactory();

            var command = selectCommandFactory.RetriveSelectEntityCommand(sqlConnectionMock.Object.SqlConnection);

            Assert.Equal("select * from Entity", command.CommandText);
        }

        [Fact]
        public void RetriveUpdateMethod_NoConditions_ReturnsValues()
        {
            var sqlConnectionMock = new Mock<ISqlConnectionWrapper>();
            var selectCommandFactory = new CommandFactory();

            var entity = new Entity()
            {
                Type = EntityType.Type0,
                Value = 2
            };

            var command = selectCommandFactory.RetriveUpdateEntityCommand(sqlConnectionMock.Object.SqlConnection, entity, 11);

            Assert.Equal("update Entity set Data = 11 where Data = 2", command.CommandText);
        }
    }
}
