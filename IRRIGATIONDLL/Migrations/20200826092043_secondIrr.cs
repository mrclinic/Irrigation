using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Oracle.EntityFrameworkCore.Metadata;

namespace IRRIGATIONDLL.Migrations
{
    public partial class secondIrr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    CREATION_DATE = table.Column<DateTime>(nullable: false),
                    USERNB = table.Column<decimal>(nullable: false),
                    NAME = table.Column<string>(maxLength: 300, nullable: false),
                    KINDId = table.Column<decimal>(nullable: false),
                    NOTE = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PRODUCT_CONSTANT_KINDId",
                        column: x => x.KINDId,
                        principalTable: "CONSTANT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_KINDId",
                table: "PRODUCT",
                column: "KINDId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRODUCT");
        }
    }
}
