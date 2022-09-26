using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K220_Abstrak.Migrations
{
    public partial class addedIsDeletedPropToBaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ServicesSections",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "MainSections",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ServicesSections");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "MainSections");
        }
    }
}
