using Microsoft.AspNetCore.Mvc;
using System;
namespace netDemo.Controllers
{
    [Route("[controller]")]
    public class ClassController : Controller
    {
        [HttpGet("index")]
        public string index()
        {
            return Environment.GetEnvironmentVariable("asd");
        }
    }

}

