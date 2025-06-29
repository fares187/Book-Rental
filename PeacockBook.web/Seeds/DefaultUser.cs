using PeacockBook.web.Core.Const;
using PeacockBook.web.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing.Constraints;

namespace PeacockBook.web.Seeds
{
    public static class DefaultUser
    {
        public static async Task SeedUsersAcync(UserManager<ApplicationUser> UserManager)
        {
            if (!UserManager.Users.Any())
            {
                ApplicationUser user = new ()
                {
                    UserName="marco34",
                    Email="admim@Peacock.com",
                    FullName = "marco",
                    EmailConfirmed = true,

                };
                var result =await UserManager.CreateAsync(user,"P@ssword121"); // what ever password to test
                if (result.Succeeded)
                {
                    await UserManager.AddToRoleAsync(user,AppRoles.Admin);
                }
                
    

            }
        }
    }
}
