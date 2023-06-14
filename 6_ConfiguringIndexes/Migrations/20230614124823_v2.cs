using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _6_ConfiguringIndexes.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Passport",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Passport",
                table: "Users",
                column: "Passport",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Passport",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Passport",
                table: "Users",
                column: "Passport");
        }
    }
}
