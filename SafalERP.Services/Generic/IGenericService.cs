using SafalERP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SafalERP.Services.Generic
{
    public interface IGenericService<TEntity> where TEntity : BaseEntity
    {
        IList<TEntity> GetAll();

        TDto GetAll<TDto>();

        TEntity GetById(object id);

        TDto GetById<TDto>(object id);

        Task<TDto> GetByIdAsync<TDto>(object id);

        void Insert(TEntity entity);

        void Insert<TDto>(TDto dto);

        void Insert(IEnumerable<TEntity> entities);

        void Insert<TDto>(IEnumerable<TDto> dtos);

        void Update(TEntity entity);

        void Update<TDto>(TDto dto);

        void Update<TDto>(object id, TDto dto);

        void Update(IEnumerable<TEntity> entities);

        void Update<TDto>(IEnumerable<TDto> dtos);

        void Delete(TEntity entity);

        void Delete<TDto>(TDto dto);

        void Delete(IEnumerable<TEntity> entities);

        void Delete<TDto>(IEnumerable<TDto> dtos);

        void DeleteById(object id);
    }
}
