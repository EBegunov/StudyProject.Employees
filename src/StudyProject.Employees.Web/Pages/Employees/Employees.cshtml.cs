using Microsoft.AspNetCore.Mvc.RazorPages;
using StudyProject.Employees.Models;
using StudyProject.Employees.Servises;
using System.Collections.Generic;

namespace StudyProject.Employees.Web.Pages.Employees
{
    public class EmployeesModel : PageModel
    {
        private readonly IEmployeeRepository _db;

        public EmployeesModel(IEmployeeRepository db)
        {
            _db = db;
        }

        public IEnumerable<Employee> Employees { get; set; }

        public void OnGet()
        {
            Employees = _db.GetAllEmployees();
        }
    }
}
