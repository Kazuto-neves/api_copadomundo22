using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Api_Adm.ModelViews;
/*using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;*/

namespace Api_Adm.Controllers
{
    //[ApiController]
    //[Route("/token")]
    public class TokenController : Controller
    {
        [HttpHead]
        public ActionResult Index() { 
            return StatusCode(204);
        }
    }
}