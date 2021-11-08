using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Identity.Pages
{
    public class LogoutModel : PageModel
    {

        private readonly SignInManager<IdentityUser> signInManager;

        public LogoutModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
            => this.signInManager = signInManager;


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostLogout()
        {
            await signInManager.SignOutAsync();

            return RedirectToPage("Login");
        }

        public IActionResult OnPostDontLogout()
        {
            return RedirectToPage("Index");
        }
    }
}
