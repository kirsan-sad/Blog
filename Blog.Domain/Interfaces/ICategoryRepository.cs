using Blog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Domain.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        public ICollection<Category> AllCategories();
    }
}
