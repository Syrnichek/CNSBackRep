using CNSBack.Models;
using Microsoft.EntityFrameworkCore;

namespace CNSBack
{
    public class ApplicationContext :DbContext
    {
        public DbSet<EmployeeModel> employee { get; set; } = null!;
        
        public DbSet<NewsModel> news { get; set; } = null!;
        
        /*public DbSet<OfficeModel> Office { get; set; } = null!;

        public DbSet<WorkPlaceModel> WorkPlace { get; set; } = null!;

        public DbSet<WorkPlaceTypeModel> WorkPlaceType { get; set; } = null!;

        public DbSet<PositionsModel> Positions { get; set; } = null!;
        
        public DbSet<RoleModel> Role { get; set; } = null!;*/


        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { 
        }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=CNSDb;Username=postgres;Password=1111");
        }
    }
}