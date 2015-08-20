using AuditionService.Interfaces;
using AuditionService.Models;
using AuditionService.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AuditionService.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IRepository<Employee> _employeeRepository;

        public EmployeesController(IRepository<Employee> employeeRepository)
        {
            if (employeeRepository == null)
            {
                throw new ArgumentNullException("employeeRepository");
            }

            _employeeRepository = employeeRepository;
        }

        public IHttpActionResult Get()
        {
            var employees = _employeeRepository.All();

            return new EmployeesResult(employees, Request);
        }

        public IHttpActionResult Get(Guid id)
        {
            var employee = _employeeRepository.Get(e => e.Id.Equals(id));

            if (employee == null)
            {
                NotFound();
            }

            return new EmployeeResult(employee, Request);
        }
    }
}
