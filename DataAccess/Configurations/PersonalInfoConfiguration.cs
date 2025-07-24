using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ymyp67CVProjectEntity.Concrete;

namespace Ymyp67CVProjectDataAccess.Configurations
{
    internal class PersonalInfoConfiguration : IEntityTypeConfiguration<PersonalInfo>
    {
        public void Configure(EntityTypeBuilder<PersonalInfo> builder)
        {
            builder.Property(p => p.FirstName).HasMaxLength(20).IsRequired();
            builder.Property(p => p.LastName).HasMaxLength(20).IsRequired();
            builder.Property(p => p.BirthDate).IsRequired();
            builder.Property(p => p.ImageUrl).HasMaxLength(500);
            builder.Property(p => p.MartialStatus).HasColumnType("bit");
            builder.Property(p=>p.Gender).HasConversion<string>().HasMaxLength(10).IsRequired();
            builder.Property(p => p.DrivingLicense).HasMaxLength(10).HasDefaultValue("Yok");
            builder.Property(p => p.BirthPlace).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Nationality).HasMaxLength(50).IsRequired().HasDefaultValue("Türkiye");



        }
    }
}
