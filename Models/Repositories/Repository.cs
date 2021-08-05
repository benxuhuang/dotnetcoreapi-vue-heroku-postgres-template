using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using dotnetcoreapi_vue_heroku_postgres_template.Models.entities;

namespace dotnetcoreapi_vue_heroku_postgres_template.Models.Repositories
{
    public class Repository<T> where T : class
    {
        protected DataBaseEntity entity = null;

        public Repository() : this(new DataBaseEntity()) { }

        public Repository(DataBaseEntity entity)
        {
            this.entity = entity;
        }

        public List<T> GetAll()
        {
            return entity.Set<T>().ToList();
        }

        public List<T> GetData(Expression<Func<T, bool>> wherePredict)
        {
            return entity.Set<T>().Where(wherePredict).ToList();
        }

        public T Add(T item)
        {
            entity.Set<T>().Add(item);
            return item;
        }

        public void AddRange(List<T> ls)
        {
            entity.Set<T>().AddRange(ls);
        }

        public T Remove(T item)
        {
            entity.Set<T>().Remove(item);
            return item;
        }

        public int Save()
        {
            return entity.SaveChanges();
        }

    }
}