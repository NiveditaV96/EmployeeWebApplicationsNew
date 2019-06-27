using EmployeeWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWebApplication.Repository
{
    public interface IEmployeeRepository
    {
        void Add(Employee emp);

        List<Employee> GetAll();
        Employee GetById(int id);

        Employee Update(Employee employee);
        void Delete(int id);
    }
}
