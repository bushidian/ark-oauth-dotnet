using System;
using Microsoft.AspNetCore.Mvc;

namespace ArkApplication.Controllers
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