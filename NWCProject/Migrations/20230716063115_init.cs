using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NWCProject.Models.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "nWC_Default_Slice_Values",
                columns: table => new
                {
                    Slice_Code = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Slice_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Water_Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 6, nullable: false),
                    Amount_of_Consumption = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    Sanitation_Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 6, nullable: false),
                    Reasons = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nWC_Default_Slice_Values", x => x.Slice_Code);
                });

            migrationBuilder.CreateTable(
                name: "nWC_Rreal_Estate_Types",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Reasons = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nWC_Rreal_Estate_Types", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "nWC_Subscriber_Files",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Area = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Resons = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nWC_Subscriber_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NWC_Rreal_Estate_TypesNWC_Subscriber_File",
                columns: table => new
                {
                    SubscibersId = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Units_TypeCode = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NWC_Rreal_Estate_TypesNWC_Subscriber_File", x => new { x.SubscibersId, x.Units_TypeCode });
                    table.ForeignKey(
                        name: "FK_NWC_Rreal_Estate_TypesNWC_Subscriber_File_nWC_Rreal_Estate_Types_Units_TypeCode",
                        column: x => x.Units_TypeCode,
                        principalTable: "nWC_Rreal_Estate_Types",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NWC_Rreal_Estate_TypesNWC_Subscriber_File_nWC_Subscriber_Files_SubscibersId",
                        column: x => x.SubscibersId,
                        principalTable: "nWC_Subscriber_Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nWC_Subscription_Files",
                columns: table => new
                {
                    Subscription_File_No = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Unit_TypeCode = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    SubscriberId = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Unit_Number = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Is_There_Sanitaion = table.Column<bool>(type: "bit", nullable: false),
                    Last_Reading_Meter = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Reasons = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nWC_Subscription_Files", x => x.Subscription_File_No);
                    table.ForeignKey(
                        name: "FK_nWC_Subscription_Files_nWC_Rreal_Estate_Types_Unit_TypeCode",
                        column: x => x.Unit_TypeCode,
                        principalTable: "nWC_Rreal_Estate_Types",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_nWC_Subscription_Files_nWC_Subscriber_Files_SubscriberId",
                        column: x => x.SubscriberId,
                        principalTable: "nWC_Subscriber_Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NWC_Invoices",
                columns: table => new
                {
                    Invoice_Number = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Subscriber_Code = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Estate_Types_Code = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Subscription_No = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Invoice_Year = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    Invoices_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Invoices_From = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Invoices_To = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Previous_Consumption_Amount = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Current_Consumption_Amount = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Service_Fee = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    Tax_Rate = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    Is_There_Sanitaion = table.Column<bool>(type: "bit", nullable: false),
                    Amount_Consumption = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Water_Consumption_Value = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    Wastewater_Consumption_Value = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    Total_Invoice = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    Tax_Value = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    Total_Bill = table.Column<decimal>(type: "decimal(18,2)", maxLength: 10, nullable: false),
                    Total_Reasons = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NWC_Invoices", x => x.Invoice_Number);
                    table.ForeignKey(
                        name: "FK_NWC_Invoices_nWC_Rreal_Estate_Types_Estate_Types_Code",
                        column: x => x.Estate_Types_Code,
                        principalTable: "nWC_Rreal_Estate_Types",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NWC_Invoices_nWC_Subscriber_Files_Subscriber_Code",
                        column: x => x.Subscriber_Code,
                        principalTable: "nWC_Subscriber_Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NWC_Invoices_nWC_Subscription_Files_Subscription_No",
                        column: x => x.Subscription_No,
                        principalTable: "nWC_Subscription_Files",
                        principalColumn: "Subscription_File_No",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "nWC_Rreal_Estate_Types",
                columns: new[] { "Code", "Name", "Reasons" },
                values: new object[,]
                {
                    { "1", "Home", "" },
                    { "2", "Villa", "" },
                    { "3", "palace", "" },
                    { "4", "builder", "" },
                    { "5", "Farm", "" },
                    { "6", "Warehouse", "" },
                    { "7", "Chalet", "" },
                    { "8", "Estraha", "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NWC_Invoices_Estate_Types_Code",
                table: "NWC_Invoices",
                column: "Estate_Types_Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NWC_Invoices_Subscriber_Code",
                table: "NWC_Invoices",
                column: "Subscriber_Code");

            migrationBuilder.CreateIndex(
                name: "IX_NWC_Invoices_Subscription_No",
                table: "NWC_Invoices",
                column: "Subscription_No",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NWC_Rreal_Estate_TypesNWC_Subscriber_File_Units_TypeCode",
                table: "NWC_Rreal_Estate_TypesNWC_Subscriber_File",
                column: "Units_TypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_nWC_Subscription_Files_SubscriberId",
                table: "nWC_Subscription_Files",
                column: "SubscriberId");

            migrationBuilder.CreateIndex(
                name: "IX_nWC_Subscription_Files_Unit_TypeCode",
                table: "nWC_Subscription_Files",
                column: "Unit_TypeCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "nWC_Default_Slice_Values");

            migrationBuilder.DropTable(
                name: "NWC_Invoices");

            migrationBuilder.DropTable(
                name: "NWC_Rreal_Estate_TypesNWC_Subscriber_File");

            migrationBuilder.DropTable(
                name: "nWC_Subscription_Files");

            migrationBuilder.DropTable(
                name: "nWC_Rreal_Estate_Types");

            migrationBuilder.DropTable(
                name: "nWC_Subscriber_Files");
        }
    }
}
