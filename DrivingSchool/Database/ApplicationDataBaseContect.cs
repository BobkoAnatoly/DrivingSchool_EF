using DrivingSchool.Model.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DrivingSchool.Model.DatabaseModels;
using DrivingSchool.Extensions;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using DrivingSchool.Model.DatabaseModels.SpResultModels;

namespace DrivingSchool.Database
{
    public class ApplicationDataBaseContext : DbContext
    {
        public ApplicationDataBaseContext()
        {
          Database.EnsureCreated();
           
        }
        public DbSet<SpStudyStream> SpStudyStreams { get; set; } = null!;
        public DbSet<DrivingCategory> DrivingCategories { get; set; } = null!;
        public DbSet<DrivingLesson> DrivingLessons { get; set; } = null!;
        public DbSet<Lesson> Lessons { get; set; } = null!;
        public DbSet<PaidService> PaidServices { get; set; } = null!;
        public DbSet<Person> People { get; set; } = null!;
        public DbSet<Service> Services { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<StudyStream> StudyStreams { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<Vehicle> Vehicles { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var configbuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            builder.UseSqlServer(configbuilder.Build().GetConnectionString("DefaultConnection"));
            builder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new VehicleConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new StudyStreamConfiguration());
            builder.ApplyConfiguration(new LessonConfiguration());
            builder.ApplyConfiguration(new PaidServiceConfiguration());
            builder.Seed();

            base.OnModelCreating(builder);
        }

    }
}
