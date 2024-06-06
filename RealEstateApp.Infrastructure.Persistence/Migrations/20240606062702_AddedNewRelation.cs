using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateApp.Infrastructure.Persistence.Migrations
{
    public partial class AddedNewRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnnouncementId",
                schema: "dbo",
                table: "Properties",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_AnnouncementId",
                schema: "dbo",
                table: "Properties",
                column: "AnnouncementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Properties_Announcements_AnnouncementId",
                schema: "dbo",
                table: "Properties",
                column: "AnnouncementId",
                principalSchema: "dbo",
                principalTable: "Announcements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Properties_Announcements_AnnouncementId",
                schema: "dbo",
                table: "Properties");

            migrationBuilder.DropIndex(
                name: "IX_Properties_AnnouncementId",
                schema: "dbo",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "AnnouncementId",
                schema: "dbo",
                table: "Properties");
        }
    }
}
