using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_Subtasks_To_Ticket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("88942c25-7165-4bfd-9cc1-3c88227035dd"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("9c45b55b-58f8-402a-8b35-93e22148e1c6"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("a9bfd441-b7cc-47b0-9064-63543e2ce478"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("aa789cd9-7c5e-4d8b-bcda-7d964a00442e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("284bccf2-a08f-49b5-b96f-df5f53affca4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("59713339-b293-43ac-98fe-1592dff9ffa8"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("7b0a97ab-abe2-49e4-81af-b4e9a03f167a"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("7dc684cc-d773-408b-a98b-57a192fbfd51"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("bf40bf09-0b6b-4e6d-9353-93d823e9dbc3"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("cef687c3-16f7-495a-b759-78e2d06571e5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("47bcc4af-9a09-4cb8-875f-0f3195a83ece"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("99c96d0d-5494-461b-9f3e-868e1d0476e1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("db4e1272-4529-4af8-8778-67ed387aa18f"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("04d46ab1-6a8c-472a-ae76-22f1317482ea"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ddb5b087-3378-463b-bb54-69685fc1c302"));

            migrationBuilder.CreateTable(
                name: "Subtasks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    createdby = table.Column<string>(type: "varchar(100)", nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedby = table.Column<string>(type: "varchar(100)", nullable: false),
                    updateddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isdeleted = table.Column<string>(type: "varchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subtasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subtasks_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Subtasks_TicketId",
                table: "Subtasks",
                column: "TicketId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subtasks");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "createdby", "createddate", "isdeleted", "Name", "updatedby", "updateddate" },
                values: new object[,]
                {
                    { new Guid("04d46ab1-6a8c-472a-ae76-22f1317482ea"), "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(892), "0", "PAM", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(911) },
                    { new Guid("ddb5b087-3378-463b-bb54-69685fc1c302"), "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1060), "0", "DBA", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1062) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CellPhone", "createdby", "createddate", "CuitCuil", "DateOfBirth", "DepartmentId", "DocumentNumber", "Email", "EnrollmentDate", "isdeleted", "Legajo", "Name", "NationalityId", "Phone", "Position", "Status", "Surname", "updatedby", "updateddate" },
                values: new object[,]
                {
                    { new Guid("47bcc4af-9a09-4cb8-875f-0f3195a83ece"), null, "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1073), null, new DateTime(1991, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddb5b087-3378-463b-bb54-69685fc1c302"), "36185222", "g.prado@ptytechnologies.com", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", null, "GONZALO", null, null, null, null, "PRADO", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1075) },
                    { new Guid("99c96d0d-5494-461b-9f3e-868e1d0476e1"), null, "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1101), null, new DateTime(1994, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ddb5b087-3378-463b-bb54-69685fc1c302"), "38111222", "c.guelpa@ptytechnologies.com", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", null, "CARLA", null, null, null, null, "GUELPA", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1103) },
                    { new Guid("db4e1272-4529-4af8-8778-67ed387aa18f"), null, "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(959), null, new DateTime(1991, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("04d46ab1-6a8c-472a-ae76-22f1317482ea"), "36192398", "i.ressel@ptytechnologies.com", new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", null, "ISMAIN", null, null, null, null, "RESSEL", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(964) }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressNumber", "City", "Country", "createdby", "createddate", "DepartmentLetter", "DepartmentNumber", "DetailedAddress", "EmployeeId", "isdeleted", "IsOnTheGroundFloor", "State", "Street", "updatedby", "updateddate", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("88942c25-7165-4bfd-9cc1-3c88227035dd"), "1440", "La Plata", "Argentina", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(995), "A", "2", "Calle 16 1440 e/ 61 y 62 2A", new Guid("db4e1272-4529-4af8-8778-67ed387aa18f"), "0", false, "BA", "16", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(996), "1900" },
                    { new Guid("9c45b55b-58f8-402a-8b35-93e22148e1c6"), "442", "Buenos Aires", "Argentina", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1117), "B", "7", "Alem 442 7B", new Guid("99c96d0d-5494-461b-9f3e-868e1d0476e1"), "0", false, "BA", "ALEM", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1118), "B1228" },
                    { new Guid("a9bfd441-b7cc-47b0-9064-63543e2ce478"), "1953", "Mendoza", "Argentina", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1088), null, null, "Perón 1953, casa", new Guid("47bcc4af-9a09-4cb8-875f-0f3195a83ece"), "0", true, "MZA", "Perón", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1089), "M5500" },
                    { new Guid("aa789cd9-7c5e-4d8b-bcda-7d964a00442e"), "225", "Carmen de Patagones", "Argentina", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1016), null, null, "Harosteguy 225, Casa", new Guid("db4e1272-4529-4af8-8778-67ed387aa18f"), "0", true, "BA", "Harosteguy", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1017), "8504" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "createdby", "createddate", "DeliveryDate", "Description", "EmployeeId", "isdeleted", "Status", "Title", "updatedby", "updateddate" },
                values: new object[,]
                {
                    { new Guid("284bccf2-a08f-49b5-b96f-df5f53affca4"), "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1047), new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explicar EF", new Guid("db4e1272-4529-4af8-8778-67ed387aa18f"), "0", 1, "PSS-2", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1048) },
                    { new Guid("59713339-b293-43ac-98fe-1592dff9ffa8"), "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1213), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soporte a PSS", new Guid("99c96d0d-5494-461b-9f3e-868e1d0476e1"), "0", 1, "DBA-4", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1214) },
                    { new Guid("7b0a97ab-abe2-49e4-81af-b4e9a03f167a"), "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1033), new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Implementar Customer Emails", new Guid("db4e1272-4529-4af8-8778-67ed387aa18f"), "0", 5, "PSS-1", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1034) },
                    { new Guid("7dc684cc-d773-408b-a98b-57a192fbfd51"), "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1130), new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soporte a PSS", new Guid("47bcc4af-9a09-4cb8-875f-0f3195a83ece"), "0", 5, "DBA-1", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1131) },
                    { new Guid("bf40bf09-0b6b-4e6d-9353-93d823e9dbc3"), "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1154), new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soporte a PSS", new Guid("99c96d0d-5494-461b-9f3e-868e1d0476e1"), "0", 5, "DBA-3", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1155) },
                    { new Guid("cef687c3-16f7-495a-b759-78e2d06571e5"), "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1143), new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soporte a Cashier", new Guid("47bcc4af-9a09-4cb8-875f-0f3195a83ece"), "0", 1, "DBA-2", "iressel", new DateTime(2023, 12, 21, 14, 36, 19, 42, DateTimeKind.Local).AddTicks(1144) }
                });
        }
    }
}
