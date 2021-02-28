using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Infrastructure.Entity
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
