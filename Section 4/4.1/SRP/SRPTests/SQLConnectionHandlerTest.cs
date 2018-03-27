using System;
using SRP;
using System.Configuration;
using Xunit;

namespace SRPTests
{
    public class SqlConnectionHandlerTest
    {
        [Fact]
        public void Consturction_ConnectionStringPassed_ConnectionCreated()
        {
            var sqlConnectionHandler = new SqlConnectionHandler(ConfigurationManager.AppSettings["connectionString"]);

            Assert.NotNull(sqlConnectionHandler.SqlConnection);
        }

        [Fact]
        public void Consturction_EmptyStringPassed_ConnectionWasNotCreated()
        {
            Assert.Throws<ArgumentException>(() => new SqlConnectionHandler(""));
        }

        [Fact]
        public void Consturction_WrongStringPassed_ConnectionWasNotCreated()
        {
            Assert.Throws<ArgumentException>(() => new SqlConnectionHandler("dfdf"));
        }
    }
}