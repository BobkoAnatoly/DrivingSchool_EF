using DrivingSchool.Model.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DrivingSchool.Model.DatabaseModels;
namespace DrivingSchool.Model
{
    public class DrivingSchoolDbContext : DbContext
    {
        public DrivingSchoolDbContext()
         => Database.EnsureCreated();

        public DbSet<DrivingCategory> DrivingCategories = null!;
        public DbSet<DrivingLesson> DrivingLessons = null!;
        public DbSet<Instructor> Instructors = null!;
        public DbSet<Lecturer> Lecturers = null!;
        public DbSet<Lesson> Lessons = null!;
        public DbSet<PaidService> PaidServices = null!;
        public DbSet<Person> People = null!;
        public DbSet<Service> Services = null!;
        public DbSet<Student> Students = null!;
        public DbSet<StudyStream> StudyStreams = null!;
        public DbSet<Teacher> Teachers = null!;
        public DbSet<Vehicle> Vehicles = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var configbuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            builder.UseSqlServer(configbuilder.Build().GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new VehicleConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new StudyStreamConfiguration());
            builder.ApplyConfiguration(new LessonConfiguration());
            base.OnModelCreating(builder);
        }

    }
}
