using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataModels
{
    public class MyAppContext: DbContext 
    {
        public MyAppContext() : base(@"Data Source = EMCSERVERHP\SQLEXPRESS; Initial Catalog = TENDENCIA; Persist Security Info=True;User ID = sa; Password = 1234santiago")
        {
        }
        // REQUERIMIENTO 1
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Anoucing> Anoucing { get; set; }
        public virtual DbSet<Community> Community { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<EconomicSector> EconomicSector{ get; set; }
        public virtual DbSet<ProductService> ProductService { get; set; }
        public virtual DbSet<CompanyEconomicSector> CompanyEconomicSector { get; set; }
        public virtual DbSet<VirtualCourse> VirtualCourse { get; set; }
        public virtual DbSet<CtrlCommunity> CtrlCommunity{ get; set; }
        public virtual DbSet<AnoucingProgress> AnouncingProgress { get; set; }
        public virtual DbSet<ApplyProgress> ApplyProgress { get; set; }

        // REQUERIMIENTO 2

       /* public virtual DbSet<TemplateNewsTrendsOne> TemplateNewsTrendsOne { get; set; }
        public virtual DbSet<TemplateNewsTrendsTwo> TemplateNewsTrendsTwo { get; set; }

        public virtual DbSet<TemplateNewsTrendsThree> TemplateNewsTrendsThree { get; set; }
        public virtual DbSet<TemplateNewsTrendsThreeDetail> TemplateNewsTrendsThreeDetail { get; set; }

        public virtual DbSet<TemplateNewsTrendsFour> TemplateNewsTrendsFour { get; set; }

        public virtual DbSet<TemplateNewsTrendsFive> TemplateNewsTrendsFive { get; set; }
        public virtual DbSet<TemplateNewsTrendsFiveDetail> TemplateNewsTrendsFiveDetail { get; set; }

        public virtual DbSet<TemplateNewsTrendsSix> TemplateNewsTrendsSix { get; set; }
        public virtual DbSet<TemplateNewsTrendsSixDetail> TemplateNewsTrendsSixDetail { get; set; }*/



        // 1. Instalar Entity Framework
        // 2. Crear clase que herede de DbContext
        // 3. Ejecutar enable-migratios
        // 4. Ejecutar update-database -force -verbose
    }
}
