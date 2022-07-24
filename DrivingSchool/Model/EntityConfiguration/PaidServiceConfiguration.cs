using DrivingSchool.Model.DatabaseModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace DrivingSchool.Model.EntityConfiguration
{
    public class PaidServiceConfiguration : IEntityTypeConfiguration<PaidService>
    {
        public void Configure(EntityTypeBuilder<PaidService> builder)
        {
            builder.HasOne(x=>x.Student)
                .WithMany(x=>x.PaidServices)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
