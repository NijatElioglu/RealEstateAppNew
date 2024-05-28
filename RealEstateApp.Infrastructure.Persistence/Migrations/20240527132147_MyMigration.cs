using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateApp.Infrastructure.Persistence.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_TypeOfSales_TypeOfPropertyId",
                table: "Properties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertiesImprovements",
                table: "PropertiesImprovements");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PropertiesImprovements",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETUTCDATE()");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PropertiesImprovements",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "PropertiesImprovements",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PropertiesImprovements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "PropertiesImprovements",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "PropertiesImprovements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AgentsId",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertiesImprovements",
                table: "PropertiesImprovements",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfProperties = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImprovementsProperties",
                columns: table => new
                {
                    ImprovementsId = table.Column<int>(type: "int", nullable: false),
                    PropertiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImprovementsProperties", x => new { x.ImprovementsId, x.PropertiesId });
                    table.ForeignKey(
                        name: "FK_ImprovementsProperties_Improvements_ImprovementsId",
                        column: x => x.ImprovementsId,
                        principalTable: "Improvements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ImprovementsProperties_Properties_PropertiesId",
                        column: x => x.PropertiesId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PropertiesImprovements_PropertyId",
                table: "PropertiesImprovements",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_AgentsId",
                table: "Properties",
                column: "AgentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_TypeOfSaleId",
                table: "Properties",
                column: "TypeOfSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_ImprovementsProperties_PropertiesId",
                table: "ImprovementsProperties",
                column: "PropertiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Agents_AgentsId",
                table: "Properties",
                column: "AgentsId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_TypeOfSales_TypeOfSaleId",
                table: "Properties",
                column: "TypeOfSaleId",
                principalTable: "TypeOfSales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Agents_AgentsId",
                table: "Properties");

            migrationBuilder.DropForeignKey(
                name: "FK_Properties_TypeOfSales_TypeOfSaleId",
                table: "Properties");

            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "ImprovementsProperties");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PropertiesImprovements",
                table: "PropertiesImprovements");

            migrationBuilder.DropIndex(
                name: "IX_PropertiesImprovements_PropertyId",
                table: "PropertiesImprovements");

            migrationBuilder.DropIndex(
                name: "IX_Properties_AgentsId",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_TypeOfSaleId",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PropertiesImprovements");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "PropertiesImprovements");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PropertiesImprovements");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "PropertiesImprovements");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "PropertiesImprovements");

            migrationBuilder.DropColumn(
                name: "AgentsId",
                table: "Properties");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "PropertiesImprovements",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETUTCDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PropertiesImprovements",
                table: "PropertiesImprovements",
                columns: new[] { "PropertyId", "ImprovementId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_TypeOfSales_TypeOfPropertyId",
                table: "Properties",
                column: "TypeOfPropertyId",
                principalTable: "TypeOfSales",
                principalColumn: "Id");
        }
    }
}
