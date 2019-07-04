using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GrapeApe.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StreamersController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            // TODO: Allow filtering by id or login or returning all
            // TODO: Pagination
            return new string[] { "value1", "value2" };
        }
    }
}
