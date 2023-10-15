﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NWCProject;

#nullable disable

namespace NWCProject.Models.Migrations
{
    [DbContext(typeof(NwcDbContext))]
    [Migration("20230716063115_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NWC_Rreal_Estate_TypesNWC_Subscriber_File", b =>
                {
                    b.Property<string>("SubscibersId")
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Units_TypeCode")
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("SubscibersId", "Units_TypeCode");

                    b.HasIndex("Units_TypeCode");

                    b.ToTable("NWC_Rreal_Estate_TypesNWC_Subscriber_File");
                });

            modelBuilder.Entity("NWCProject.Models.NWC_Default_Slice_Values", b =>
                {
                    b.Property<string>("Slice_Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("Amount_of_Consumption")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<string>("Reasons")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Sanitation_Price")
                        .HasMaxLength(6)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Slice_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Water_Price")
                        .HasMaxLength(6)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Slice_Code");

                    b.ToTable("nWC_Default_Slice_Values");
                });

            modelBuilder.Entity("NWCProject.Models.NWC_Invoices", b =>
                {
                    b.Property<string>("Invoice_Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("Amount_Consumption")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("Current_Consumption_Amount")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<string>("Estate_Types_Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Invoice_Year")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<DateTime>("Invoices_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Invoices_From")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Invoices_To")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Is_There_Sanitaion")
                        .HasColumnType("bit");

                    b.Property<int>("Previous_Consumption_Amount")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<decimal>("Service_Fee")
                        .HasMaxLength(10)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Subscriber_Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Subscription_No")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<decimal>("Tax_Rate")
                        .HasMaxLength(10)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Tax_Value")
                        .HasMaxLength(10)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total_Bill")
                        .HasMaxLength(10)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total_Invoice")
                        .HasMaxLength(10)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Total_Reasons")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Wastewater_Consumption_Value")
                        .HasMaxLength(10)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Water_Consumption_Value")
                        .HasMaxLength(10)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Invoice_Number");

                    b.HasIndex("Estate_Types_Code")
                        .IsUnique();

                    b.HasIndex("Subscriber_Code");

                    b.HasIndex("Subscription_No")
                        .IsUnique();

                    b.ToTable("NWC_Invoices");
                });

            modelBuilder.Entity("NWCProject.Models.NWC_Rreal_Estate_Types", b =>
                {
                    b.Property<string>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Reasons")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Code");

                    b.ToTable("nWC_Rreal_Estate_Types");

                    b.HasData(
                        new
                        {
                            Code = "1",
                            Name = "Home",
                            Reasons = ""
                        },
                        new
                        {
                            Code = "2",
                            Name = "Villa",
                            Reasons = ""
                        },
                        new
                        {
                            Code = "3",
                            Name = "palace",
                            Reasons = ""
                        },
                        new
                        {
                            Code = "4",
                            Name = "builder",
                            Reasons = ""
                        },
                        new
                        {
                            Code = "5",
                            Name = "Farm",
                            Reasons = ""
                        },
                        new
                        {
                            Code = "6",
                            Name = "Warehouse",
                            Reasons = ""
                        },
                        new
                        {
                            Code = "7",
                            Name = "Chalet",
                            Reasons = ""
                        },
                        new
                        {
                            Code = "8",
                            Name = "Estraha",
                            Reasons = ""
                        });
                });

            modelBuilder.Entity("NWCProject.Models.NWC_Subscriber_File", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Resons")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("nWC_Subscriber_Files");
                });

            modelBuilder.Entity("NWCProject.Models.NWC_Subscription_File", b =>
                {
                    b.Property<string>("Subscription_File_No")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(1)");

                    b.Property<bool>("Is_There_Sanitaion")
                        .HasColumnType("bit");

                    b.Property<int>("Last_Reading_Meter")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Reasons")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SubscriberId")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("Unit_Number")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<string>("Unit_TypeCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("Subscription_File_No");

                    b.HasIndex("SubscriberId");

                    b.HasIndex("Unit_TypeCode");

                    b.ToTable("nWC_Subscription_Files");
                });

            modelBuilder.Entity("NWC_Rreal_Estate_TypesNWC_Subscriber_File", b =>
                {
                    b.HasOne("NWCProject.Models.NWC_Subscriber_File", null)
                        .WithMany()
                        .HasForeignKey("SubscibersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NWCProject.Models.NWC_Rreal_Estate_Types", null)
                        .WithMany()
                        .HasForeignKey("Units_TypeCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NWCProject.Models.NWC_Invoices", b =>
                {
                    b.HasOne("NWCProject.Models.NWC_Rreal_Estate_Types", "Units_Types")
                        .WithOne("Invoice")
                        .HasForeignKey("NWCProject.Models.NWC_Invoices", "Estate_Types_Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NWCProject.Models.NWC_Subscriber_File", "Subscribers")
                        .WithMany("Invoice")
                        .HasForeignKey("Subscriber_Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NWCProject.Models.NWC_Subscription_File", "subscriptions")
                        .WithOne("invoices")
                        .HasForeignKey("NWCProject.Models.NWC_Invoices", "Subscription_No")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subscribers");

                    b.Navigation("Units_Types");

                    b.Navigation("subscriptions");
                });

            modelBuilder.Entity("NWCProject.Models.NWC_Subscription_File", b =>
                {
                    b.HasOne("NWCProject.Models.NWC_Subscriber_File", "subscriber")
                        .WithMany()
                        .HasForeignKey("SubscriberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NWCProject.Models.NWC_Rreal_Estate_Types", "Unit_Type")
                        .WithMany()
                        .HasForeignKey("Unit_TypeCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Unit_Type");

                    b.Navigation("subscriber");
                });

            modelBuilder.Entity("NWCProject.Models.NWC_Rreal_Estate_Types", b =>
                {
                    b.Navigation("Invoice")
                        .IsRequired();
                });

            modelBuilder.Entity("NWCProject.Models.NWC_Subscriber_File", b =>
                {
                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("NWCProject.Models.NWC_Subscription_File", b =>
                {
                    b.Navigation("invoices")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}