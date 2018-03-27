using System.Collections.Generic;
using System.Linq;
using Blog.Domain;

namespace Blog
{
    public class ServiceLayer
    {
        private readonly UnitOfWork _unitOfWork;

        public ServiceLayer(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Article> GetArticlesFromAuthor(int id)
        {
            var author = _unitOfWork.Authors.Get(id);

            return author.Articles.ToList();
        }
    }
}
