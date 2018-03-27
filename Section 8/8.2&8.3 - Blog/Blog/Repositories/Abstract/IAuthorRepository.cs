using System.Collections.Generic;
using Blog.Core;
using Blog.Domain;

namespace Blog.Repositories.Abstract
{
    public interface IAuthorRepository : IReporitory<Author>
    {
        IEnumerable<Author> GetActiveAuthors();
    }
}
