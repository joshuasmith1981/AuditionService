using AuditionService.Models;
using System;
using System.Web.Http;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Net;

namespace AuditionService.Results
{
    public class EmployeeResult : IHttpActionResult
    {
        private readonly Employee _employee;
        private readonly HttpRequestMessage _request;

        public EmployeeResult(Employee employee, HttpRequestMessage request)
        {
            if (employee == null)
            {
                throw new ArgumentNullException("employee");
            }

            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            _employee = employee;
            _request = request;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            var response = _request.CreateResponse(HttpStatusCode.OK, _employee);

            return Task.FromResult(response);
        }
    }
}