using System.Collections.Generic;
using Blog.Core;
using Blog.Domain;

namespace Blog.Repositories.Abstract
{
    public interface IArticleRepository : IReporitory<Article>
    {
        IEnumerable<Article> GetTopTenViewedArticles();
    }
}
