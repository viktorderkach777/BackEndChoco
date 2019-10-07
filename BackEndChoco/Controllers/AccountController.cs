using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndChoco.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndChoco.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody]LoginViewModel model)
        {

            return Ok();
        }
    }
}