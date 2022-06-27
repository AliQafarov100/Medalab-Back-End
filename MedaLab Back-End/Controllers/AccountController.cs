using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedaLab_Back_End.Models;
using MedaLab_Back_End.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MedaLab_Back_End.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _manager;
        private readonly SignInManager<AppUser> _signIn;

        public AccountController(UserManager<AppUser> manager,SignInManager<AppUser> signIn)
        {
            _manager = manager;
            _signIn = signIn;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Register(RegisterVM register)
        {
            AppUser user = new AppUser
            {
                FirstName = register.FirstName,
                LastName = register.LastName,
                UserName = register.Username,
                Email = register.Email
            };
            if(register.Term == true)
            {
                IdentityResult result = await _manager.CreateAsync(user, register.Password);

                if (!result.Succeeded)
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("", "Registration system impossible without our condidtions!");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Login(LoginVM login)
        {
            AppUser user = await _manager.FindByNameAsync(login.Username);

            Microsoft.AspNetCore.Identity.SignInResult result = await _signIn.PasswordSignInAsync(user, login.Password, false, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Incorrect password or username");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signIn.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Edit()
        {
            AppUser user = await _manager.FindByNameAsync(User.Identity.Name);

            EditUserVM editUser = new EditUserVM
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Username = user.UserName,
                Email = user.Email
            };

            return View(editUser);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Edit(EditUserVM editUser)
        {
            AppUser existed = await _manager.FindByNameAsync(User.Identity.Name);

            EditUserVM userVM = new EditUserVM
            {
                FirstName = editUser.FirstName,
                LastName = editUser.LastName,
                Username = editUser.Username
            };

            if (!ModelState.IsValid) return View(userVM);

            bool result = userVM.Password == null && userVM.ConfirmPassword == null && userVM.CurrentPassword != null;

            if(editUser.Email == null || editUser.Email != existed.Email)
            {
                ModelState.AddModelError("", "Email connot changed");
                return View(userVM);
            }

            if (result)
            {
                existed.FirstName = editUser.FirstName;
                existed.LastName = editUser.LastName;
                existed.UserName = editUser.Username;
                await _manager.UpdateAsync(existed);
            }
            else
            {
                existed.FirstName = editUser.FirstName;
                existed.LastName = editUser.LastName;
                existed.UserName = editUser.Username;

                IdentityResult identityResult = await _manager.ChangePasswordAsync(existed, editUser.CurrentPassword, editUser.Password);

                if (!identityResult.Succeeded)
                {
                    foreach(IdentityError error in identityResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                        return View(userVM);
                    }
                }
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
