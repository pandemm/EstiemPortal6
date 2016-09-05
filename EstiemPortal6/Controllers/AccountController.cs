﻿using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using EstiemPortal6.Models;
using System.Web.Security;
using EstiemPortal6.ViewModels;

namespace EstiemPortal6.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        //private ApplicationSignInManager _signInManager;
        //private ApplicationUserManager _userManager;

        //public AccountController()
        //{
        //}

        //public AccountController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        //{
        //    UserManager = userManager;
        //    SignInManager = signInManager;
        //}

        //public ApplicationSignInManager SignInManager
        //{
        //    get
        //    {
        //        return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
        //    }
        //    private set
        //    {
        //        _signInManager = value;
        //    }
        //}

        //public ApplicationUserManager UserManager
        //{
        //    get
        //    {
        //        return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
        //    }
        //    private set
        //    {
        //        _userManager = value;
        //    }
        //}

        MyMembershipProvider provider = (MyMembershipProvider)Membership.Provider;
        [HttpGet]
        public ActionResult Login() { return View(); }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model, string returnurl)
            {

            //What does this actually do?
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            
            if (ValidateLogOn(model.UserName, model.Password))
            { 
                FormsAuthentication.SetAuthCookie(model.UserName, false);
                return RedirectToLocal(returnurl);
            }
            else
            {
                return View(model);
            }
            }
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        private bool ValidateLogOn(string userName, string password)
            {
                if (string.IsNullOrEmpty(userName))
                {
                    ModelState.AddModelError("username", "You must specify a username.");
                }
                if (string.IsNullOrEmpty(password))
                {
                    ModelState.AddModelError("password", "You must specify a password.");
                }
                if (!provider.ValidateUser(userName, password))
                {
                    ModelState.AddModelError("_form", "the username or password provided is incorrect.");
                }
            return ModelState.IsValid;
            }

            ////
            //// POST: /Account/Login
            //[HttpPost]
            //[AllowAnonymous]
            //[ValidateAntiForgeryToken]
            //public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
            //{
            //    if (!ModelState.IsValid)
            //    {
            //        return View(model);
            //    }

            //    // This doesn't count login failures towards account lockout
            //    // To enable password failures to trigger account lockout, change to shouldLockout: true
            //    var result = await SignInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, shouldLockout: false);
            //    switch (result)
            //    {
            //        case SignInStatus.Success:
            //            return RedirectToLocal(returnUrl);
            //        case SignInStatus.LockedOut:
            //            return View("Lockout");
            //        case SignInStatus.RequiresVerification:
            //            return RedirectToAction("SendCode", new { ReturnUrl = returnUrl, RememberMe = model.RememberMe });
            //        case SignInStatus.Failure:
            //        default:
            //            ModelState.AddModelError("", "Invalid login attempt.");
            //            return View(model);
            //    }
            //}



            ////
            //// POST: /Account/ResetPassword
            //[HttpPost]
            //[AllowAnonymous]
            //[ValidateAntiForgeryToken]
            //public async Task<ActionResult> ResetPassword(ResetPasswordViewModel model)
            //{
            //    if (!ModelState.IsValid)
            //    {
            //        return View(model);
            //    }
            //    var user = await UserManager.FindByNameAsync(model.Email);
            //    if (user == null)
            //    {
            //        // Don't reveal that the user does not exist
            //        return RedirectToAction("ResetPasswordConfirmation", "Account");
            //    }
            //    var result = await UserManager.ResetPasswordAsync(user.Id, model.Code, model.Password);
            //    if (result.Succeeded)
            //    {
            //        return RedirectToAction("ResetPasswordConfirmation", "Account");
            //    }
            //    AddErrors(result);
            //    return View();
            //}

            ////
            //// GET: /Account/ResetPasswordConfirmation
            //[AllowAnonymous]
            //public ActionResult ResetPasswordConfirmation()
            //{
            //    return View();
            //}

            ////
            //// POST: /Account/LogOff
            //[HttpPost]
            //[ValidateAntiForgeryToken]
            //public ActionResult LogOff()
            //{
            //    AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            //    return RedirectToAction("Index", "Home");
            //}


            //protected override void Dispose(bool disposing)
            //{
            //    if (disposing)
            //    {
            //        if (_userManager != null)
            //        {
            //            _userManager.Dispose();
            //            _userManager = null;
            //        }

            //        if (_signInManager != null)
            //        {
            //            _signInManager.Dispose();
            //            _signInManager = null;
            //        }
            //    }

            //    base.Dispose(disposing);
            //}

            //#region Helpers
            //// Used for XSRF protection when adding external logins
            //private const string XsrfKey = "XsrfId";

            //private IAuthenticationManager AuthenticationManager
            //{
            //    get
            //    {
            //        return HttpContext.GetOwinContext().Authentication;
            //    }
            //}

            //private void AddErrors(IdentityResult result)
            //{
            //    foreach (var error in result.Errors)
            //    {
            //        ModelState.AddModelError("", error);
            //    }
            //}

            //private ActionResult RedirectToLocal(string returnUrl)
            //{
            //    if (Url.IsLocalUrl(returnUrl))
            //    {
            //        return Redirect(returnUrl);
            //    }
            //    return RedirectToAction("Index", "Home");
            //}

            //internal class ChallengeResult : HttpUnauthorizedResult
            //{
            //    public ChallengeResult(string provider, string redirectUri)
            //        : this(provider, redirectUri, null)
            //    {
            //    }

            //    public ChallengeResult(string provider, string redirectUri, string userId)
            //    {
            //        LoginProvider = provider;
            //        RedirectUri = redirectUri;
            //        UserId = userId;
            //    }

            //    public string LoginProvider { get; set; }
            //    public string RedirectUri { get; set; }
            //    public string UserId { get; set; }

            //    public override void ExecuteResult(ControllerContext context)
            //    {
            //        var properties = new AuthenticationProperties { RedirectUri = RedirectUri };
            //        if (UserId != null)
            //        {
            //            properties.Dictionary[XsrfKey] = UserId;
            //        }
            //        context.HttpContext.GetOwinContext().Authentication.Challenge(properties, LoginProvider);
            //    }
            //}
            //#endregion
        
    }
}