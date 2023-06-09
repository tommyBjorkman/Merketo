﻿using Microsoft.AspNetCore.Mvc;
using WebApp.Models.ViewModels;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        #region My Account (https://domain.com/account)
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region Register (https://domain.com/account/register)
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(AccountRegisterViewModel viewModel)
        {
            return View();
        }
        #endregion

        #region Login (https://domain.com/account/login)
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(AccountLoginViewModel viewModel)
        {
            return View();
        }
        #endregion

        #region Logout (https://domain.com/account/logout)
        public IActionResult Logout()
        {
            return View();
        }
        #endregion
    }
}
