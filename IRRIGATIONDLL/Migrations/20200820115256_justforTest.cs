using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Oracle.EntityFrameworkCore.Metadata;

namespace IRRIGATIONDLL.Migrations
{
    public partial class justforTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CONSTANTINDEX",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    CREATION_DATE = table.Column<DateTime>(nullable: false),
                    USERNB = table.Column<decimal>(nullable: false),
                    NAME = table.Column<string>(maxLength: 100, nullable: false),
                    TYPE = table.Column<string>(maxLength: 100, nullable: false),
                    ORDER = table.Column<string>(maxLength: 100, nullable: false),
                    NOTE = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONSTANTINDEX", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SETTING",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    CREATION_DATE = table.Column<DateTime>(nullable: false),
                    USERNB = table.Column<decimal>(nullable: false),
                    NAME = table.Column<string>(maxLength: 100, nullable: false),
                    TITLE = table.Column<string>(maxLength: 100, nullable: false),
                    VALUE = table.Column<string>(maxLength: 100, nullable: false),
                    NOTE = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SETTING", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CONSTANTINDEX");

            migrationBuilder.DropTable(
                name: "SETTING");
        }
    }
}
