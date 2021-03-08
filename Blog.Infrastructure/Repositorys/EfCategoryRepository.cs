using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Blog.Domain.Interfaces;
using Blog.Domain.Models;

namespace Blog.Infrastructure.Repositorys
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private readonly IMapper _mapper;

        public EfCategoryRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public ICollection<Category> AllCategories()
        {
            ICollection<Category> allCategories;

            using (var context = new BlogContext())
            {
                var entityCategories = from catigories in context.Categories
                                select catigories;

                allCategories = _mapper.ProjectTo<Category>(entityCategories).ToList();
            }

            return allCategories;
        }

        public bool TryCreate(Category model)
        {
            var success = true;

            using (var context = new BlogContext())
            {
                var categoryEntityExists = context.Categories.Any(catEntity => catEntity.Name == model.Name);

                if (categoryEntityExists)
                    success = false;
                else
                {
                    var categoryModel = _mapper.Map<Entity.Category>(model);
                    context.Categories.Add(categoryModel);
                    context.SaveChanges();
                }
            }

            return success;
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
