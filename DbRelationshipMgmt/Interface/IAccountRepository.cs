using DbRelationshipMgmt.Models;
using Microsoft.AspNetCore.Identity;

namespace DbRelationshipMgmt.Interface
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUserAsync(SignupUserModel signupUserModel);
    }
}
