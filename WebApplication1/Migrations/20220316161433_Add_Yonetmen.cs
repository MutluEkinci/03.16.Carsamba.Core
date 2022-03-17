using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Add_Yonetmen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YonetmenID",
                table: "Filmler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Yonetmenler",
                columns: table => new
                {
                    YonetmenID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YonetmenAdi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yonetmenler", x => x.YonetmenID);
                });

            migrationBuilder.InsertData(
                table: "Yonetmenler",
                columns: new[] { "YonetmenID", "YonetmenAdi" },
                values: new object[] { 1, "Tarantino" });

            migrationBuilder.InsertData(
                table: "Yonetmenler",
                columns: new[] { "YonetmenID", "YonetmenAdi" },
                values: new object[] { 2, "Mel Gibson" });

            migrationBuilder.UpdateData(
                table: "Filmler",
                keyColumn: "FilmID",
                keyValue: 1,
                column: "YonetmenID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Filmler",
                keyColumn: "FilmID",
                keyValue: 2,
                column: "YonetmenID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Filmler",
                keyColumn: "FilmID",
                keyValue: 3,
                column: "YonetmenID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Filmler",
                keyColumn: "FilmID",
                keyValue: 4,
                column: "YonetmenID",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Filmler_YonetmenID",
                table: "Filmler",
                column: "YonetmenID");

            migrationBuilder.AddForeignKey(
                name: "FK_Filmler_Yonetmenler_YonetmenID",
                table: "Filmler",
                column: "YonetmenID",
                principalTable: "Yonetmenler",
                principalColumn: "YonetmenID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Filmler_Yonetmenler_YonetmenID",
                table: "Filmler");

            migrationBuilder.DropTable(
                name: "Yonetmenler");

            migrationBuilder.DropIndex(
                name: "IX_Filmler_YonetmenID",
                table: "Filmler");

            migrationBuilder.DropColumn(
                name: "YonetmenID",
                table: "Filmler");
        }
    }
}
