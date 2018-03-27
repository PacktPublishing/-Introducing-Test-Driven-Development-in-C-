using Blog.Core;
using Moq;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Xunit;

namespace BlogTests
{
    public class RepostioryTest
    {
        [Fact]
        public void Add_TestClassObjectPassed_ProperMethodCalled()
        {
            var testObject = new TestClass();

            var context = new Mock<DbContext>();
            var dbSetMock = new Mock<DbSet<TestClass>>();

            context.Setup(x => x.Set<TestClass>()).Returns(dbSetMock.Object);
            dbSetMock.Setup(x => x.Add(It.IsAny<TestClass>())).Returns(testObject);

            var repository = new Repository<TestClass>(context.Object);

            repository.Add(testObject);

            context.Verify(x => x.Set<TestClass>());
            dbSetMock.Verify(x => x.Add(It.Is<TestClass>(y => y == testObject)));
        }

        [Fact]
        public void Remove_TestClassObjectPassed_ProperMethodCalled()
        {
            var testObject = new TestClass();

            var context = new Mock<DbContext>();
            var dbSetMock = new Mock<DbSet<TestClass>>();

            context.Setup(x => x.Set<TestClass>()).Returns(dbSetMock.Object);
            dbSetMock.Setup(x => x.Remove(It.IsAny<TestClass>())).Returns(testObject);

            var repository = new Repository<TestClass>(context.Object);

            repository.Remove(testObject);

            context.Verify(x => x.Set<TestClass>());
            dbSetMock.Verify(x => x.Remove(It.Is<TestClass>(y => y == testObject)));
        }

        [Fact]
        public void Get_TestClassObjectPassed_ProperMethodCalled()
        {
            var testObject = new TestClass();

            var context = new Mock<DbContext>();
            var dbSetMock = new Mock<DbSet<TestClass>>();

            context.Setup(x => x.Set<TestClass>()).Returns(dbSetMock.Object);
            dbSetMock.Setup(x => x.Find(It.IsAny<int>())).Returns(testObject);

            var repository = new Repository<TestClass>(context.Object);

            repository.Get(1);

            context.Verify(x => x.Set<TestClass>());
            dbSetMock.Verify(x => x.Find(It.IsAny<int>()));
        }

        [Fact]
        public void GetAll_TestClassObjectPassed_ProperMethodCalled()
        {
            var testObject = new TestClass() { Id = 1 };
            var testList = new List<TestClass>() { testObject };

            var dbSetMock = new Mock<DbSet<TestClass>>();
            dbSetMock.As<IQueryable<TestClass>>().Setup(x => x.Provider).Returns(testList.AsQueryable().Provider);
            dbSetMock.As<IQueryable<TestClass>>().Setup(x => x.Expression).Returns(testList.AsQueryable().Expression);
            dbSetMock.As<IQueryable<TestClass>>().Setup(x => x.ElementType).Returns(testList.AsQueryable().ElementType);
            dbSetMock.As<IQueryable<TestClass>>().Setup(x => x.GetEnumerator()).Returns(testList.AsQueryable().GetEnumerator());

            var context = new Mock<DbContext>();
            context.Setup(x => x.Set<TestClass>()).Returns(dbSetMock.Object);

            var repository = new Repository<TestClass>(context.Object);

            var result = repository.GetAll();

            Assert.Equal(testList, result.ToList());
        }

        [Fact]
        public void Find_TestClassObjectPassed_ProperMethodCalled()
        {
            var testObject = new TestClass(){Id = 1};
            var testList = new List<TestClass>() {testObject};

            var dbSetMock = new Mock<DbSet<TestClass>>();
            dbSetMock.As<IQueryable<TestClass>>().Setup(x => x.Provider).Returns(testList.AsQueryable().Provider);
            dbSetMock.As<IQueryable<TestClass>>().Setup(x => x.Expression).Returns(testList.AsQueryable().Expression);
            dbSetMock.As<IQueryable<TestClass>>().Setup(x => x.ElementType).Returns(testList.AsQueryable().ElementType);
            dbSetMock.As<IQueryable<TestClass>>().Setup(x => x.GetEnumerator()).Returns(testList.AsQueryable().GetEnumerator());

            var context = new Mock<DbContext>();
            context.Setup(x => x.Set<TestClass>()).Returns(dbSetMock.Object);
            
            var repository = new Repository<TestClass>(context.Object);

            var result = repository.Find(x => x.Id == 1);

            Assert.Equal(testList, result.ToList());
        }
    }
}
