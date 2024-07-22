using DbRelationshipMgmt.Interface;
using DbRelationshipMgmt.Models;
using Microsoft.AspNetCore.Identity;

namespace DbRelationshipMgmt.Repositories
{
    public class AccountRepository:IAccountRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        public AccountRepository(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> CreateUserAsync(SignupUserModel signupUserModel)
        {
            var user = new IdentityUser()
            {
                Email = signupUserModel.Email,
                UserName = signupUserModel.Email
            };
           var result = await _userManager.CreateAsync(user, signupUserModel.Password);

            return result;
        }
    }
}
