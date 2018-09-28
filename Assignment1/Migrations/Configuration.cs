namespace Assignment1.Migrations
{
    using Assignment1.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment1.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Assignment1.Models.ApplicationDbContext";
        }

        protected override void Seed(Assignment1.Models.ApplicationDbContext context)
        {
            ApplicationUser adminUser = null;
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            adminUser = new ApplicationUser();
            adminUser.UserName = "admin@gmail.com";
            adminUser.Email = "admin@gmail.com";
            userManager.Create(adminUser, "Password-1");
        }
    }
}
