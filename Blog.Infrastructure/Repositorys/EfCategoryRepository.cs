using System;
using System.Collections.Generic;
using System.Text;
using Blog.Domain.Interfaces;
using Blog.Domain.Models;

namespace Blog.Infrastructure.Repositorys
{
    class EfCategoryRepository : ICategoryRepository
    {
        public bool TryCreate(Category model)
        {
            throw new NotImplementedException();
        }

        public bool TryDelete(Category modelForDelete)
        {
            throw new NotImplementedException();
        }

        public bool TryRead(Category modelForRead)
        {
            throw new NotImplementedException();
        }

        public bool TryUpdate(Category modelForUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
