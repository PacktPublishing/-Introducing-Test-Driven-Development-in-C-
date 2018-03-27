using Blog;
using Blog.Core;
using Blog.Domain;

namespace BlogAppDevelopment
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var blog = new UnitOfWork(new BlogContext()))
            {
                var author1 = new Author(){Id = 1, Active = true, Name = "Nikola Zivkovic", NickName = "rubikscode"};
                blog.Authors.Add(author1);
                blog.Save();
            }
        }
    }
}
