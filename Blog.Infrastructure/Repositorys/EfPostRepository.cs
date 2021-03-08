using AutoMapper;
using Blog.Domain.Interfaces;
using Blog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blog.Infrastructure.Repository
{
    public class EfPostRepository : IPostRepository
    {
        private readonly IMapper _mapper;

        public EfPostRepository(IMapper mapper)
        {
            _mapper = mapper;
        }
        public ICollection<Post> GetAllPostByCategory(string category)
        {
            ICollection<Post> result;

            using (var context = new BlogContext())
            {
                var allPosts = context.Categories.Where(n => n.Name == category).SelectMany(x => x.Posts);

                result = _mapper.ProjectTo<Post>(allPosts).ToList();

            }

            return result;
            
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
