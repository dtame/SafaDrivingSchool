using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SafaDriving.Web.Data;
using SafaDriving.Web.Helpers;
using SafaDriving.Web.Models;
using SafaDriving.Web.Models.AccountViewModels;
using SafaEngine.Calendar;
using SafaEngine.Core;
using static SafaEngine.Core.Ennumarations;

namespace SafaDriving.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger _logger;
        private IUnitOfWork dal;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ILogger<AccountController> logger, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            dal = unitOfWork;
        }        

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            RegisterViewModel model = new RegisterViewModel();
            model.ProgramListItems = dal.DrivingPrograms.Get().ToListItems();
            ViewData["ReturnUrl"] = returnUrl;
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.Email
                                                , Email = model.Email
                                                , Address = model.Address
                                                , FirstName = model.FirstName
                                                , LastName = model.LastName
                                                
                };
                var resultRole = await _userManager.AddToRoleAsync(user, ((int)UserRole.Student).ToString());
                if (resultRole.Succeeded) {
                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        _logger.LogInformation("User created a new account with password.");

                        await _signInManager.SignInAsync(user, isPersistent: false);
                        _logger.LogInformation("User created a new account with password.");

                        DrivingProgram program = dal.DrivingPrograms.GetByID(model.ProgramID);

                        //add schedule 
                        dal.CourseSchedules.Insert(new SafaEngine.Calendar.CourseSchedule
                        {
                            HasLearnersLicence = false,
                            StudentID = Int32.Parse(user.Id)
                        }); ;
                        //int scheduleId = dal.CourseSchedules.Get(x => x.StudentID == Int32.Parse(user.Id)).First().CourseScheduleID;

                        //add course events
                        List<Phase> Phases = dal.Phases.Get().ToList();
                        foreach (Phase item in Phases)
                        {
                            List<Course> Courses = dal.Courses.Get(x => x.PhaseId == item.ID).ToList();
                            foreach(Course course in Courses)
                            {
                                CourseEvent courseEvent = new CourseEvent
                                {
                                    CourseID = course.ID,
                                    StudentID = Int32.Parse(user.Id),
                                    Description = course.Title,
                                    Status = (int)CourseState.UNDEFINIED,
                                    CanBeModifyByOthers = true,
                                };
                                dal.CourseEvents.Insert(courseEvent);                                
                            }
                        }

                        //add paiement plan
                        if(model.ProgramID == (int)ProgramType.STANDARD)
                        {                            
                            dal.Paiements.Insert(
                                new SafaEngine.Core.Paiement {
                                StudentID = Int32.Parse(user.Id),
                                Description = "Initial paiement",
                                DueDate = DateTime.Now,
                                PaiementDone = false,
                                ID = 0,
                                Amount = program.Price    
                            }
                            );

                            dal.Paiements.Insert(
                                new SafaEngine.Core.Paiement
                                {
                                    StudentID = Int32.Parse(user.Id),
                                    Description = "Second paiement",
                                    DueDate = DateTime.Now,
                                    PaiementDone = false,
                                    ID = 0,
                                    Amount = program.Price
                                }
                                );
                        }
                        else {                            
                            dal.Paiements.Insert(
                                new SafaEngine.Core.Paiement
                                {
                                    StudentID = Int32.Parse(user.Id),
                                    Description = "Total paiement",
                                    DueDate = DateTime.Now,
                                    PaiementDone = false,
                                    ID = 0,
                                    Amount = program.Price
                                }
                            );

                        }

                        dal.Save();

                        return RedirectToAction("Dashboard", "Student", new { email = user.Email} , null);
                    }
                    AddErrors(result);
                }
                else {
                    AddErrors(resultRole);
                }                
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return RedirectToLocal(returnUrl);
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToAction(nameof(Lockout));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View(model);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Lockout()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }
    }
}