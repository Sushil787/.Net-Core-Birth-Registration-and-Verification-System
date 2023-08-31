using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspnetIdentityRoleBasedTutorial.Migrations
{
    /// <inheritdoc />
    public partial class secondmigtationbacchamodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "baccha",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    FatherName = table.Column<string>(type: "TEXT", nullable: false),
                    MotherName = table.Column<string>(type: "TEXT", nullable: false),
                    GrandFatherName = table.Column<string>(type: "TEXT", nullable: true),
                    GrandMotherName = table.Column<string>(type: "TEXT", nullable: true),
                    HomeLocation = table.Column<string>(type: "TEXT", nullable: false),
                    HospitalName = table.Column<string>(type: "TEXT", nullable: true),
                    HospitaLocation = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsVerified = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_baccha", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "baccha");
        }
    }
}
