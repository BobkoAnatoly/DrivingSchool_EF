using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace DrivingSchool.Model
{
    public class DrivingSchoolDbContext:DbContext
    {
        public DrivingSchoolDbContext()=>Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var configbuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            builder.UseSqlServer(configbuilder.Build().GetConnectionString("DefaultConnection"));

        }
    }
}
