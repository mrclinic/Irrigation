using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Oracle.EntityFrameworkCore.Metadata;

namespace MANAGEMENTDLL.Migrations
{
    public partial class secondMGT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "INDIC",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    CREATION_DATE = table.Column<DateTime>(nullable: false),
                    USERNB = table.Column<decimal>(nullable: false),
                    NAME = table.Column<string>(maxLength: 100, nullable: false),
                    ORDER = table.Column<string>(maxLength: 100, nullable: false),
                    NOTE = table.Column<string>(maxLength: 300, nullable: true),
                    GOVId = table.Column<decimal>(nullable: false),
                    ZONEId = table.Column<decimal>(nullable: false),
                    SIDEId = table.Column<decimal>(nullable: false),
                    VILId = table.Column<decimal>(nullable: false),
                    AGRISECId = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INDIC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_INDIC_AGRISEC_AGRISECId",
                        column: x => x.AGRISECId,
                        principalTable: "AGRISEC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INDIC_GOVERNORATE_GOVId",
                        column: x => x.GOVId,
                        principalTable: "GOVERNORATE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INDIC_SIDE_SIDEId",
                        column: x => x.SIDEId,
                        principalTable: "SIDE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INDIC_VILLAGE_VILId",
                        column: x => x.VILId,
                        principalTable: "VILLAGE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_INDIC_ZONE_ZONEId",
                        column: x => x.ZONEId,
                        principalTable: "ZONE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_INDIC_AGRISECId",
                table: "INDIC",
                column: "AGRISECId");

            migrationBuilder.CreateIndex(
                name: "IX_INDIC_GOVId",
                table: "INDIC",
                column: "GOVId");

            migrationBuilder.CreateIndex(
                name: "IX_INDIC_SIDEId",
                table: "INDIC",
                column: "SIDEId");

            migrationBuilder.CreateIndex(
                name: "IX_INDIC_VILId",
                table: "INDIC",
                column: "VILId");

            migrationBuilder.CreateIndex(
                name: "IX_INDIC_ZONEId",
                table: "INDIC",
                column: "ZONEId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "INDIC");
        }
    }
}
