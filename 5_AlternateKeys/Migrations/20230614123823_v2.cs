using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _5_AlternateKeys.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Objectives_AltKey",
                table: "Objectives");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Objectives_AltKey_PartOfKey",
                table: "Objectives",
                columns: new[] { "AltKey", "PartOfKey" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Objectives_AltKey_PartOfKey",
                table: "Objectives");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Objectives_AltKey",
                table: "Objectives",
                column: "AltKey");
        }
    }
}
