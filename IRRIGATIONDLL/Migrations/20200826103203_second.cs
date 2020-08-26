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
                name: "GOVERNORATE",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    CREATION_DATE = table.Column<DateTime>(nullable: false),
                    USERNB = table.Column<decimal>(nullable: false),
                    NAME = table.Column<string>(maxLength: 100, nullable: false),
                    ORDER = table.Column<string>(maxLength: 100, nullable: false),
                    NOTE = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GOVERNORATE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AGRIDIR",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    CREATION_DATE = table.Column<DateTime>(nullable: false),
                    USERNB = table.Column<decimal>(nullable: false),
                    NAME = table.Column<string>(maxLength: 100, nullable: false),
                    ORDER = table.Column<string>(maxLength: 100, nullable: false),
                    NOTE = table.Column<string>(maxLength: 300, nullable: true),
                    GOVId = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGRIDIR", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AGRIDIR_GOVERNORATE_GOVId",
                        column: x => x.GOVId,
                        principalTable: "GOVERNORATE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AREA",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    CREATION_DATE = table.Column<DateTime>(nullable: false),
                    USERNB = table.Column<decimal>(nullable: false),
                    NAME = table.Column<string>(maxLength: 100, nullable: false),
                    ORDER = table.Column<string>(maxLength: 100, nullable: false),
                    NOTE = table.Column<string>(maxLength: 300, nullable: true),
                    GOVId = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AREA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AREA_GOVERNORATE_GOVId",
                        column: x => x.GOVId,
                        principalTable: "GOVERNORATE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BRANCH",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    CREATION_DATE = table.Column<DateTime>(nullable: false),
                    USERNB = table.Column<decimal>(nullable: false),
                    NAME = table.Column<string>(maxLength: 100, nullable: false),
                    ORDER = table.Column<string>(maxLength: 100, nullable: false),
                    NOTE = table.Column<string>(maxLength: 300, nullable: true),
                    HEADNAME = table.Column<string>(maxLength: 100, nullable: false),
                    GOVId = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BRANCH", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BRANCH_GOVERNORATE_GOVId",
                        column: x => x.GOVId,
                        principalTable: "GOVERNORATE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "COMPANY",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    CREATION_DATE = table.Column<DateTime>(nullable: false),
                    USERNB = table.Column<decimal>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "ZONE",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    CREATION_DATE = table.Column<DateTime>(nullable: false),
                    USERNB = table.Column<decimal>(nullable: false),
                    NAME = table.Column<string>(maxLength: 100, nullable: false),
                    ORDER = table.Column<string>(maxLength: 100, nullable: false),
                    NOTE = table.Column<string>(maxLength: 300, nullable: true),
                    GOVId = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZONE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZONE_GOVERNORATE_GOVId",
                        column: x => x.GOVId,
                        principalTable: "GOVERNORATE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGRIDEP",
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
                    AGRIDIRId = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGRIDEP", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AGRIDEP_AGRIDIR_AGRIDIRId",
                        column: x => x.AGRIDIRId,
                        principalTable: "AGRIDIR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGRIDEP_GOVERNORATE_GOVId",
                        column: x => x.GOVId,
                        principalTable: "GOVERNORATE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CIRCLE",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    CREATION_DATE = table.Column<DateTime>(nullable: false),
                    USERNB = table.Column<decimal>(nullable: false),
                    NAME = table.Column<string>(maxLength: 100, nullable: false),
                    ORDER = table.Column<string>(maxLength: 100, nullable: false),
                    NOTE = table.Column<string>(maxLength: 300, nullable: true),
                    HEADNAME = table.Column<string>(maxLength: 100, nullable: false),
                    GOVId = table.Column<decimal>(nullable: false),
                    BRANCHId = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIRCLE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CIRCLE_BRANCH_BRANCHId",
                        column: x => x.BRANCHId,
                        principalTable: "BRANCH",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CIRCLE_GOVERNORATE_GOVId",
                        column: x => x.GOVId,
                        principalTable: "GOVERNORATE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SIDE",
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
                    ZONEId = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIDE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SIDE_GOVERNORATE_GOVId",
                        column: x => x.GOVId,
                        principalTable: "GOVERNORATE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SIDE_ZONE_ZONEId",
                        column: x => x.ZONEId,
                        principalTable: "ZONE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SECTION",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false)
                        .Annotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn),
                    CREATION_DATE = table.Column<DateTime>(nullable: false),
                    USERNB = table.Column<decimal>(nullable: false),
                    NAME = table.Column<string>(maxLength: 100, nullable: false),
                    ORDER = table.Column<string>(maxLength: 100, nullable: false),
                    NOTE = table.Column<string>(maxLength: 300, nullable: true),
                    HEADNAME = table.Column<string>(maxLength: 100, nullable: false),
                    GOVId = table.Column<decimal>(nullable: false),
                    BRANCHId = table.Column<decimal>(nullable: false),
                    CIRCLEId = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECTION", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SECTION_BRANCH_BRANCHId",
                        column: x => x.BRANCHId,
                        principalTable: "BRANCH",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SECTION_CIRCLE_CIRCLEId",
                        column: x => x.CIRCLEId,
                        principalTable: "CIRCLE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SECTION_GOVERNORATE_GOVId",
                        column: x => x.GOVId,
                        principalTable: "GOVERNORATE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AGRISEC",
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
                    AGRIDIRId = table.Column<decimal>(nullable: false),
                    AGRIDEPId = table.Column<decimal>(nullable: false),
                    ZONEId = table.Column<decimal>(nullable: false),
                    SIDEId = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AGRISEC", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AGRISEC_AGRIDEP_AGRIDEPId",
                        column: x => x.AGRIDEPId,
                        principalTable: "AGRIDEP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGRISEC_AGRIDIR_AGRIDIRId",
                        column: x => x.AGRIDIRId,
                        principalTable: "AGRIDIR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGRISEC_GOVERNORATE_GOVId",
                        column: x => x.GOVId,
                        principalTable: "GOVERNORATE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGRISEC_SIDE_SIDEId",
                        column: x => x.SIDEId,
                        principalTable: "SIDE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AGRISEC_ZONE_ZONEId",
                        column: x => x.ZONEId,
                        principalTable: "ZONE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VILLAGE",
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
                    SIDEId = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VILLAGE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VILLAGE_GOVERNORATE_GOVId",
                        column: x => x.GOVId,
                        principalTable: "GOVERNORATE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VILLAGE_SIDE_SIDEId",
                        column: x => x.SIDEId,
                        principalTable: "SIDE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VILLAGE_ZONE_ZONEId",
                        column: x => x.ZONEId,
                        principalTable: "ZONE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_AGRIDEP_AGRIDIRId",
                table: "AGRIDEP",
                column: "AGRIDIRId");

            migrationBuilder.CreateIndex(
                name: "IX_AGRIDEP_GOVId",
                table: "AGRIDEP",
                column: "GOVId");

            migrationBuilder.CreateIndex(
                name: "IX_AGRIDIR_GOVId",
                table: "AGRIDIR",
                column: "GOVId");

            migrationBuilder.CreateIndex(
                name: "IX_AGRISEC_AGRIDEPId",
                table: "AGRISEC",
                column: "AGRIDEPId");

            migrationBuilder.CreateIndex(
                name: "IX_AGRISEC_AGRIDIRId",
                table: "AGRISEC",
                column: "AGRIDIRId");

            migrationBuilder.CreateIndex(
                name: "IX_AGRISEC_GOVId",
                table: "AGRISEC",
                column: "GOVId");

            migrationBuilder.CreateIndex(
                name: "IX_AGRISEC_SIDEId",
                table: "AGRISEC",
                column: "SIDEId");

            migrationBuilder.CreateIndex(
                name: "IX_AGRISEC_ZONEId",
                table: "AGRISEC",
                column: "ZONEId");

            migrationBuilder.CreateIndex(
                name: "IX_AREA_GOVId",
                table: "AREA",
                column: "GOVId");

            migrationBuilder.CreateIndex(
                name: "IX_BRANCH_GOVId",
                table: "BRANCH",
                column: "GOVId");

            migrationBuilder.CreateIndex(
                name: "IX_CIRCLE_BRANCHId",
                table: "CIRCLE",
                column: "BRANCHId");

            migrationBuilder.CreateIndex(
                name: "IX_CIRCLE_GOVId",
                table: "CIRCLE",
                column: "GOVId");

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

            migrationBuilder.CreateIndex(
                name: "IX_SECTION_BRANCHId",
                table: "SECTION",
                column: "BRANCHId");

            migrationBuilder.CreateIndex(
                name: "IX_SECTION_CIRCLEId",
                table: "SECTION",
                column: "CIRCLEId");

            migrationBuilder.CreateIndex(
                name: "IX_SECTION_GOVId",
                table: "SECTION",
                column: "GOVId");

            migrationBuilder.CreateIndex(
                name: "IX_SIDE_GOVId",
                table: "SIDE",
                column: "GOVId");

            migrationBuilder.CreateIndex(
                name: "IX_SIDE_ZONEId",
                table: "SIDE",
                column: "ZONEId");

            migrationBuilder.CreateIndex(
                name: "IX_VILLAGE_GOVId",
                table: "VILLAGE",
                column: "GOVId");

            migrationBuilder.CreateIndex(
                name: "IX_VILLAGE_SIDEId",
                table: "VILLAGE",
                column: "SIDEId");

            migrationBuilder.CreateIndex(
                name: "IX_VILLAGE_ZONEId",
                table: "VILLAGE",
                column: "ZONEId");

            migrationBuilder.CreateIndex(
                name: "IX_ZONE_GOVId",
                table: "ZONE",
                column: "GOVId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AREA");

            migrationBuilder.DropTable(
                name: "COMPANY");

            migrationBuilder.DropTable(
                name: "INDIC");

            migrationBuilder.DropTable(
                name: "SECTION");

            migrationBuilder.DropTable(
                name: "AGRISEC");

            migrationBuilder.DropTable(
                name: "VILLAGE");

            migrationBuilder.DropTable(
                name: "CIRCLE");

            migrationBuilder.DropTable(
                name: "AGRIDEP");

            migrationBuilder.DropTable(
                name: "SIDE");

            migrationBuilder.DropTable(
                name: "BRANCH");

            migrationBuilder.DropTable(
                name: "AGRIDIR");

            migrationBuilder.DropTable(
                name: "ZONE");

            migrationBuilder.DropTable(
                name: "GOVERNORATE");
        }
    }
}
