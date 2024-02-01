using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ooad_homework.Common.Repositories.Interfaces;

namespace ooad_homework.Common.Repositories
{
    public abstract class RepositoryBase<T, K> : IRepositoryBase<T, K>  where T : EntityBase<K> 
    {
        public RepositoryBase(DbContext dbContext){
            _dbContext = dbContext ; 
        }
        private DbContext _dbContext ;  
        public K Create(T entity)
        {
            _dbContext.Add(entity) ;
            _dbContext.SaveChanges(); 
            return entity.Id ; 
        }

        public IEnumerable<K> CreateMany(IEnumerable<T> entities)
        {
            _dbContext.AddRange(entities);
            _dbContext.SaveChanges();
            return entities.Select(entity => entity.Id);
        }

        public void Delete(T entity)
        {
            _dbContext.Remove(entity);
        }

        public IEnumerable<T> GetAll()  => _dbContext.Set<T>().ToList();

        public IEnumerable<T> GetByCondition(Func<T,bool> condition)  => _dbContext.Set<T>().Where(condition) ; 
        

        public T Update(K key, T entity)
        {
            var currentValue = _dbContext.Set<T>().Where(entity => entity.Id.Equals(key)).First(); 
            _dbContext.Set<T>().Attach(currentValue).CurrentValues.SetValues(entity); 
            _dbContext.Set<T>().Update(entity);
            _dbContext.SaveChanges();
            return entity; 
        }
    }
}