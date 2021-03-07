using API_Interview.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Interview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoEmployeeDataController : ControllerBase
    {
        private readonly ILogger<DemoEmployeeDataController> _logger;

        public DemoEmployeeDataController(ILogger<DemoEmployeeDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public MasterDataModel Get()
        {
            var rng = new Random();
            var result =  new MasterDataModel
            {
                Date = DateTime.Now,
                Name = "Wattanavee Nongjan",
                Desc = "SolutionLink Employee Senior Developer",
                Remark = "Demo API with Swagger UI .NetCore"
            };
            return result;
        }
    }
}
