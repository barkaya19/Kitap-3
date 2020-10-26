using Microsoft.EntityFrameworkCore.Migrations;

namespace Kitapçı3.Migrations
{
    public partial class deneme3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Soyad",
                table: "romen");

            migrationBuilder.DropColumn(
                name: "Soyad",
                table: "psikolojis");

            migrationBuilder.DropColumn(
                name: "Soyad",
                table: "bilims");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Soyad",
                table: "romen",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Soyad",
                table: "psikolojis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Soyad",
                table: "bilims",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
