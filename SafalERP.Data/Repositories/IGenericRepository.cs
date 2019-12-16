using SafalERP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafalERP.Data.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> Table { get; }
        void Delete(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void DeleteById(object id);
        TEntity GetById(object id);
        Task<TEntity> GetByIdAsync(object id);
        void Insert(IEnumerable<TEntity> entities);
        void Insert(TEntity entity);
        void Update(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
    }
}
