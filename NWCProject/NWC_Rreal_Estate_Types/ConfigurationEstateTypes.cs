using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWCProject.Models
{

    public class ConfigurationEstateTypes : IEntityTypeConfiguration<NWC_Rreal_Estate_Types>
    {
        public static List<NWC_Rreal_Estate_Types> Seed()
        {

            return new List<NWC_Rreal_Estate_Types>() {

            new NWC_Rreal_Estate_Types() {

             Code='1',
             Name="Home",

            },
            new NWC_Rreal_Estate_Types() {

             Code='2',
             Name="Villa",

            },new NWC_Rreal_Estate_Types() {

             Code='3',
             Name="palace",

            },new NWC_Rreal_Estate_Types() {

             Code='4',
             Name="builder",

            },new NWC_Rreal_Estate_Types() {

             Code='5',
             Name="Farm",

            },new NWC_Rreal_Estate_Types() {

             Code='6',
             Name="Warehouse",

            },new NWC_Rreal_Estate_Types() {

             Code='7',
             Name="Chalet",

            },
            new NWC_Rreal_Estate_Types() {

             Code='8',
             Name="Estraha",

            }
            };
        }
        public void Configure(EntityTypeBuilder<NWC_Rreal_Estate_Types> builder)
        {
            builder.HasKey(i => i.Code);
            builder.Property(i => i.Name).HasMaxLength(15).IsRequired();
            builder.Property(i => i.Reasons).HasMaxLength(100);
            builder.HasData(Seed());
        }
    }

}
