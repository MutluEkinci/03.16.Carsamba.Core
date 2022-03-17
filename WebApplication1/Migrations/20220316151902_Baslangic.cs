using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Baslangic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Filmler",
                columns: table => new
                {
                    FilmID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sure = table.Column<int>(type: "int", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    Ozet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Altyazili = table.Column<bool>(type: "bit", nullable: false),
                    Afis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmler", x => x.FilmID);
                    table.ForeignKey(
                        name: "FK_Filmler_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriID", "KategoriAdi" },
                values: new object[] { 1, "Macera" });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriID", "KategoriAdi" },
                values: new object[] { 2, "Savaş" });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriID", "KategoriAdi" },
                values: new object[] { 3, "Komedi" });

            migrationBuilder.InsertData(
                table: "Filmler",
                columns: new[] { "FilmID", "Afis", "Altyazili", "FilmAdi", "KategoriID", "Ozet", "Sure" },
                values: new object[,]
                {
                    { 1, "ij_1.jpg", false, "Indiana Jones", 1, null, 95 },
                    { 3, "fury.jpg", false, "Fury", 2, null, 106 },
                    { 2, "av.jpg", true, "Ace Ventura", 3, null, 98 },
                    { 4, "bf.jpg", true, "Bebek Firarda", 3, null, 103 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_KategoriID",
                table: "Filmler",
                column: "KategoriID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Filmler");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
