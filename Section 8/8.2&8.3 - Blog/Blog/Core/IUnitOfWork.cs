using System;
using Blog.Repositories.Abstract;

namespace Blog.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository Authors { get; }
        IArticleRepository Articles { get; }
        int Save();
    }
}
