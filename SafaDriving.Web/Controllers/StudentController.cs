using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SafaDriving.Web.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        public IActionResult Dashboard(string email)
        {
            return View();
        }
    }
}