using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkulEFAppProject.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblDersler",
                columns: table => new
                {
                    DersId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersKod = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    DersAd = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblDersler", x => x.DersId);
                });

            migrationBuilder.CreateTable(
                name: "tblSiniflar",
                columns: table => new
                {
                    SinifId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SinifAd = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Kontenjan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSiniflar", x => x.SinifId);
                });

            migrationBuilder.CreateTable(
                name: "tblOgrenciler",
                columns: table => new
                {
                    OgrenciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numara = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Ad = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Soyad = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    SinifId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOgrenciler", x => x.OgrenciId);
                    table.ForeignKey(
                        name: "FK_tblOgrenciler_tblSiniflar_SinifId",
                        column: x => x.SinifId,
                        principalTable: "tblSiniflar",
                        principalColumn: "SinifId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblOgrenciDers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DersId = table.Column<int>(type: "int", nullable: false),
                    OgrenciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblOgrenciDers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblOgrenciDers_tblDersler_DersId",
                        column: x => x.DersId,
                        principalTable: "tblDersler",
                        principalColumn: "DersId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblOgrenciDers_tblOgrenciler_OgrenciId",
                        column: x => x.OgrenciId,
                        principalTable: "tblOgrenciler",
                        principalColumn: "OgrenciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblDersler_DersKod",
                table: "tblDersler",
                column: "DersKod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblOgrenciDers_DersId",
                table: "tblOgrenciDers",
                column: "DersId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOgrenciDers_OgrenciId",
                table: "tblOgrenciDers",
                column: "OgrenciId");

            migrationBuilder.CreateIndex(
                name: "IX_tblOgrenciler_Numara",
                table: "tblOgrenciler",
                column: "Numara",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblOgrenciler_SinifId",
                table: "tblOgrenciler",
                column: "SinifId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSiniflar_SinifAd",
                table: "tblSiniflar",
                column: "SinifAd",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblOgrenciDers");

            migrationBuilder.DropTable(
                name: "tblDersler");

            migrationBuilder.DropTable(
                name: "tblOgrenciler");

            migrationBuilder.DropTable(
                name: "tblSiniflar");
        }
    }
}
