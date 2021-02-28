using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Domain.Models
{
    public class Post
    {
        public int Index { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        //public ICollection<Category> Categories { get; set; }
    }
}
