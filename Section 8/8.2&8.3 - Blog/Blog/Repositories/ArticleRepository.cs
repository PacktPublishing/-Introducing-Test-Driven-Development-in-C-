using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Blog.Core;
using Blog.Domain;
using Blog.Repositories.Abstract;

namespace Blog.Repositories
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public ArticleRepository(BlogContext context) : base(context)
        {
        }

        public IEnumerable<Article> GetTopTenViewedArticles()
        {
            return Context.Articles.OrderByDescending(a => a.Views).Take(10).ToList();
        }

        public new BlogContext Context
        {
            get { return base.Context as BlogContext; }
        }
    }
}
