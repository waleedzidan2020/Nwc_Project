using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.Models
{
    public class SliceConfiguration : IEntityTypeConfiguration<NWC_Default_Slice_Values>
    {
        public void Configure(EntityTypeBuilder<NWC_Default_Slice_Values> builder)
        {
            builder.HasKey(i => i.Slice_Code);
            builder.Property(i => i.Slice_Name).HasMaxLength(50).IsRequired();
            builder.Property(i => i.Sanitation_Price).HasMaxLength(6).IsRequired();
            builder.Property(i => i.Water_Price).HasMaxLength(6).IsRequired();
            builder.Property(i => i.Reasons).HasMaxLength(100);
            builder.Property(i => i.Amount_of_Consumption).HasMaxLength(3).IsRequired();
        }
    }
}
