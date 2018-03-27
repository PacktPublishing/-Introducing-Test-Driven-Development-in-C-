using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Blog;
using Blog.Domain;
using Blog.Repositories;
using Moq;
using Xunit;

namespace BlogTests
{
    public class AuthorRepositoryTest
    {
        [Fact]
        public void GetActiveAuthors_NoConditions_ProperValuesReturned()
        {
            var testObject1 = new Author(){Id = 1, Active = true};
            var testObject2 = new Author() { Id = 2, Active = false };
            var testObject3 = new Author() { Id = 3, Active = true };

            var testList = new List<Author> {testObject1, testObject2, testObject3};

            var dbSetMock = new Mock<DbSet<Author>>();
            dbSetMock.As<IQueryable<Author>>().Setup(x => x.Provider).Returns(testList.AsQueryable().Provider);
            dbSetMock.As<IQueryable<Author>>().Setup(x => x.Expression).Returns(testList.AsQueryable().Expression);
            dbSetMock.As<IQueryable<Author>>().Setup(x => x.ElementType).Returns(testList.AsQueryable().ElementType);
            dbSetMock.As<IQueryable<Author>>().Setup(x => x.GetEnumerator()).Returns(testList.AsQueryable().GetEnumerator());

            var context = new Mock<BlogContext>();
            context.Setup(x => x.Set<Author>()).Returns(dbSetMock.Object);
            context.Setup(x => x.Authors).Returns(dbSetMock.Object);

            var repository = new AuthorRepository(context.Object);

            var result = repository.GetActiveAuthors();

            Assert.Equal(2, result.ToList().Count);
            Assert.DoesNotContain(testObject2, result.ToList());
        }

    }
}
