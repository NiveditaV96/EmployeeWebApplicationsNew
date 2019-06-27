using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeWebApplication.Models;

namespace EmployeeWebApplication.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id=101, Name="Ravi",Designation="Manager"},
            new Employee { Id=102, Name="Rekha",Designation="Snr. Engineer"}
        };

        public void Add(Employee emp)
        {
            employees.Add(emp);
        }

        public void Delete(int id)
        {

            var emp = employees.FirstOrDefault(e => e.Id == id);

            if (emp != null)
                employees.Remove(emp);

        }

        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetById(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        public Employee Update(Employee employee)
        {

            //foreach(var emp in employees.Where(e => e.Id == employee.Id))
            //{
            //    emp.Id = employee.Id;
            //    emp.Name = employee.Name;
            //    emp.Designation = employee.Designation;
            //}

            Employee e1 = employees.Find(e => e.Id == employee.Id);
            e1.Id = employee.Id;
            e1.Name = employee.Name;
            e1.Designation = employee.Designation;

            return employees.FirstOrDefault(e => e.Id == employee.Id);
        }
    }

}