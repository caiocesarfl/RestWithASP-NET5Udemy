using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestWithASP_NETUdemy.Business;
using RestWithASP_NETUdemy.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NETUdemy.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Authorize("Bearer")]
    [Route("api/[controller]/v{version:apiVersion}")]
    
    public class AuthController : ControllerBase
    {
        private ILoginBusiness _loginBusiness;
    

        [HttpPost]
        [Route("signin")]

        public IActionResult Signin([FromBody] UserVO user)
        {
            if (user == null)
            {
                return BadRequest("Invalid client request");
            }

            var token = _loginBusiness.ValidadeCredentials(user);

            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
    }
}
