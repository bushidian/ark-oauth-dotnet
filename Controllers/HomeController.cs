using System;
using Microsoft.AspNetCore.Mvc;

namespace Ark.OAuth.Controllers
{
    public class HomeController : Controller
    {

        [Route("")]
        public string Index()
        {
            return "hello world";
        }
    }
}