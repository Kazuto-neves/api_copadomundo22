using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_copadomundo22.ModelViews;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api_copadomundo22.Controllers
{
    [ApiController]
    [Route("/token")]
    public class TokenController : ControllerBase
    {
        [HttpHead]
        public ActionResult Index() { 
            return StatusCode(204);
        }
    }
}