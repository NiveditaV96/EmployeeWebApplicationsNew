using EmployeeWebApplication.Models;
using EmployeeWebApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeWebApplication.Controllers
{
    public class EmployeeController : ApiController
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpPost]
        public IHttpActionResult Create(Employee employee)
        {
            _employeeRepository.Add(employee);
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.Created));

        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            return Ok(_employeeRepository.GetAll());
        }

        public IHttpActionResult GetById(int id)
        {
            var employee = _employeeRepository.GetById(id);
            return Ok(employee);
        }


        public IHttpActionResult Delete(int id)
        {
           
            _employeeRepository.Delete(id);
            return Ok();
        }


    }
}
