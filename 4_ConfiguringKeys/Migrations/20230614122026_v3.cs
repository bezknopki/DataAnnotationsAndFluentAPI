using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _4_ConfiguringKeys.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Objectives",
                table: "Objectives");

            migrationBuilder.AddPrimaryKey(
                name: "ObjectivesPrimaryKey",
                table: "Objectives",
                column: "Number");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "ObjectivesPrimaryKey",
                table: "Objectives");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Objectives",
                table: "Objectives",
                column: "Number");
        }
    }
}
