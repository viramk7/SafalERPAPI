using System.Collections.Generic;
using System.Threading.Tasks;
using SafalERP.Entities.Entities;

namespace SafalERP.Services.Test
{
    public interface ITestService
    {
        Task<List<TOut>> GetData<TIn, TOut>(int id, string name) where TIn : class;
    }
}