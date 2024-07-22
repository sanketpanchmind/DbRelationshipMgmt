using DbRelationshipMgmt.Interface;
using DbRelationshipMgmt.Models;
using Microsoft.AspNetCore.Mvc;

namespace DbRelationshipMgmt.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [Route("signup")]
        public IActionResult Signup()
        {
            return View();
        }

        [Route("signup")]
        [HttpPost]
        public async Task<IActionResult> Signup(SignupUserModel signupUserModel)
        {
            if (ModelState.IsValid)
            {
                var res = await _accountRepository.CreateUserAsync(signupUserModel);
                if(!res.Succeeded)
                {
                    foreach(var errormessage in res.Errors)
                    {
                        ModelState.AddModelError("", errormessage.Description);
                    }                                                        
                    return View(signupUserModel);
                }

                ModelState.Clear();
              
            }
            return View(signupUserModel);
           

        }
    }
}
