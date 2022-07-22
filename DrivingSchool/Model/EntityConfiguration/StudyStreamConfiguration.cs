using DrivingSchool.Model.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrivingSchool.Model.EntityConfiguration
{
    public class StudyStreamConfiguration : IEntityTypeConfiguration<StudyStream>
    {
        public void Configure(EntityTypeBuilder<StudyStream> builder)
        {
            builder.HasMany(x=>x.Students)
                .WithOne(x=>x.StudyStream)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(x => x.DrivingCategory)
                .WithMany(x => x.StudyStreams)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
