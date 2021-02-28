using Blog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Domain.Interfaces
{
    public interface IPostRepository : IRepository<Post>
    {
        public ICollection<Post> GetAllPostByCategory(Category category);
    }
}
