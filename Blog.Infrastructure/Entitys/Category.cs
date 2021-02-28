using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Infrastructure.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string PostFKey { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
