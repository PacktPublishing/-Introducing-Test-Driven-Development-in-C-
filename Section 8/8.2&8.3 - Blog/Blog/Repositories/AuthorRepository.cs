using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Cryptography;
using Blog.Core;
using Blog.Domain;
using Blog.Repositories.Abstract;
using System.Linq;
using System.Linq.Expressions;

namespace Blog.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(BlogContext context) : base(context)
        {
        }

        public IEnumerable<Author> GetActiveAuthors()
        {
            return Context.Authors.Where(x => x.Active);
        }

        public new BlogContext Context
        {
            get { return base.Context as BlogContext; }
        }
    }
}
