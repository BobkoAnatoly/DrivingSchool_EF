using DrivingSchool.Model.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrivingSchool.Model.EntityConfiguration
{
    public class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasMany(x => x.DrivingLessons)
                .WithOne(x => x.Vehicle)
                .OnDelete(DeleteBehavior.Restrict);
                
                
        }
    }
}
