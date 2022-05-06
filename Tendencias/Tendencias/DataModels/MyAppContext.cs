using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace Tendencias.DataModels
{
    public  class MyAppContext : DbContext
    {
   
        public virtual DbSet<Course> Course { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=EMCSERVERHP\SQLEXPRESS;Initial Catalog=TENDENCIA; Persist Security Info=True; User Id=sa;Password=1234santiago");
        }
    }
}
