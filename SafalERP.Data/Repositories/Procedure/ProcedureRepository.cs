using SafalERP.Entities.DbContexts;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Data.Common;
using System;
using System.Text;

namespace SafalERP.Data.Repositories.Procedure
{
    public class ProcedureRepository : IProcedureRepository
    {
        private readonly SafalERPDBContext _context;

        public ProcedureRepository(SafalERPDBContext context)
        {
            _context = context;
        }

        public async Task<List<TSPEntity>> Execute<TSPEntity>(object[] parameters) where TSPEntity : class
        {
            StringBuilder commandText = new StringBuilder();

            commandText.Append(typeof(TSPEntity).Name);

            if (parameters == null && parameters.Length <= 0)
                return await _context.Query<TSPEntity>()
                            .FromSql(commandText.ToString())
                            .ToListAsync();

            var count = 0;
            foreach (var param in parameters)
            {
                var p = param as DbParameter;

                if (p == null)
                    throw new Exception("Invalid parameter");

                commandText.Append(count == 0 ? " " : ",");

                commandText.Append('@' + p.ParameterName);

                count++;
            }

            return await _context.Query<TSPEntity>()
                            .FromSql(commandText.ToString(), parameters)
                            .ToListAsync();
        }

    }
}
