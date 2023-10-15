using Microsoft.EntityFrameworkCore;
using NWCProject.Models;

namespace NWCProject
{
    public class NwcDbContext :DbContext
    {
        public NwcDbContext(DbContextOptions<NwcDbContext> optionsBuilder):base(optionsBuilder)
        {
            
        }

        public NwcDbContext()
        {
            
        }
        public DbSet<NWC_Rreal_Estate_Types>? nWC_Rreal_Estate_Types { get; set; }
        public DbSet<NWC_Invoices>? NWC_Invoices { get; set; }
        public DbSet<NWC_Subscriber_File>? nWC_Subscriber_Files { get; set; }
        public DbSet<NWC_Subscription_File>? nWC_Subscription_Files { get; set; }
        public DbSet<NWC_Default_Slice_Values>? nWC_Default_Slice_Values { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ConfigurationEstateTypes().Configure(modelBuilder.Entity<NWC_Rreal_Estate_Types>());
            new SubscriptionConfiguration().Configure(modelBuilder.Entity<NWC_Subscription_File>());
            new SubscriberConfiguration().Configure(modelBuilder.Entity<NWC_Subscriber_File>());
            new InvoiceConfiguration().Configure(modelBuilder.Entity<NWC_Invoices>());
            new SliceConfiguration().Configure(modelBuilder.Entity<NWC_Default_Slice_Values>());
            modelBuilder.Entity<NWC_Subscriber_File>().HasMany(i => i.Invoice).WithOne(i => i.Subscribers).HasForeignKey(i=>i.Subscriber_Code);
            modelBuilder.Entity<NWC_Invoices>().HasOne(i => i.subscriptions).WithOne(i => i.invoices).HasForeignKey<NWC_Invoices>(i => i.Subscription_No);
            modelBuilder.Entity<NWC_Invoices>().HasOne(i => i.Units_Types).WithOne(i => i.Invoice).HasForeignKey<NWC_Invoices>(i => i.Estate_Types_Code);

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

    }
}