using Microsoft.EntityFrameworkCore.Migrations;

namespace Kitapçı3.Migrations
{
    public partial class denem4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fiyat",
                table: "romen",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Yayınevi",
                table: "romen",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fiyat",
                table: "psikolojis",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Yayınevi",
                table: "psikolojis",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fiyat",
                table: "kitaps",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Yayınevi",
                table: "kitaps",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fiyat",
                table: "felseves",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Yayınevi",
                table: "felseves",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Fiyat",
                table: "bilims",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Yayınevi",
                table: "bilims",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "romen");

            migrationBuilder.DropColumn(
                name: "Yayınevi",
                table: "romen");

            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "psikolojis");

            migrationBuilder.DropColumn(
                name: "Yayınevi",
                table: "psikolojis");

            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "kitaps");

            migrationBuilder.DropColumn(
                name: "Yayınevi",
                table: "kitaps");

            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "felseves");

            migrationBuilder.DropColumn(
                name: "Yayınevi",
                table: "felseves");

            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "bilims");

            migrationBuilder.DropColumn(
                name: "Yayınevi",
                table: "bilims");
        }
    }
}
