using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Blog;
using Blog.Core;
using Blog.Domain;
using Blog.Repositories;
using Moq;
using Xunit;

namespace BlogTests
{
    public class ArticleRepositoryTests
    {
        [Fact]
        public void GetTopTenViewedArticles_NoConditions_ProperValuesReturned()
        {
            var testObject1 = new Article() { Id = 1, Views = 111};
            var testObject2 = new Article() { Id = 2, Views = 222 };
            var testObject3 = new Article() { Id = 3, Views = 333 };
            var testObject4 = new Article() { Id = 4, Views = 444 };
            var testObject5 = new Article() { Id = 5, Views = 555 };
            var testObject6 = new Article() { Id = 6, Views = 666 };
            var testObject7 = new Article() { Id = 7, Views = 777 };
            var testObject8 = new Article() { Id = 8, Views = 888 };
            var testObject9 = new Article() { Id = 9, Views = 999 };
            var testObject10 = new Article() { Id = 10, Views = 1111 };
            var testObject11 = new Article() { Id = 11, Views = 11111 };

            var testList = new List<Article>()
            {
                testObject1,
                testObject2,
                testObject3,
                testObject4,
                testObject5,
                testObject6,
                testObject7,
                testObject8,
                testObject9,
                testObject10,
                testObject11
            };

            var dbSetMock = new Mock<DbSet<Article>>();
            dbSetMock.As<IQueryable<Article>>().Setup(x => x.Provider).Returns(testList.AsQueryable().Provider);
            dbSetMock.As<IQueryable<Article>>().Setup(x => x.Expression).Returns(testList.AsQueryable().Expression);
            dbSetMock.As<IQueryable<Article>>().Setup(x => x.ElementType).Returns(testList.AsQueryable().ElementType);
            dbSetMock.As<IQueryable<Article>>().Setup(x => x.GetEnumerator()).Returns(testList.AsQueryable().GetEnumerator());

            var context = new Mock<BlogContext>();
            context.Setup(x => x.Set<Article>()).Returns(dbSetMock.Object);
            context.Setup(x => x.Articles).Returns(dbSetMock.Object);
            
            var repository = new ArticleRepository(context.Object);

            var result = repository.GetTopTenViewedArticles();

            Assert.Equal(10, result.ToList().Count);
            Assert.Equal(testObject11, result.ToList().First());
            Assert.DoesNotContain(testObject1, result.ToList());
        }
    }
}
