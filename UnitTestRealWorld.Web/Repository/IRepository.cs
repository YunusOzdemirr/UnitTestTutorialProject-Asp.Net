using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitTestRealWorld.Web.Repository
{
    public interface IRepository<TEntity> where TEntity:class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int Id);
        Task Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

    }
}