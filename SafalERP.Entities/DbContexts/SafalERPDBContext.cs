using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SafalERP.Entities.Entities;

namespace SafalERP.Entities.DbContexts
{
    public class SafalERPDBContext : DbContext
    {
        public SafalERPDBContext(DbContextOptions<SafalERPDBContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        public DbQuery<GetTest> GetTest { get; set; }
    }
}
