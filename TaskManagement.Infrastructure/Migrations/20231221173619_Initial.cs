using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Flgeli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdby = table.Column<string>(type: "varchar(100)", nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedby = table.Column<string>(type: "varchar(100)", nullable: false),
                    updateddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isdeleted = table.Column<string>(type: "varchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    createdby = table.Column<string>(type: "varchar(100)", nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedby = table.Column<string>(type: "varchar(100)", nullable: false),
                    updateddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isdeleted = table.Column<string>(type: "varchar(1)", nullable: false),
                    Name = table.Column<string>(type: "varchar(150)", nullable: true),
                    Surname = table.Column<string>(type: "varchar(150)", nullable: true),
                    Legajo = table.Column<string>(type: "varchar(20)", nullable: true),
                    DocumentNumber = table.Column<string>(type: "varchar(10)", nullable: true),
                    CuitCuil = table.Column<string>(type: "varchar(20)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NationalityId = table.Column<int>(type: "int", nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", nullable: true),
                    CellPhone = table.Column<string>(type: "varchar(20)", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", nullable: true),
                    EnrollmentDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsOnTheGroundFloor = table.Column<bool>(type: "bit", nullable: true),
                    DepartmentNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentLetter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetailedAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    createdby = table.Column<string>(type: "varchar(100)", nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedby = table.Column<string>(type: "varchar(100)", nullable: false),
                    updateddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isdeleted = table.Column<string>(type: "varchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    createdby = table.Column<string>(type: "varchar(100)", nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedby = table.Column<string>(type: "varchar(100)", nullable: false),
                    updateddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isdeleted = table.Column<string>(type: "varchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    createdby = table.Column<string>(type: "varchar(100)", nullable: false),
                    createddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updatedby = table.Column<string>(type: "varchar(100)", nullable: false),
                    updateddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isdeleted = table.Column<string>(type: "varchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_EmployeeId",
                table: "Addresses",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TicketId",
                table: "Comments",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EmployeeId",
                table: "Tickets",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
