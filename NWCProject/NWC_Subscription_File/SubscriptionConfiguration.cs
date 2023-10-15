using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.Models
{
    public class SubscriptionConfiguration : IEntityTypeConfiguration<NWC_Subscription_File>
    {
        public void Configure(EntityTypeBuilder<NWC_Subscription_File> builder)
        {
            builder.HasKey(i => i.Subscription_File_No);
            //builder.Property(i => i.Estate_Types_Code).HasMaxLength(1).IsRequired();
            //builder.Property(i => i.Subscriber_Code).HasMaxLength(10).IsRequired();
  
            builder.Property(i => i.Unit_Number).HasMaxLength(2).IsRequired();
            builder.Property(i => i.Last_Reading_Meter).HasMaxLength(10).IsRequired();
            builder.Property(i => i.Reasons).HasMaxLength(100);


        }
    }
}
