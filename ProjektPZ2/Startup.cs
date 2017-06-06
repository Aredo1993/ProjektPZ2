using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using ProjektPZ2.Models;

[assembly: OwinStartupAttribute(typeof(ProjektPZ2.Startup))]
namespace ProjektPZ2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            var roleManager = new RoleManager<IdentityRole>(
             new RoleStore<IdentityRole>(new ApplicationDbContext()));
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(new ApplicationDbContext()));

            roleManager.Create(new IdentityRole("Admin"));
            roleManager.Create(new IdentityRole("User"));

            //var user = new ApplicationUser { UserName = "admin@gmail.com" };
            //string password = "admin123";
            //userManager.Create(user, password);
            //userManager.AddToRole(user.Id, "Admin");

            //var user2 = new ApplicationUser { UserName = "user@gmail.com" };
            //string password2 = "user123";
            //userManager.Create(user2, password2);
            //userManager.AddToRole(user2.Id, "User");
        }
    }
}
