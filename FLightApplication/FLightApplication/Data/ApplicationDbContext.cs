using Microsoft.EntityFrameworkCore;
using FlightManagement.DataModel;
using FlightManagement.DataAccess;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FlightManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext) : base(dbContext) 
        {

        }
        public DbSet<FlightManagement.DataModel.Booking> Booking { get; set; } = default!;
    }
}
