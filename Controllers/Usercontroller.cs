using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace login.Controllers
{
    [ApiController]
    [Route("")]
    public class UserController : ControllerBase
    {
        [HttpGet("checkLogin")] // checkLogin?id=3
        public IActionResult Login([FromQuery] int id)
        {


            return Ok(new { code = 0 });
        }

        [HttpPost("checkLogin")]
        public IActionResult Login(string Name, string Password)
        {

            Console.WriteLine(Name);
            return Ok(new { code = 0 });
        }
    }
}
