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
    internal class SkillConfiguraiton : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.Property(s => s.Title).HasMaxLength(50).IsRequired();
            builder.Property(s => s.Icon).HasMaxLength(30).IsRequired();
            builder.Property(s => s.IsProgramLanguageAndTools)
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
