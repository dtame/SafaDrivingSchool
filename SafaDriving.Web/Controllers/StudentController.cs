using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SafaDriving.Web.Models;

namespace SafaDriving.Web.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private ApplicationUser ApplicationUser => _userManager.GetUserAsync(User).Result;
        public StudentController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Dashboard(string email)
        {
                        
            return View();
        }
    }
}