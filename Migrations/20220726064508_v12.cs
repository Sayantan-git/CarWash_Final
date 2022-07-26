using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWashApi.Migrations
{
    public partial class v12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserType",
                table: "UserProfiles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "UserProfiles",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
