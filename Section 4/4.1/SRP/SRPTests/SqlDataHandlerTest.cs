using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using Moq;
using SRP;
using Xunit;

namespace SRPTests
{
    public class SqlDataHandlerTest
    {
        [Fact]
        public void ReadData_NoConditions_ReadEntity()
        {
            var sqlConnectionMock = new Mock<ISqlConnectionWrapper>();
            var selectCommandFactoryMock = new Mock<ICommandFactory>();
            var selectCommandMock = new Mock<IDbCommand>();
            var readerMock = new Mock<IDataReader>();

            selectCommandMock.Setup(x => x.ExecuteReader()).Returns(readerMock.Object);
            readerMock.SetupSequence(x => x.Read())
                .Returns(true)
                .Returns(false);
            readerMock.SetupSequence(x => x.GetInt32(It.IsAny<int>()))
                .Returns(11)
                .Returns(1);
            selectCommandFactoryMock.Setup(x => x.RetriveSelectEntityCommand(It.IsAny<SqlConnection>()))
                .Returns(selectCommandMock.Object);

            var dataHandler = new SqlDataHandler(selectCommandFactoryMock.Object, sqlConnectionMock.Object);
            var entities = dataHandler.ReadEntities();

            Assert.Single(entities.ToList());
            Assert.Equal(11, entities.ToList().Single().Value);
            Assert.Equal(EntityType.Type1, entities.ToList().Single().Type);
        }


        [Fact]
        public void UpdateData_NoConditions_ProperFunctionsCalled()
        {
            var sqlConnectionMock = new Mock<ISqlConnectionWrapper>();
            var updateCommandFactoryMock = new Mock<ICommandFactory>();
            var updateCommandMock = new Mock<IDbCommand>();

            var entity = new Entity()
            {
                Type = EntityType.Type0,
                Value = 11
            };

            updateCommandFactoryMock.Setup(x => x.RetriveUpdateEntityCommand(It.IsAny<SqlConnection>(), It.IsAny<Entity>(), It.IsAny<int>()))
                .Returns(updateCommandMock.Object);

            var dataHandler = new SqlDataHandler(updateCommandFactoryMock.Object, sqlConnectionMock.Object);
            dataHandler.UpdateDataFieldInEntity(entity);

            updateCommandMock.Verify(x => x.ExecuteNonQuery());
        }
    }
}
