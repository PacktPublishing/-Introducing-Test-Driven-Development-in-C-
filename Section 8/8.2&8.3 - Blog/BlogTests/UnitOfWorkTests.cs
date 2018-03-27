using Blog;
using Blog.Repositories.Abstract;
using Moq;
using Xunit;

namespace BlogTests
{
    public class UnitOfWorkTests
    {
        [Fact]
        public void Construction_RepositoriesPassed_RepositoriesSet()
        {
            var context = new Mock<BlogContext>();
            context.Setup(x => x.SaveChanges()).Returns(1);

            var unitOfWork = new UnitOfWork(context.Object);
            unitOfWork.Save();

            context.Verify(x => x.SaveChanges());
        }
    }
}
