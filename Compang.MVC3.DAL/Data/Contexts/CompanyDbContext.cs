using Compang.MVC3.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Compang.MVC3.DAL.Data.Contexts
{
    public class CompanyDbContext: DbContext
    {

        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server = NADAAEISSAA; Database = Companyy ; Tursted_Connection = True; TrustedServerCertificate = True ");

        //}

        public DbSet<Department> Departments { get; set; }
    }
}
