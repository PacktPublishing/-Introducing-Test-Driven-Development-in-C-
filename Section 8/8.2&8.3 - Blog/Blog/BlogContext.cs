using System.Data.Entity;
using Blog.Domain;

namespace Blog
{
    public class BlogContext : DbContext
    {
        public BlogContext()
            : base("name=BlogContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
    }
}
