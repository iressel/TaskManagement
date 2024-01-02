using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Changing_Surname_To_Lastname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Employees",
                newName: "Lastname");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("0411c24b-94ed-4a5f-9ffb-361867eba6ac"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("05a50481-aa73-4190-a5b7-9755436029d2"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("2f02d124-6926-49d8-ac0a-fbe50502b6e1"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8711cd61-e600-48a3-bc33-71645c9523dd"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("0473df39-6a32-45c9-bb6c-67949f03cf2b"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("0a5dc042-a7b9-4f95-83bc-3f5d7930a12e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("2b6eb53e-4356-4c99-ac92-e56b578c98c4"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("4c4eab77-e0e2-4686-b991-d0c610e1066e"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("889c48d4-8010-4e06-949d-413d3dab4e06"));

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: new Guid("a8575100-a6ae-4f36-84be-5f3516c29b60"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0b647439-c2a2-4ade-a880-61cf4da91a47"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("35e4951b-6dde-4131-9dae-9554bba3a275"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4e478fc7-a10e-4ef1-907b-f7cd5cdcb748"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("59247211-fdcf-4ac1-959d-1403e2340439"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("d52369ec-b118-425d-887a-b708e09e940b"));

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Employees",
                newName: "Surname");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "createdby", "createddate", "isdeleted", "Name", "updatedby", "updateddate" },
                values: new object[,]
                {
                    { new Guid("1652d695-5e40-4c97-bd4f-12c6b0d2e9b6"), "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6330), "0", "DBA", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6333) },
                    { new Guid("1adb17aa-7db1-460e-8f69-44579d953ce3"), "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6121), "0", "PAM", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6140) }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CellPhone", "createdby", "createddate", "CuitCuil", "DateOfBirth", "DepartmentId", "DocumentNumber", "Email", "EnrollmentDate", "isdeleted", "Legajo", "Name", "NationalityId", "Phone", "Position", "Status", "Surname", "updatedby", "updateddate" },
                values: new object[,]
                {
                    { new Guid("06123412-36eb-43d7-b21b-a0ef4b41b810"), null, "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6348), null, new DateTime(1991, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1652d695-5e40-4c97-bd4f-12c6b0d2e9b6"), "36185222", "g.prado@ptytechnologies.com", new DateTime(2020, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", null, "GONZALO", null, null, null, null, "PRADO", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6350) },
                    { new Guid("506cf03a-0144-4c8c-83b7-178578c7f463"), null, "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6187), null, new DateTime(1991, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1adb17aa-7db1-460e-8f69-44579d953ce3"), "36192398", "i.ressel@ptytechnologies.com", new DateTime(2022, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", null, "ISMAIN", null, null, null, null, "RESSEL", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6191) },
                    { new Guid("9c126fe9-77bf-43d1-a91a-5c8a8e1ffb05"), null, "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6380), null, new DateTime(1994, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1652d695-5e40-4c97-bd4f-12c6b0d2e9b6"), "38111222", "c.guelpa@ptytechnologies.com", new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "0", null, "CARLA", null, null, null, null, "GUELPA", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6381) }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressNumber", "City", "Country", "createdby", "createddate", "DepartmentLetter", "DepartmentNumber", "DetailedAddress", "EmployeeId", "isdeleted", "IsOnTheGroundFloor", "State", "Street", "updatedby", "updateddate", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("11c7d99a-f09a-4497-8b2a-6844ac88ab25"), "225", "Carmen de Patagones", "Argentina", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6236), null, null, "Harosteguy 225, Casa", new Guid("506cf03a-0144-4c8c-83b7-178578c7f463"), "0", true, "BA", "Harosteguy", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6237), "8504" },
                    { new Guid("33014007-9025-4275-bdb3-90965ffe3c49"), "1440", "La Plata", "Argentina", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6216), "A", "2", "Calle 16 1440 e/ 61 y 62 2A", new Guid("506cf03a-0144-4c8c-83b7-178578c7f463"), "0", false, "BA", "16", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6217), "1900" },
                    { new Guid("4a8c10ad-39ad-416d-8c3b-040bc4aab405"), "442", "Buenos Aires", "Argentina", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6393), "B", "7", "Alem 442 7B", new Guid("9c126fe9-77bf-43d1-a91a-5c8a8e1ffb05"), "0", false, "BA", "ALEM", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6394), "B1228" },
                    { new Guid("af04a8b0-3ffb-4020-b6f1-c7190409ec67"), "1953", "Mendoza", "Argentina", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6365), null, null, "Perón 1953, casa", new Guid("06123412-36eb-43d7-b21b-a0ef4b41b810"), "0", true, "MZA", "Perón", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6366), "M5500" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "createdby", "createddate", "DeliveryDate", "Description", "EmployeeId", "isdeleted", "Status", "Title", "updatedby", "updateddate" },
                values: new object[,]
                {
                    { new Guid("47b389d5-36c7-47b5-8d18-529cac33a669"), "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6434), new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soporte a PSS", new Guid("9c126fe9-77bf-43d1-a91a-5c8a8e1ffb05"), "0", 5, "DBA-3", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6435) },
                    { new Guid("8acdc7ab-6493-45f7-a0c0-a357e90a9312"), "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6451), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soporte a PSS", new Guid("9c126fe9-77bf-43d1-a91a-5c8a8e1ffb05"), "0", 1, "DBA-4", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6452) },
                    { new Guid("90fb2cf2-c68c-4d4f-b075-3c4507d5dae1"), "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6258), new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Implementar Customer Emails", new Guid("506cf03a-0144-4c8c-83b7-178578c7f463"), "0", 5, "PSS-1", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6259) },
                    { new Guid("b04c7065-78f1-4fe8-8ff6-332f4dd66766"), "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6421), new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soporte a Cashier", new Guid("06123412-36eb-43d7-b21b-a0ef4b41b810"), "0", 1, "DBA-2", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6423) },
                    { new Guid("b59c5fea-6ca6-43ac-ab62-22cf22787e40"), "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6408), new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soporte a PSS", new Guid("06123412-36eb-43d7-b21b-a0ef4b41b810"), "0", 5, "DBA-1", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6409) },
                    { new Guid("c81e53d2-c871-4be5-95fc-90d5c6a3c327"), "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6274), new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explicar EF", new Guid("506cf03a-0144-4c8c-83b7-178578c7f463"), "0", 1, "PSS-2", "iressel", new DateTime(2023, 12, 21, 14, 41, 6, 244, DateTimeKind.Local).AddTicks(6275) }
                });
        }
    }
}
