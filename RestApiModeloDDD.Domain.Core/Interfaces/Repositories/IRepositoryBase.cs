using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Domain.Core.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        IEnumerable<TEntity> GetAll(); // Enumerable é uma lista de leitura somente e List usa muita memória
        TEntity GetById(int id);
    }
}
