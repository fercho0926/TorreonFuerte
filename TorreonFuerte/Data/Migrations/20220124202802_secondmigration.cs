using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TorreonFuerte.Data.Migrations
{
    public partial class secondmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    IdMenbers = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    City = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Neighborhood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnumLevels = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.IdMenbers);
                });

            migrationBuilder.CreateTable(
                name: "Networks",
                columns: table => new
                {
                    IdCell = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NetworkCell = table.Column<int>(type: "int", nullable: false),
                    NameCell = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembersIdMenbers = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Networks", x => x.IdCell);
                    table.ForeignKey(
                        name: "FK_Networks_Members_MembersIdMenbers",
                        column: x => x.MembersIdMenbers,
                        principalTable: "Members",
                        principalColumn: "IdMenbers",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Networks_MembersIdMenbers",
                table: "Networks",
                column: "MembersIdMenbers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Networks");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
