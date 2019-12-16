using AutoMapper;
using SafalERP.Data.Repositories.Procedure;
using SafalERP.Entities.Dtos.OutputDtos;
using SafalERP.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafalERP.Services.Test
{
    public class TestService : ITestService
    {
        private readonly IProcedureRepository _procedureRepository;
        private readonly IMapper _mapper;

        public TestService(IProcedureRepository procedureRepository,
            IMapper mapper)
        {
            _procedureRepository = procedureRepository;
            _mapper = mapper;
        }

        public async Task<List<TOut>> GetData<TIn, TOut>(int id, string name) where TIn : class
        {
            var paramList = new[]
            {
                new SqlParameter("Id", id),
                new SqlParameter("Name", name),
            };

            var data = await _procedureRepository.Execute<TIn>(paramList);


            return _mapper.Map<List<TOut>>(data);
        }
    }
}
