﻿using HumanResources.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Repositories
{
    internal abstract class Repository<T>: IRepository<T> where T: class, IEntity
    {
        protected readonly DbContext context;

        public Repository(DbContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            this.context = context;
        }

        public T Get(int id)
        {
            return this.context.Set<T>().Find(id);
        }

        public void Save(T entity)
        {
            var validationResult = entity.Validate();
            if (!validationResult.IsValid) throw new ValidationException(validationResult);
            bool isNew = entity.Id == 0;
            try
            {
                if (isNew)
                {
                   
                    this.context.Set<T>().Add(entity);
                }
                else
                {
                    this.context.Entry<T>(entity).State = EntityState.Modified;
                }
                this.context.SaveChanges();
            }
            catch
            {
                if (isNew) entity.Id = 0;
                throw;
            }
        }

        public bool Exists(int id)
        {
            return this.context.Set<T>().Any(x => x.Id == id);
        }

        public void Reload(T entity)
        {
            this.context.Entry(entity).Reload();
        }

        public void Delete(T entity)
        {
            this.context.Set<T>().Remove(entity);
            this.context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = this.context.Set<T>().Find(id);
            if (entity != null)
            {
                Delete(entity);
            }
        }


    }
}
