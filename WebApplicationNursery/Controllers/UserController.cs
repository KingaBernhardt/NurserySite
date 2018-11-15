using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationNursery.Models;
using WebApplicationNursery.Services;

namespace WebApplicationNursery.Controllers
{
    [Route("/")]
    public class UserController : Controller
    {
        private UserService userService;
        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Groups()
        {
            return View(userService.GetViewModel());
        }
        
        [HttpGet("login")]
        public IActionResult GetLogin()
        {
            return View("login");
        }

        [HttpPost("login")]
        public IActionResult Login()
        {
            return RedirectToAction("Index");
        }

        [HttpGet("registration")]
        public IActionResult Registration()
        {
            return View("registration");
        }

        [HttpPost("registration")]
        public IActionResult Registration([FromForm] string email, string firstname, string lastname, string password)
        {
            UserDTO user =
            new UserDTO()
            {
                Email = email,
                FirstName = firstname,
                LastName = lastname,
                Password = password
            };
            userService.AddUser(user);

            return RedirectToAction("login");
        }
    }
}