using System.Collections.Generic;

namespace Blog.Domain
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public int Age { get; set; }
        public bool Active { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
