using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace src.Controllers
{
    [Route("calc")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET /
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "lambda calculator!";
        }

        // GET calc/add/2/3
        [HttpGet("add/{id1}/{id2}")]
        public ActionResult<int> Get(int id1, int id2)
        {
            return id1 + id2;
        }

        // GET calc/sub/2/3
        [HttpGet("sub/{id1}/{id2}")]
        public ActionResult<int> Get(int id1, int id2)
        {
            return id1 - id2;
        }

    }
}
