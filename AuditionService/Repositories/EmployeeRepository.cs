using AuditionService.Interfaces;
using AuditionService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuditionService.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {

        public Employee Add(Employee entity)
        {
            // Simulate database insert, which typically generates an ID
            entity.Id = Guid.NewGuid();

            return entity;
        }

        public IEnumerable<Employee> All()
        {
            return new List<Employee>
            {
                CreateEmployee(firstName: "Employee", lastName: "One", isActive: true),
                CreateEmployee(firstName: "Employee", lastName: "Two", isActive: false),
                CreateEmployee(firstName: "Employee", lastName: "Three", isActive: true)
            };
        }

        public void Delete(Employee entity)
        {

        }

        public Employee Get(Func<Employee, bool> predicate)
        {
            return CreateEmployee(firstName: "Josh", lastName: "Smith", isActive: true);
        }

        public IEnumerable<Employee> GetMany(Func<Employee, bool> predicate)
        {
            return new List<Employee>
            {
                CreateEmployee(firstName: "Employee", lastName: "One", isActive: true),
                CreateEmployee(firstName: "Employee", lastName: "Two", isActive: false)
            };
        }

        public Employee Update(Employee entity)
        {
            // Simulate database update, which typically just returns the updated record
            return entity;
        }

        private Employee CreateEmployee(string firstName, string lastName, bool isActive)
        {
            return new Employee
            {
                Id = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                IsActive = isActive
            };
        }
    }
}