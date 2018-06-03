using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using b64.Models;

namespace b64.Controllers
{
    [Route("api/encode")]
    [ApiController]
    public class EncodeController : Controller
    {
        [HttpGet]
        [Route("{value}")]
        public ActionResult<string> Post(string value)
        {
            if(string.IsNullOrEmpty(value))
            {
                return BadRequest();
            }

            var bytes = System.Text.Encoding.Unicode.GetBytes(value);
            
            return Convert.ToBase64String(bytes);
        }
    }
}
