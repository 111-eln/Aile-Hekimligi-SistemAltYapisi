using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AileHekimlikSistemi.Repository.Migrations
{
    public partial class hekimlikSistemDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalId = table.Column<int>(type: "int", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    updatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hospitals",
                columns: new[] { "Id", "HospitalName", "createdDate", "updatedDate" },
                values: new object[,]
                {
                    { 1, "ist. hastanesi", new DateTime(2024, 1, 9, 19, 44, 39, 774, DateTimeKind.Local).AddTicks(2351), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "ankara. hastanesi", new DateTime(2024, 1, 9, 19, 44, 39, 774, DateTimeKind.Local).AddTicks(2352), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "İzmir. hastanesi", new DateTime(2024, 1, 9, 19, 44, 39, 774, DateTimeKind.Local).AddTicks(2353), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Bursa. hastanesi", new DateTime(2024, 1, 9, 19, 44, 39, 774, DateTimeKind.Local).AddTicks(2354), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "HospitalId", "Name", "Surname", "createdDate", "updatedDate" },
                values: new object[,]
                {
                    { 1, 1, "eln1", "akk1", new DateTime(2024, 1, 9, 19, 44, 39, 774, DateTimeKind.Local).AddTicks(2175), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, "eln2", "akk2", new DateTime(2024, 1, 9, 19, 44, 39, 774, DateTimeKind.Local).AddTicks(2186), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, "eln3", "akk3", new DateTime(2024, 1, 9, 19, 44, 39, 774, DateTimeKind.Local).AddTicks(2187), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, "eln4", "akk4", new DateTime(2024, 1, 9, 19, 44, 39, 774, DateTimeKind.Local).AddTicks(2188), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Age", "DoctorId", "Name", "Surname", "createdDate", "updatedDate" },
                values: new object[,]
                {
                    { 1, 35, 1, "hasta1", "sou1", new DateTime(2024, 1, 9, 19, 44, 39, 774, DateTimeKind.Local).AddTicks(2476), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 15, 2, "hasta2", "soy2", new DateTime(2024, 1, 9, 19, 44, 39, 774, DateTimeKind.Local).AddTicks(2477), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 45, 3, "hasta3", "soy3", new DateTime(2024, 1, 9, 19, 44, 39, 774, DateTimeKind.Local).AddTicks(2479), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 65, 4, "hasta4", "soy4", new DateTime(2024, 1, 9, 19, 44, 39, 774, DateTimeKind.Local).AddTicks(2480), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_HospitalId",
                table: "Doctors",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Hospitals");
        }
    }
}
