using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarWashApi.Migrations
{
    public partial class Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Cars_CarId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Packages_PackageId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_UserProfiles_CustId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AddressId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CarId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PackageId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PackageId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Instructions",
                table: "Orders",
                newName: "instructions");

            migrationBuilder.RenameColumn(
                name: "PaymentStatus",
                table: "Orders",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "IsScheduledLater",
                table: "Orders",
                newName: "regNumber");

            migrationBuilder.AddColumn<string>(
                name: "PkgName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "date",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "pinCode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "pkgDescription",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "price",
                table: "Orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PkgName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "address",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "date",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "pinCode",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "pkgDescription",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "instructions",
                table: "Orders",
                newName: "Instructions");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Orders",
                newName: "PaymentStatus");

            migrationBuilder.RenameColumn(
                name: "regNumber",
                table: "Orders",
                newName: "IsScheduledLater");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PackageId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCost",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CarId",
                table: "Orders",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustId",
                table: "Orders",
                column: "CustId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PackageId",
                table: "Orders",
                column: "PackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Cars_CarId",
                table: "Orders",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Packages_PackageId",
                table: "Orders",
                column: "PackageId",
                principalTable: "Packages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_UserProfiles_CustId",
                table: "Orders",
                column: "CustId",
                principalTable: "UserProfiles",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
