using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StaffPortalAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class NamePropDebug2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName_Value",
                table: "TestCustomers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName_Value",
                table: "TestCustomers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name_Value",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName_Value",
                table: "TestCustomers");

            migrationBuilder.DropColumn(
                name: "LastName_Value",
                table: "TestCustomers");

            migrationBuilder.DropColumn(
                name: "Name_Value",
                table: "Products");
        }
    }
}
