using Blog.Core;
using Blog.Repositories;
using Blog.Repositories.Abstract;

namespace Blog
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _context;

        public UnitOfWork(BlogContext context)
        {
            _context = context;
            Articles = new ArticleRepository(_context);
            Authors = new AuthorRepository(_context);
        }

        public IArticleRepository Articles { get; private set; }
        public IAuthorRepository Authors { get; private set; }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
