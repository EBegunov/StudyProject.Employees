using StudyProject.Employees.Models;
using System.Collections.Generic;

namespace StudyProject.Employees.Servises
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();

        Employee GetEmployee(int id);

        Employee Update(Employee updatedEmployee);
    }
}
