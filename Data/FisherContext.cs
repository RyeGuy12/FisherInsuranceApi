using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using FisherInsuranceApi.Models;

namespace FisherInsuranceApi.Data
{
    public class FisherContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Quote> Quotes { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)        
        {            
            string connection = "User ID=fisher-user;Password=Oakley123$;Host=localhost;Port=5432;Database=fisher-insurance;Pooling=true;"; 
                   
            optionsBuilder.UseNpgsql(connection);         
        }
    }


}