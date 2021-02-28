using Blog.Domain.Interfaces;
using Blog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Infrastructure.Repository
{
    public class EfPostRepository : IPostRepository
    {
        public ICollection<Post> GetAllPostByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public bool TryCreate(Post model)
        {
            throw new NotImplementedException();
        }

        public bool TryDelete(Post modelForDelete)
        {
            throw new NotImplementedException();
        }

        public bool TryRead(Post modelForRead)
        {
            throw new NotImplementedException();
        }

        public bool TryUpdate(Post modelForUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
