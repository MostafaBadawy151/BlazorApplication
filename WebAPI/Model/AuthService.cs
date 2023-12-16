using Microsoft.AspNetCore.Identity;
using SharedData.Models;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class AuthService
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AuthService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<IdentityResult> RegisterAsync(RegisterModel model)
        {
            var user = new IdentityUser { UserName = model.Email, Email = model.Email };
            return await userManager.CreateAsync(user, model.Password);
        }

        public async Task<SignInResult> LoginAsync(LoginModel model)
        {
            return await signInManager.PasswordSignInAsync(model.Email, model.Password, false, lockoutOnFailure: false);
        }
    }
}

