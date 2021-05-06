using EmployeeMicroservices.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMicroservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public GitDBContext service;

        public EmployeeController()
        {
            service = new GitDBContext();
        }
        [HttpGet]
        //[Route("api/[controller]")]
        public IActionResult GetEmployee()
        {
            return Ok(service.Employees.ToList());
        }

        public IActionResult GetMaleEmployee()
        {
            return Ok(service.Employees.Where(x => x.Gender == "Male").ToList());
        }

    }
}
