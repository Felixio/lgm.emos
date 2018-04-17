using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lgm.Emos.Web.Models;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Lgm.Emos.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Version"] = @Microsoft.Extensions.PlatformAbstractions.PlatformServices.Default.Application.ApplicationVersion;

            return View();
        }
    }
}
