using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Domain.Interfaces
{
    public interface IRepository<TModel> where TModel : class
    {
        bool TryCreate(TModel model);
        bool TryRead(TModel modelForRead);
        bool TryUpdate(TModel modelForUpdate);
        bool TryDelete(TModel modelForDelete);
    }
}
