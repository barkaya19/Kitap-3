using Microsoft.EntityFrameworkCore.Migrations;

namespace Kitapçı3.Migrations
{
    public partial class deneme8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "üyes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    Eposta = table.Column<string>(nullable: true),
                    Sifre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_üyes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "yeniÇıkanKitaps",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kitapad = table.Column<string>(nullable: true),
                    Fiyat = table.Column<int>(nullable: false),
                    Yayınevi = table.Column<string>(nullable: true),
                    Tarih = table.Column<int>(nullable: false),
                    Yazar = table.Column<string>(nullable: true),
                    Hakkında = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yeniÇıkanKitaps", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "üyes");

            migrationBuilder.DropTable(
                name: "yeniÇıkanKitaps");
        }
    }
}
