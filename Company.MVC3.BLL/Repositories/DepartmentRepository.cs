using Compang.MVC3.DAL.Data.Contexts;
using Compang.MVC3.DAL.Models;
using Company.MVC3.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.MVC3.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {

        private readonly CompanyDbContext _Context;

        public DepartmentRepository()
        {
            _Context = new CompanyDbContext();
        }
        public int Add(Department model)
        {
          
            _Context.Departments.Add(model);
           return _Context.SaveChanges();


        }

        public int Delete(Department model)
        {
           
            _Context.Departments.Remove(model);
            return _Context.SaveChanges();

        }

        public Department Get(int id)
        {
            using CompanyDbContext context = new CompanyDbContext();

            return context.Departments.Find(id);
        }

        public IEnumerable<Department> GetAll()
        {
         

            return _Context.Departments.ToList();
                }

        public int Update(Department model)
        {
            _Context.Departments.Update(model);
            return _Context.SaveChanges();

        }
    }
}
