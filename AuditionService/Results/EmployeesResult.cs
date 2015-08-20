using AuditionService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace AuditionService.Results
{
    public class EmployeesResult : IHttpActionResult
    {
        private readonly IEnumerable<Employee> _employees;
        private readonly HttpRequestMessage _request;

        public EmployeesResult(IEnumerable<Employee> employees, HttpRequestMessage request)
        {
            if (employees == null)
            {
                throw new ArgumentNullException("employees");
            }

            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            _employees = employees;
            _request = request;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = _request.CreateResponse(HttpStatusCode.OK, _employees);

            return Task.FromResult(response);
        }
    }
}