using System;
using System.Collections.Generic;
using Lgm.Emos.Core.Entities;

namespace Lgm.Emos.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        IList<T> List();
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
