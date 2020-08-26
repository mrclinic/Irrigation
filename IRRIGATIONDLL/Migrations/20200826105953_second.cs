using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Oracle.EntityFrameworkCore.Metadata;

namespace IRRIGATIONDLL.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "COMPANY",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    CREATION_DATE = table.Column<DateTime>(nullable: true),
                    CREATE_USERNB = table.Column<decimal>(nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(nullable: true),
                    UPDATE_USERNB = table.Column<decimal>(nullable: true),
                    NAME = table.Column<string>(maxLength: 300, nullable: false),
                    ADJId = table.Column<decimal>(nullable: false),
                    STRId = table.Column<decimal>(nullable: false),
                    GOVId = table.Column<decimal>(nullable: false),
                    ADDRESS = table.Column<string>(maxLength: 300, nullable: false),
                    PHONE = table.Column<string>(maxLength: 30, nullable: true),
                    MOBILE = table.Column<string>(maxLength: 30, nullable: true),
                    FAX = table.Column<string>(maxLength: 30, nullable: true),
                    STAId = table.Column<decimal>(nullable: false),
                    NOTE = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPANY", x => x.Id);
                    table.ForeignKey(
                        name: "FK_COMPANY_CONSTANT_ADJId",
                        column: x => x.ADJId,
                        principalTable: "CONSTANT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_COMPANY_GOVERNORATE_GOVId",
                        column: x => x.GOVId,
                        principalTable: "GOVERNORATE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_COMPANY_CONSTANT_STAId",
                        column: x => x.STAId,
                        principalTable: "CONSTANT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_COMPANY_CONSTANT_STRId",
                        column: x => x.STRId,
                        principalTable: "CONSTANT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_ADJId",
                table: "COMPANY",
                column: "ADJId");

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_GOVId",
                table: "COMPANY",
                column: "GOVId");

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_STAId",
                table: "COMPANY",
                column: "STAId");

            migrationBuilder.CreateIndex(
                name: "IX_COMPANY_STRId",
                table: "COMPANY",
                column: "STRId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "COMPANY");
        }
    }
}
