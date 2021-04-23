using ManagerMicroservices.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerMicroservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        public GitDBContext service;

        public ManagerController()
        {
            service = new GitDBContext();
        }
        [HttpGet]
        //[Route("api/[controller]")]
        public IActionResult GetMnager()
        {
            return Ok(service.Managers.ToList());
        }


    }
}
