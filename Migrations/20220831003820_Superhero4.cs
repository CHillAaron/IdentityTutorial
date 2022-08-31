using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityTutorial.Migrations
{
    public partial class Superhero4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SuperHeroes_AspNetUsers_ApplicationUserId",
                table: "SuperHeroes");

            migrationBuilder.DropIndex(
                name: "IX_SuperHeroes_ApplicationUserId",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "SuperHeroes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "SuperHeroes",
                type: "varchar(255)",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_SuperHeroes_ApplicationUserId",
                table: "SuperHeroes",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SuperHeroes_AspNetUsers_ApplicationUserId",
                table: "SuperHeroes",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
