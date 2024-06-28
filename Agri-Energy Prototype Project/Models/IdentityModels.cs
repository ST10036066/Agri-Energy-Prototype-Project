using System.Data.Entity;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Agri_Energy_Prototype_Project.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Salt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }



        public string UserType { get; set; }
        //  = model.FirstName,
        //  = model.LastName,
        // Age = model.Age , Email = model.Email,
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private static ApplicationDbContext contextInstance;

        public ApplicationDbContext() : base("DefaultConnection") { }

        public DbSet<SustainableFarmingHUB> SustainableFarmingHUB { get; set; }

      //  protected override void OnModelCreating(ModelBuilder builder)
      //  {
       //     builder.Entity<SustainableFarmingHUB>().HasKey(e => e.ProductId);
      //  }


        // public ApplicationDbContext(IdentityDbContext<ApplicationDbContext> options)
        //  : base(options)
        //: base("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Aria\\source\\repos\\Agri-Energy Prototype Project\\Agri-Energy Prototype Project\\App_Data\\Agri-EnergyConnectDB.mdf\";Integrated Security=True", throwIfV1Schema: false)
        // {

        // }

       // public DbSet<SustainableFarmingHUB> SustainableFarmingHUB { get; set; }
       // protected override void OnModelCreating(ModelBuilder modelBuilder)
       // {
        //    modelBuilder.Entity<SustainableFarmingHUB>().HasKey(e => e.ProductId);
       // }
  //  }

    public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}