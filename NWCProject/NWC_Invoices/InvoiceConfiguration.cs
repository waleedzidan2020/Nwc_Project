using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.Models
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<NWC_Invoices>
    {
        public void Configure(EntityTypeBuilder<NWC_Invoices> builder)
        {
            builder.HasKey(i => i.Invoice_Number);
            builder.Property(i => i.Invoice_Year).HasMaxLength(2).IsRequired();
            
            builder.Property(i => i.Previous_Consumption_Amount).HasMaxLength(2).IsRequired();
            builder.Property(i => i.Current_Consumption_Amount).HasMaxLength(2).IsRequired();
            builder.Property(i => i.Amount_Consumption).HasMaxLength(10).IsRequired();
            builder.Property(i => i.Service_Fee).HasMaxLength(10).IsRequired();
            builder.Property(i => i.Tax_Rate).HasMaxLength(10).IsRequired();
            builder.Property(i => i.Wastewater_Consumption_Value).HasMaxLength(10).IsRequired();
            builder.Property(i => i.Water_Consumption_Value).HasMaxLength(10).IsRequired();
            builder.Property(i => i.Total_Invoice).HasMaxLength(10).IsRequired();
            builder.Property(i => i.Tax_Value).HasMaxLength(10).IsRequired();
            builder.Property(i => i.Total_Bill).HasMaxLength(10).IsRequired();
            builder.Property(i => i.Total_Reasons).HasMaxLength(100);

        }
    }
}
