using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiProject1.Migrations
{
    public partial class Initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PortSlots",
                columns: table => new
                {
                    Slotid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ruid = table.Column<int>(type: "int", nullable: true),
                    Sluid = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Startdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Enddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cost = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortSlots", x => x.Slotid);
                });

            migrationBuilder.CreateTable(
                name: "PortUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sluid = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<long>(type: "bigint", nullable: true),
                    Cost = table.Column<long>(type: "bigint", nullable: true),
                    Startdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Enddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Usertype = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortUsers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PortSlots");

            migrationBuilder.DropTable(
                name: "PortUsers");
        }
    }
}
