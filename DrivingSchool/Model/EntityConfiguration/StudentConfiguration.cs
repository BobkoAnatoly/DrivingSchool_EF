using DrivingSchool.Model.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DrivingSchool.Model.EntityConfiguration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne(x => x.StudyStream)
                .WithMany(x => x.Students)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}