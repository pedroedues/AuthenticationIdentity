using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.SqlServer.Management.Smo;
using Identity.ViewModel;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Identity.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginViewModel Model { get; set; }

        private readonly SignInManager<IdentityUser> signInManager;

        public LoginModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
            => this.signInManager = signInManager;


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await signInManager.PasswordSignInAsync(Model.Email, Model.Password, Model.RememberMe, false);

                if (identityResult.Succeeded)
                {
                    if (returnUrl is null || returnUrl == "/")
                        return RedirectToPage("Index");
                    else
                        return RedirectToPage(returnUrl);
                }

                ModelState.AddModelError("", "Username or Password incorrect");
            }

            return Page();
        }
    }
}
