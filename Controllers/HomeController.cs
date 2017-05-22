using System;
using Microsoft.AspNetCore.Mvc;

namespace ark_oauth_dotnet.Controllers
{
    public class HomeController : Controller
    {

        public string Index()
        {
            return "hello world";
        }
    }
}