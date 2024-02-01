using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ooad_homework.Common.Repositories.Interfaces
{
    // T = type , K = type of Key 
    public interface IRepositoryBase<T,K> where T : EntityBase<K> 
    {
        IEnumerable<T> GetAll(); 

        IEnumerable<T> GetByCondition(Func<T,bool> condition); 

        K Create(T entity); 

        IEnumerable<K> CreateMany(IEnumerable<T> entities);

        T Update( K key , T entity); 

        void Delete(T entity); 
    }
}