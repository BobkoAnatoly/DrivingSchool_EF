using DrivingSchool.Model.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrivingSchool.Model.EntityConfiguration
{
    public class StudyStreamConfiguration : IEntityTypeConfiguration<StudyStream>
    {
        public void Configure(EntityTypeBuilder<StudyStream> builder)
        {
            builder.HasOne(x => x.DrivingCategory)
                .WithMany(x => x.StudyStreams)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
