using Company.MVC3.BLL.Interfaces;
using Company.MVC3.BLL.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Company.MVC3.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository =  departmentRepository;
        }

        [HttpGet] // Get: /Department/Index

        public IActionResult Index()
        {
            var departments = _departmentRepository.GetAll(); 

            return View(departments); 
        }
    }
}
