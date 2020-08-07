using System.Collections.Generic;

namespace InsuranceTest.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        void Add(TEntity entity);
        void Update(TEntity employee, TEntity entity);
        void Delete(TEntity entity);
    }
}
