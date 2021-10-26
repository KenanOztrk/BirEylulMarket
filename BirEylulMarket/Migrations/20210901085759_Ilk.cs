using Microsoft.EntityFrameworkCore.Migrations;

namespace BirEylulMarket.Migrations
{
    public partial class Ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAd = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BirimFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urunler_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "KategoriAd" },
                values: new object[,]
                {
                    { 1, "İçecekler" },
                    { 2, "Süt Ürünleri" },
                    { 3, "Hırdavat" },
                    { 4, "Yiyecek" }
                });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "Id", "BirimFiyat", "KategoriId", "UrunAd" },
                values: new object[,]
                {
                    { 1, 4.50m, 1, "Kola" },
                    { 2, 2.50m, 1, "Soda" },
                    { 3, 3.50m, 2, "Ayran" },
                    { 4, 7.50m, 2, "Yoğurt" },
                    { 5, 12.50m, 3, "Çekiç" },
                    { 6, 9.50m, 3, "Çivi" },
                    { 7, 22.50m, 4, "Tavuk" },
                    { 8, 24.99m, 4, "Pizza" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_KategoriId",
                table: "Urunler",
                column: "KategoriId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
