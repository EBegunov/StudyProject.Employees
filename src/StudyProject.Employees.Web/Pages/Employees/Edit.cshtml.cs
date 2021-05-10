using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudyProject.Employees.Models;
using StudyProject.Employees.Servises;

namespace StudyProject.Employees.Web.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EditModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee Employee { get; set; }

        [BindProperty]
        public IFormFile Photo { get; set; }

        public IActionResult OnGet(int id)
        {
            Employee = _employeeRepository.GetEmployee(id);

            if (Employee == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }

        public IActionResult OnPost(Employee employee)
        {
            Employee = _employeeRepository.Update(employee);
            
            return RedirectToPage("Employees");
        }




    }
}
