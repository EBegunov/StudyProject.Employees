using StudyProject.Employees.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudyProject.Employees.Servises
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>
            {
                new Employee()
                {
                    Id = 0, Name = "Иван", Email = "Ivan@rogaandkopito.bla", PhotoPath = "Avatar.png", Department = Dept.IT
                },
                new Employee()
                {
                    Id = 1, Name = "Федор", Email = "Fedor@rogaandkopito.bla", PhotoPath = "Avatar4.png", Department = Dept.IT
                },
                new Employee()
                {
                    Id = 2, Name = "Семён", Email = "Semen@rogaandkopito.bla", PhotoPath = "Avatar5.png", Department = Dept.IT
                },
                new Employee()
                {
                    Id = 3, Name = "Оля", Email = "Olga@rogaandkopito.bla", PhotoPath = "Avatar2.png", Department = Dept.HR
                },
                new Employee()
                {
                    Id = 4, Name = "Клава", Email = "Klava@rogaandkopito.bla", Department = Dept.HR
                },
                new Employee()
                {
                    Id = 5, Name = "Марфа Семёновна", Email = "Semenovna@rogaandkopito.bla", PhotoPath = "Avatar3.png", Department = Dept.Payroll  
                }
            };
        }
        
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }

        public Employee Update(Employee updatedEmployee)
        {
            Employee employee = _employeeList.FirstOrDefault(x => x.Id == updatedEmployee.Id);

            if (employee != null)
            {
                employee.Name = updatedEmployee.Name;
                employee.Email = updatedEmployee.Email;
                employee.Department = updatedEmployee.Department;
                employee.PhotoPath = updatedEmployee.PhotoPath;
            }

            return employee;
        }
    }
}
