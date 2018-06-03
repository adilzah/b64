using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using b64.Models;

namespace b64.Controllers
{
    [Route("api/decode")]
    [ApiController]
    public class DecodeController : Controller
    {
        [HttpGet]
        [Route("{value}")]
        public ActionResult<string> Get(string value)
        {
            if(string.IsNullOrEmpty(value))
            {
                return BadRequest();
            }

            try
            {
                var bytes = Convert.FromBase64String(value);
                return System.Text.Encoding.Unicode.GetString(bytes);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
