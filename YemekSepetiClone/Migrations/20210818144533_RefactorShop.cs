using Microsoft.EntityFrameworkCore.Migrations;

namespace YemekSepetiClone.Migrations
{
    public partial class RefactorShop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Explanation",
                table: "Shops",
                newName: "ServiceTime");

            migrationBuilder.AddColumn<string>(
                name: "MinPrice",
                table: "Shops",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ServiceQuality",
                table: "Shops",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Speed",
                table: "Shops",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TasteQuality",
                table: "Shops",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinPrice",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "ServiceQuality",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "Speed",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "TasteQuality",
                table: "Shops");

            migrationBuilder.RenameColumn(
                name: "ServiceTime",
                table: "Shops",
                newName: "Explanation");
        }
    }
}
