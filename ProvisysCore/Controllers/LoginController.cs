using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ProvisysCore.Models;
using ProvisysCore.Services;



namespace ProvisysCore.Controllers
{
   
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
