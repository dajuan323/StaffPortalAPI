using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StaffPortalAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class tokenLayer2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "IsActive", "LastName" },
                values: new object[,]
                {
                    { new Guid("01fbf862-f4a6-47f4-988d-a85c639e5149"), "ws@cust.com", "Will", true, "Smith" },
                    { new Guid("03e2bb33-498d-4a2e-bf1c-365a87ec2f92"), "mm@cust.com", "Mike", true, "Meyers" },
                    { new Guid("1c670d26-7bfa-4166-b8a6-e4cb553276a8"), "pb@cust.com", "Porscha", true, "Brooks" },
                    { new Guid("25e5d007-f9b6-4995-a956-f1d02d523e68"), "ja@cust.com", "Alex", true, "Jones" },
                    { new Guid("45d83057-4e05-4760-912f-c8c6cea2412a"), "jv@cust.com", "Jason", true, "Voorhees" },
                    { new Guid("56026187-1fe2-4226-b0ad-e79400b4b135"), "at@cust.com", "Amy", true, "Tanner" },
                    { new Guid("af66a506-e063-436c-83e2-977d5a9738f2"), "jw@cust.com", "Jason", true, "Wilson" },
                    { new Guid("b1dfb958-bcc4-4851-b6c3-3771da76d3f1"), "fk@cust.com", "Frederick", true, "Kruger" },
                    { new Guid("c8632c45-3092-46d7-b505-4b72e92a4568"), "gh@cust.com", "Gerald", true, "Heathcliff" },
                    { new Guid("cdd1637d-ab61-460c-8ea9-d0ff76b97823"), "re@cust.com", "Roberto", true, "Elizando" },
                    { new Guid("fbce3708-22d1-4a05-8738-fc1199b0c1be"), "ai@cust.com", "Allen", true, "Iverson" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("01fbf862-f4a6-47f4-988d-a85c639e5149"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("03e2bb33-498d-4a2e-bf1c-365a87ec2f92"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("1c670d26-7bfa-4166-b8a6-e4cb553276a8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("25e5d007-f9b6-4995-a956-f1d02d523e68"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("45d83057-4e05-4760-912f-c8c6cea2412a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("56026187-1fe2-4226-b0ad-e79400b4b135"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("af66a506-e063-436c-83e2-977d5a9738f2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("b1dfb958-bcc4-4851-b6c3-3771da76d3f1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c8632c45-3092-46d7-b505-4b72e92a4568"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("cdd1637d-ab61-460c-8ea9-d0ff76b97823"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("fbce3708-22d1-4a05-8738-fc1199b0c1be"));
        }
    }
}
