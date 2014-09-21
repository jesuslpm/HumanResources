using HumanResources.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Repositories
{
    public interface IRepository<T> where T: class, IEntity
    {
        T Get(int id);
        void Save(T entity);
        bool Exists(int id);
        void Reload(T entity);
    }
}
