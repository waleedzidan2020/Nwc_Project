using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.Models
{
    public class SubscriberConfiguration : IEntityTypeConfiguration<NWC_Subscriber_File>
    {
        public void Configure(EntityTypeBuilder<NWC_Subscriber_File> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Name).HasMaxLength(100).IsRequired();
            builder.Property(i => i.City).HasMaxLength(50).IsRequired();
            builder.Property(i => i.Area).HasMaxLength(50).IsRequired();
            builder.Property(i => i.Mobile).HasMaxLength(20).IsRequired();
        }
    }
}
