using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWashApi.Migrations
{
    public partial class v11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Washers_WasherId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Washers");

            migrationBuilder.DropIndex(
                name: "IX_Orders_WasherId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "WasherId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "UserAddress",
                table: "UserProfiles",
                newName: "UserType");

            migrationBuilder.RenameColumn(
                name: "AdminUsername",
                table: "Admins",
                newName: "AdminEmail");

            migrationBuilder.AddColumn<byte[]>(
                name: "UserPasswordHash",
                table: "UserProfiles",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "UserPasswordSalt",
                table: "UserProfiles",
                type: "varbinary(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserPasswordHash",
                table: "UserProfiles");

            migrationBuilder.DropColumn(
                name: "UserPasswordSalt",
                table: "UserProfiles");

            migrationBuilder.RenameColumn(
                name: "UserType",
                table: "UserProfiles",
                newName: "UserAddress");

            migrationBuilder.RenameColumn(
                name: "AdminEmail",
                table: "Admins",
                newName: "AdminUsername");

            migrationBuilder.AddColumn<int>(
                name: "WasherId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Washers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfWashes = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Washers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_WasherId",
                table: "Orders",
                column: "WasherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Washers_WasherId",
                table: "Orders",
                column: "WasherId",
                principalTable: "Washers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
