using Microsoft.EntityFrameworkCore.Migrations;

namespace Kitapçı3.Migrations
{
    public partial class deneme6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "YeniKitaps",
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
                    table.PrimaryKey("PK_YeniKitaps", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "YeniKitaps");
        }
    }
}
