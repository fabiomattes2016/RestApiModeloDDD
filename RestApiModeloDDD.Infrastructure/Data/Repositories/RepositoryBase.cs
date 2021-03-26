using Microsoft.EntityFrameworkCore;
using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestApiModeloDDD.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class 
    {
        private readonly SqlContext sqlContext;

        public RepositoryBase(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        void IRepositoryBase<TEntity>.Add(TEntity obj)
        {
            try
            {
                sqlContext.Set<TEntity>().Add(obj);
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        IEnumerable<TEntity> IRepositoryBase<TEntity>.GetAll()
        {
            return sqlContext.Set<TEntity>().ToList();
        }

        TEntity IRepositoryBase<TEntity>.GetById(int id)
        {
            return sqlContext.Set<TEntity>().Find(id);
        }

        void IRepositoryBase<TEntity>.Remove(TEntity obj)
        {
            try
            {
                sqlContext.Set<TEntity>().Remove(obj);
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        void IRepositoryBase<TEntity>.Update(TEntity obj)
        {
            try
            {
                sqlContext.Entry(obj).State = EntityState.Modified;
                sqlContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
