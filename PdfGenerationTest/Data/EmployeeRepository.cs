using PdfGenerationTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PdfGenerationTest.Data
{
    public class EmployeeRepository
    {
        private List<Employee> _employees;

        public EmployeeRepository()
        {
            _employees = new List<Employee>();
            _employees.Add(new Employee() { Name="Test1", Age=10, CPR="323556-1235"});
            _employees.Add(new Employee() { Name = "Test2", Age = 11, CPR = "323556-1235" });
            _employees.Add(new Employee() { Name = "Test3", Age = 12, CPR = "323556-1235" });
        }

        public List<Employee> GetAll()
        {
            return _employees;
        }

        public Employee Get(int id)
        {
            return _employees[id - 1];
        }
    }
}
