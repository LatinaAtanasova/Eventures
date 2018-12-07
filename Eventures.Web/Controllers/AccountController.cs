using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Eventures.Models;
using Eventures.Web.ViewModels.Accounts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using X.PagedList;

namespace Eventures.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<EventuresUser> signIn;
        private readonly IMapper mapper;
        private readonly UserManager<EventuresUser> userManager;
        private readonly RoleManager<EventuresUser> roleManager;


        public AccountController(SignInManager<EventuresUser> signIn,
                                IMapper mapper,
                                UserManager<EventuresUser> userManager,
                                RoleManager<IdentityRole> roleManager)
        {
            this.signIn = signIn;
            this.mapper = mapper;
            this.userManager = userManager;

        }

        public IActionResult Login()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            var user = this.signIn.UserManager.Users.FirstOrDefault(u => u.UserName == model.Username);


            this.signIn.SignInAsync(user, model.RememberMe).Wait();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return this.View();
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Register(RegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var user = this.mapper.Map<EventuresUser>(viewModel);

                //var user = new EventuresUser()
                //{
                //    Email = viewModel.Email,
                //    UserName = viewModel.Username,
                //    FirstName = viewModel.FirstName,
                //    LastName = viewModel.LastName,
                //    UniqueCitizenNumber = viewModel.UniqueCitizenNumber
                //};


                var result = this.signIn.UserManager.CreateAsync(user, viewModel.Password).Result;

                var resultRole = this.userManager.AddToRoleAsync(user, "User").Result;

                if (this.signIn.UserManager.Users.Count() == 1)
                {
                    var roleResult = this.signIn.UserManager.AddToRoleAsync(user, "Admin").Result;
                    if (roleResult.Errors.Any())
                    {
                        return this.View();
                    }
                }

                if (result.Succeeded && resultRole.Succeeded)
                {
                    this.signIn.SignInAsync(user, false).Wait();
                    return this.RedirectToAction("Index", "Home");

                }

                else
                {
                    return this.View();
                }

            }

            else
            {
                return this.View(viewModel);

            }
        }
        [HttpPost]
        public IActionResult Logout()
        {

            foreach (var cookie in this.signIn.Context.Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);
            }

            this.signIn.SignOutAsync();


            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult UserAdministration()
        {
            var usersOfRole = this.userManager.Users.ToList();

            List<UserAdministrationViewModel> usersForDisplay = new List<UserAdministrationViewModel>();

            foreach (var userInDb in usersOfRole)
            {
                var currentRole = userManager.GetRolesAsync(userInDb).Result.FirstOrDefault();


                var userAdm = new UserAdministrationViewModel()
                {
                    CurrentUserRole = currentRole,
                    Email = userInDb.Email,
                    FirstName = userInDb.FirstName,
                    LastName = userInDb.LastName,
                    UserId = userManager.GetUserIdAsync(userInDb).Result,
                    Username = userInDb.UserName
                };

                usersForDisplay.Add(userAdm);
            }


            return this.View(usersForDisplay);
        }

        public IActionResult ChangeRole(AdministrationViewModel model)
        {
            string id = model.UserId;

            var userForEdit = userManager.Users.FirstOrDefault(u => u.Id == id);

            var roleForEdit = userManager.GetRolesAsync(userForEdit).Result.FirstOrDefault();

            if (roleForEdit == "Admin")
            {
                var result = userManager.AddToRoleAsync(userForEdit, "User").Result;
                if (result.Succeeded)
                {
                    return this.RedirectToAction("UserAdministration", "Account");
                }
            }

            if (roleForEdit == "User")
            {
                var result = userManager.AddToRoleAsync(userForEdit, "Admin").Result;
                if (result.Succeeded)
                {
                    return this.RedirectToAction("UserAdministration", "Account");
                }
            }

            return this.RedirectToAction("UserAdministration", "Account");

        }
    }
}